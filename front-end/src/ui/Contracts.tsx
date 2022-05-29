import { FunctionComponent, useEffect, useState } from 'react'
import styled from 'styled-components'
import {
  addContract,
  deleteContract,
  getAllContracts,
  getFaculties,
  getFacultySpecialisations
} from '../state/thunks/contracts'
import { useDispatch, useSelector } from 'react-redux'
import { AppState } from '../state/store'
import { Button } from '@mui/material'
import { useFormik } from 'formik'
import { FetchStatus } from '../utility/fetchStatus'
import { Degree, Faculty, Specialisation } from '../utility/types/studentTypes'
import { StudyContractEnriched } from '../utility/types/contractTypes'
import { contractActions } from '../state/slices/contracts'

const MainContainer = styled.div`
  display: flex;
  padding: 40px 25px;
  width: 100%;
  height: 100%;
`

const ContractContainer = styled.div<{ isActive?: boolean }>`
  width: 80%;
  border: ${props => (props.isActive ? '5px solid green' : '5px solid green')};
  border-color: ${props => (props.isActive ? '#96a2b4' : '#D6DEEA')};
  padding: 50px;
  border-radius: 25px;
  ${props => (props.isActive ? 'background: #D6DEEA' : '')}
`

export default function Contract({ contract }) {
  return (
    <div
      style={{
        width: '300px',
        border: '5px solid green',
        borderColor: '#96a2b4',
        padding: '50px',
        borderRadius: '25px'
      }}
      onClick={() => {
        console.log('div with id ' + contract.id + ' was clicked')
      }}
    >
      {contract.id}
    </div>
  )
}

