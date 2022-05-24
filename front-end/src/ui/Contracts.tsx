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
import { StudyContractEnriched } from '../utility/types/contractTypes'
import { Faculty } from '../utility/types/studentTypes'

const MainContainer = styled.div`
  display: inline-block;
  flex-direction: column;
  padding: 40px 25px;
  width: 100%;
  height: 100%;
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
  const token = useSelector((state: AppState) => state.global.accessToken)
  const state = useSelector((state: AppState) => state.contracts)
  const facultyState = useSelector((state: AppState) => state.faculties)
  const dispatch = useDispatch()

  const [selectedContract, setSelectedContract] = useState('')
  const [filteredFaculties, setFilteredFaculties] = useState<Faculty[]>([])

  const [specialisation, setSpecialisation] = useState('')
  const [faculty, setFaculty] = useState('')
  const [degree, setDegree] = useState('')
  const [facultyId, setFacultyId] = useState('')
  const [degreeId, setDegreeId] = useState('')
  const [specialisationId, setSpecialisationId] = useState('')

  const Dropdown = ({ options, field, val, disabled }) => {
    return (
      <select
        value={val}
        disabled={disabled}
        onChange={e => {
          if (field == 'Faculty') {
            setFaculty(e.target.value), (formik.values.faculty = e.target.value)

            const id =
              e.target.options[e.target.options.selectedIndex].getAttribute(
                'id'
              )
            if (id != null) setFacultyId(id)
          } else if (field == 'Specialisation') {
            setSpecialisation(e.target.value),
              (formik.values.specialisation = e.target.value)
            const id =
              e.target.options[e.target.options.selectedIndex].getAttribute(
                'id'
              )

            if (id != null) {
              setSpecialisationId(id)
              formik.values.specialisationId = id
            }
          } else if (field == 'Degree') {
            setDegree(e.target.value), (formik.values.degree = e.target.value)
            const id =
              e.target.options[e.target.options.selectedIndex].getAttribute(
                'id'
              )
            if (id != null) setDegreeId(id)
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

  const formik = useFormik({
    initialValues: {
      faculty: faculty,
      specialisation: specialisation,
      degree: degree,
      facultyId: facultyId,
      degreeId: degreeId,
      specialisationId: specialisationId
    },
    onSubmit: values => {
      dispatch(
        addContract({ specialisationId: values.specialisationId, token: token })
      )
    }
  })

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
      state.contractsStatus === FetchStatus.success &&
      facultyState.facultyStatus === FetchStatus.success
    ) {
      setFilteredFaculties(
        facultyState.faculties.filter(
          x => x.name != state.contracts[0]?.faculty
        )
      )
      console.log('succes', facultyState.faculties, state.contracts)
    }
  }, [state.contractsStatus, facultyState.facultyStatus])

  useEffect(() => {
    if (facultyState.facultyStatus == FetchStatus.success) {
      dispatch(
        getFacultySpecialisations({
          facultyId,
          degreeId
        })
      )
    }
  }, [degreeId, dispatch, faculty, facultyId, facultyState.facultyStatus])

  return (
    <MainContainer>
      Contracts
      <br />
      <br />
      <div
        style={{
          width: '49%',
          height: '100vh',
          float: 'left'
        }}
      >
        {state.contracts.map(contract => (
          <p key={contract.id}>
            {selectedContract == contract.id && (
              <div
                style={{
                  width: '80%',
                  border: '5px solid green',
                  borderColor: '#96a2b4',
                  padding: '50px',
                  borderRadius: '25px',
                  background: '#D6DEEA'
                }}
                onClick={() => {
                  console.log('div with id ' + contract.id + ' was clicked')
                  setSelectedContract(contract.id)
                  console.log(selectedContract)
                }}
              >
                Faculty name : {contract.faculty}
                <br />
                Specialisation : {contract.specialisation}
                <br />
                Signed At : {!contract.signedAt && 'not signed yet'}{' '}
                {contract.signedAt && contract.signedAt}
              </div>
            )}
            {selectedContract != contract.id && (
              <div
                style={{
                  width: '80%',
                  border: '5px solid green',
                  borderColor: '#96a2b4',
                  padding: '50px',
                  borderRadius: '25px'
                }}
                onClick={() => {
                  console.log('div with id ' + contract.id + ' was clicked')
                  setSelectedContract(contract.id)
                  console.log(selectedContract)
                }}
              >
                Faculty name : {contract.faculty}
                <br />
                Specialisation : {contract.specialisation}
                <br />
                Signed At : {!contract.signedAt && 'not signed yet'}{' '}
                {contract.signedAt && contract.signedAt}
              </div>
            )}
            <br />
            <br />
          </p>
        ))}
      </div>
      <div
        style={{
          width: '49%',
          height: '100vh',
          float: 'right'
        }}
      >
        <form onSubmit={formik.handleSubmit}>
          <Button
            variant="outlined"
            style={{ float: 'right', top: -50, marginLeft: 5 }}
            type="submit"
          >
            +
          </Button>
        </form>
        <Button
          variant="outlined"
          style={{ float: 'right', top: -50, marginLeft: 5 }}
          onClick={() => {
            if (selectedContract != '') {
              dispatch(
                deleteContract({ contractId: selectedContract, token: token })
              )
              dispatch(getAllContracts(token))
            }
          }}
        >
          -
        </Button>
        <Button
          variant="outlined"
          style={{ float: 'right', top: -50, marginLeft: 5 }}
          onClick={() => {
            window.location.replace(`/contracts/${selectedContract}`)
          }}
        >
          edit
        </Button>
        <p>
          {' '}
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
          val={formik.values.faculty}
          disabled={state.contracts.length >= 2}
        />
        <br /> <br />
        <p>Degree : </p>
        <Dropdown
          options={facultyState.degrees}
          field="Degree"
          val={formik.values.degree}
          disabled={state.contracts.length >= 2}
        />
        <br /> <br />
        <p>Specialisation : </p>
        <Dropdown
          options={facultyState.specialisations}
          field="Specialisation"
          val={formik.values.specialisation}
          disabled={state.contracts.length >= 2}
        />
        <br />
        <br />
      </div>
    </MainContainer>
  )
}
