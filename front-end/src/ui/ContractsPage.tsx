import { FunctionComponent, useEffect, useState } from 'react'
import styled from 'styled-components'
import {
  addContract,
  deleteContract,
  getAllContracts,
  getFaculties,
  getFacultySpecialisations,
  signContract
} from '../state/thunks/contracts'
import { useDispatch, useSelector } from 'react-redux'
import { AppState } from '../state/store'
import { Button } from '@mui/material'
import { FetchStatus } from '../utility/fetchStatus'
import { Degree, Faculty, Specialisation } from '../utility/types/studentTypes'
import { StudyContractEnriched } from '../utility/types/contractTypes'
import { contractActions } from '../state/slices/contracts'
import { timestampToDate } from '../utility/timeParse'

const MainContainer = styled.div`
  display: flex;
  padding: 40px 25px;
  width: 100%;
  height: 100%;
`

const ContractContainer = styled.div<{ isActive?: boolean }>`
  border: ${props => (props.isActive ? '1px solid green' : '1px solid green')};
  border-color: ${props => (props.isActive ? '#3a3f47' : '#363738')};
  padding: 40px;
  cursor: pointer;
  ${props => (props.isActive ? 'background: #1b1c1e' : '')}
`

const Column = styled.div<{ right?: boolean; left?: boolean }>`
  display: flex;
  flex-direction: column;
  padding: 2%;
  width: 20%;
  height: auto;
  border: 2px solid black;
  background: linear-gradient(#1c212d, #1a202e);
  border-radius: 20px;
  ${props => (props.left ? 'border-top-right-radius: 0px;' : '')}
  ${props => (props.left ? 'border-bottom-right-radius: 0px;' : '')}
  ${props => (props.right ? 'border-top-left-radius: 0px;' : '')}
  ${props => (props.right ? 'border-bottom-left-radius: 0px;' : '')}
`

const DropdownSelector = styled.select`
  background: #0f1218;
  color: #96a2b4;
  height: 40px;
  font-size: 20px;
  cursor: pointer;
`

const ErrorText = styled.p`
  color: #cc3300;
`

const ButtonStyled = styled(Button)`
  border-color: green !important;
  color: green !important;
  :disabled {
    border-color: #3f3f3f !important;
    color: grey !important;
  }
`

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

  useEffect(() => {
    if (state.contractsStatus !== FetchStatus.success) {
      dispatch(getAllContracts(token))
    }
  }, [dispatch, state.contracts, state.contractsStatus, token])

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

  const Dropdown = ({ options, field, val, disabled }) => {
    return (
      <DropdownSelector
        value={val}
        disabled={options.length == 0 || disabled}
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
      >
        {options.map(o => (
          <option key={o.id} value={o.name} id={o.id}>
            {o.name}
          </option>
        ))}
      </DropdownSelector>
    )
  }

  return (
    <MainContainer>
      <Column left>
        <ErrorText>
          {state.contracts.length >= 2 &&
            'You cannot add more than two contracts!'}
        </ErrorText>
        <p style={{ paddingTop: '10px' }}>Faculty : </p>
        <Dropdown
          options={filteredFaculties}
          field="Faculty"
          val={faculty?.name || 'Select'}
          disabled={state.contracts.length >= 2}
        />
        <p style={{ paddingTop: '10px' }}>Degree : </p>
        <Dropdown
          options={facultyState.degrees}
          field="Degree"
          val={degree?.name || 'Select'}
          disabled={state.contracts.length >= 2}
        />
        <p style={{ paddingTop: '10px' }}>Specialisation : </p>
        <Dropdown
          options={facultyState.specialisations}
          field="Specialisation"
          val={specialisation?.name || 'Select'}
          disabled={state.contracts.length >= 2}
        />
        <div
          style={{
            display: 'flex',
            width: '100%',
            justifyContent: 'space-between',
            paddingTop: '15px'
          }}
        >
          <ButtonStyled
            variant="outlined"
            onClick={async () => {
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
            disabled={state.contracts.length >= 2}
          >
            +
          </ButtonStyled>
          <ButtonStyled
            variant="outlined"
            disabled={!selectedContract || !!selectedContract.signedAt}
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
          </ButtonStyled>
          <ButtonStyled
            variant="outlined"
            disabled={!selectedContract}
            onClick={() => {
              window.location.replace(`/contracts/${selectedContract?.id}`)
            }}
          >
            view
          </ButtonStyled>
          <ButtonStyled
            variant="outlined"
            disabled={!selectedContract || !!selectedContract.signedAt}
            onClick={async () => {
              if (
                confirm(
                  "Are you sure you want to sign this contract?\nYou won't be able to edit afterwards."
                )
              )
                if (selectedContract) {
                  await Promise.resolve(
                    dispatch(signContract(selectedContract?.id))
                  ).then(() => {
                    dispatch(contractActions.resetContractsStatus())
                    setSelectedContract(null)
                  })
                }
            }}
          >
            Sign
          </ButtonStyled>
        </div>
      </Column>
      <Column right>
        {state.contracts.map(contract => {
          const isActive = selectedContract?.id == contract.id
          const signedDate = contract.signedAt
            ? timestampToDate(contract.signedAt as number)
            : null
          return (
            <ContractContainer
              isActive={isActive}
              key={`contract-${contract.id}`}
              onClick={() => {
                setSelectedContract(isActive ? null : contract)
              }}
            >
              <p>Faculty: {contract.faculty}</p>
              <p>{contract.specialisation}</p>
              <p>
                Signed at:&nbsp;
                {signedDate
                  ? `${signedDate.toLocaleString('default', {
                      year: 'numeric',
                      month: 'long',
                      day: '2-digit'
                    })}`
                  : 'Unsigned!'}
              </p>
            </ContractContainer>
          )
        })}
      </Column>
    </MainContainer>
  )
}