export const Contracts: FunctionComponent = () => {
  const state = useSelector((state: AppState) => state.contracts)
  const facultyState = useSelector((state: AppState) => state.faculties)
  const token = useSelector((state: AppState) => state.global.accessToken)

  const dispatch = useDispatch()

  const [selectedContract, setSelectedContract] =
    useState<StudyContractEnriched | null>()
  const [filteredFaculties, setFilteredFaculties] = useState<Faculty[]>([])
  const [specialisation, setSpecialisation] = useState<Specialisation | null>()
  const [faculty, setFaculty] = useState<Faculty | null>()
  const [degree, setDegree] = useState<Degree | null>()

  const Dropdown = ({ options, field, val, disabled }) => {
    return (
      <select
        value={val}
        disabled={options.length == 0}
        onChange={e => {
          if (field == 'Faculty') {
            setFaculty(filteredFaculties[e.target.options.selectedIndex])
          } else if (field == 'Specialisation') {
            setSpecialisation(
              facultyState.specialisations[e.target.options.selectedIndex]
            )
          } else if (field == 'Degree') {
            setDegree(facultyState.degrees[e.target.options.selectedIndex])
          }
        }}
        style={{
          background: '#0f1218',
          color: '#96a2b4',
          height: '40px',
          fontSize: '20px',
          width: '40%'
        }}
      >
        {options.map(o => (
          <option key={o.id} value={o.name} id={o.id}>
            {o.name}
          </option>
        ))}
      </select>
    )
  }

  useEffect(() => {
    if (state.contractsStatus != FetchStatus.success) {
      dispatch(getAllContracts(token))
    }
  }, [dispatch, state.contractsStatus, token])

  useEffect(() => {
    dispatch(getFaculties())
  }, [dispatch])

  useEffect(() => {
    if (
      facultyState.facultyStatus === FetchStatus.success &&
      filteredFaculties
    ) {
      if (!faculty || !specialisation || !degree) {
        setFaculty(filteredFaculties[0] ?? null)
        setSpecialisation(facultyState.specialisations[0] ?? null)
        setDegree(facultyState.degrees[0] ?? null)
      }
    }
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [facultyState.facultyStatus, filteredFaculties])

  useEffect(() => {
    if (
      state.contractsStatus === FetchStatus.success &&
      facultyState.facultyStatus === FetchStatus.success
    ) {
      const activeFaculties = state.contracts.map(contract => contract.faculty)
      console.log(activeFaculties, facultyState.faculties)
      setFilteredFaculties(
        facultyState.faculties.filter(x => !activeFaculties.includes(x.name))
      )
    }
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [state.contractsStatus, facultyState.facultyStatus])

  useEffect(() => {
    if (
      facultyState.facultyStatus == FetchStatus.success &&
      faculty &&
      degree
    ) {
      dispatch(
        getFacultySpecialisations({
          facultyId: faculty.id,
          degreeId: degree.id
        })
      )
    }
  }, [dispatch, faculty, degree, facultyState.facultyStatus])

  useEffect(() => {
    setSpecialisation(facultyState.specialisations[0])
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [facultyState.specialisations])

  return (
    <MainContainer>
      <div
        style={{
          paddingTop: '50px',
          width: '49%',
          height: '100vh',
          float: 'right'
        }}
      >
        <Button
          variant="outlined"
          style={{ float: 'right', top: -50, marginLeft: 5 }}
          onClick={async () => {
            console.log(faculty, degree, specialisation)
            if (specialisation) {
              await Promise.all([
                dispatch(
                  addContract({
                    specialisationId: specialisation.id,
                    token: token
                  })
                )
              ]).then(() => dispatch(contractActions.resetContractsStatus()))
            }
          }}
        >
          +
        </Button>
        <Button
          variant="outlined"
          style={{ float: 'right', top: -50, marginLeft: 5 }}
          onClick={async () => {
            if (selectedContract) {
              await Promise.all([
                dispatch(
                  deleteContract({
                    contractId: selectedContract?.id,
                    token: token
                  })
                )
              ]).then(() => dispatch(contractActions.resetContractsStatus()))
            }
          }}
        >
          -
        </Button>
        <Button
          variant="outlined"
          style={{ float: 'right', top: -50, marginLeft: 5 }}
          disabled={!selectedContract}
          onClick={() => {
            window.location.replace(`/contracts/${selectedContract?.id}`)
          }}
        >
          edit
        </Button>
        <p>
          <b>
            {state.contracts.length >= 2 &&
              'You cannot add more than two contracts'}
            {state.contracts.length < 2 && 'You can add another contract'}
          </b>
        </p>
        <br /> <br />
        <p>Faculty : </p>
        <Dropdown
          options={filteredFaculties}
          field="Faculty"
          val={faculty?.name || 'Select'}
          disabled={state.contracts.length >= 2}
        />
        <br /> <br />
        <p>Degree : </p>
        <Dropdown
          options={facultyState.degrees}
          field="Degree"
          val={degree?.name || 'Select'}
          disabled={state.contracts.length >= 2}
        />
        <br /> <br />
        <p>Specialisation : </p>
        <Dropdown
          options={facultyState.specialisations}
          field="Specialisation"
          val={specialisation?.name || 'Select'}
          disabled={state.contracts.length >= 2}
        />
      </div>
      {state.contracts.map(contract => (
        <p key={`contract-${contract.id}`}>
          {(selectedContract?.id == contract.id && (
            <ContractContainer
              isActive
              onClick={() => {
                setSelectedContract(null)
              }}
            >
              Faculty name : {contract.faculty}
              <br />
              Specialisation : {contract.specialisation}
              <br />
              Signed At : {!contract.signedAt && 'not signed yet'}{' '}
              {contract.signedAt && contract.signedAt}
            </ContractContainer>
          )) || (
            <ContractContainer
              onClick={() => {
                setSelectedContract(contract)
              }}
            >
              Faculty name : {contract.faculty}
              <br />
              Specialisation : {contract.specialisation}
              <br />
              Signed At : {!contract.signedAt && 'not signed yet'}{' '}
              {contract.signedAt && contract.signedAt}
            </ContractContainer>
          )}
        </p>
      ))}
    </MainContainer>
  )
}
