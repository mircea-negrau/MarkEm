import { FunctionComponent, useEffect, useState } from 'react'
import styled from 'styled-components'
import { deleteContract, getAllContracts } from '../state/thunks/contracts'
import { useDispatch, useSelector } from 'react-redux'
import { AppState } from '../state/store'
import { contractActions } from '../state/slices/contracts'
import { StudyContractType } from '../utility/types/studentTypes'
import { Button } from '@mui/material'
import { FetchStatus } from '../utility/fetchStatus'
import { Field, Form, Formik, useFormik } from 'formik'
import { register } from '../state/thunks/global'

const MainContainer = styled.div`
  display: inline-block;
  flex-direction: column;
  padding: 40px 25px;
  width: 100%;
  height: 100%;
`
const roleOptions = ['Student', 'Teacher', 'Admin']
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
  const contracts = useSelector((state: AppState) => state.contract.contracts)

  const [selectedContract, setSelectedContract] = useState('')
  const dispatch = useDispatch()
  const [updateContracts, setUpdateContracts] = useState(true)
  const [specialisation, setSpecialization] = useState(roleOptions[0])
  const [faculty, setFaculty] = useState(roleOptions[0])
  const [year, setYear] = useState(roleOptions[0])

  const Dropdown = ({ options, field, val }) => {
    return (
      <select
        value={val}
        onChange={e => {
          if (field == 'Faculty') {
            setFaculty(e.target.value), (formik.values.faculty = e.target.value)
          } else if (field == 'Year') {
            setYear(e.target.value), (formik.values.year = e.target.value)
          } else if (field == 'Specialisation') {
            setSpecialization(e.target.value),
              (formik.values.specialisation = e.target.value)
          }
          console.log(
            e.target.value,
            formik.values.faculty,
            formik.values.specialisation,
            formik.values.year
          )
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
          <option key={o} value={o}>
            {o}
          </option>
        ))}
      </select>
    )
  }

  const formik = useFormik({
    initialValues: {
      faculty: faculty,
      specialisation: specialisation,
      year: year
    },
    onSubmit: values => {
      //dispatch(register)
      console.log(values)
    }
  })

  useEffect(() => {
    console.log('using effect')

    if (updateContracts == true) {
      dispatch(getAllContracts(token))
      setUpdateContracts(false)
    }
  }, [dispatch, token, updateContracts, contracts])

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
        {contracts.map(contract => (
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
                onClick={e => {
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
        <Button
          variant="outlined"
          style={{ float: 'right', top: -50, marginLeft: 5 }}
        >
          +
        </Button>
        <Button
          variant="outlined"
          style={{ float: 'right', top: -50, marginLeft: 5 }}
          onClick={() => {
            if (selectedContract != '') {
              dispatch(
                deleteContract({ contractId: selectedContract, token: token })
              )
              dispatch(getAllContracts(token))
              setUpdateContracts(true)
            }
          }}
        >
          -
        </Button>
        <Button
          variant="outlined"
          style={{ float: 'right', top: -50, marginLeft: 5 }}
        >
          edit
        </Button>
        <p>
          {' '}
          <b>
            {contracts.length >= 2 && 'You cannot add more than two contracts'}
            {contracts.length < 2 && 'You can add another contract'}
          </b>
        </p>
        <br /> <br />
        <p>Faculty : </p>
        <Dropdown
          options={roleOptions}
          field="Faculty"
          val={formik.values.faculty}
        />
        <br /> <br />
        <p>Specialisation : </p>
        <Dropdown
          options={roleOptions}
          field="Specialisation"
          val={formik.values.specialisation}
        />
        <br />
        <br />
        <p>Year : </p>
        <Dropdown options={roleOptions} field="Year" val={formik.values.year} />
        <br />
        <br />
      </div>
    </MainContainer>
  )
}
