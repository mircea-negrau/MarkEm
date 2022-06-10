import { Button, TextField } from '@mui/material'
import { FunctionComponent, useEffect, useState } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import styled from 'styled-components'
import { AppState } from '../../state/store'
import {
  approveOptional,
  getOptionalsChiefView,
  setOptionalCapacity
} from '../../state/thunks/chiefOfDepartment'
import { useFormik } from 'formik'

const OptionalContainer = styled.div<{ isActive?: boolean }>`
  border: 1px solid green;
  border-color: #3a3f47;
  padding: 40px;
  cursor: pointer;
  background: #1b1c1e;
  width: 30%;
  height: auto;
  ${props => (props.isActive ? 'background-color: white;' : '')}
`

const StyledButton = styled(Button)`
  width: 175px;
  height: 50px;
  background: #cfd8e3 !important;
  border: black !important;
`

const MainContainer = styled.div`
  display: flex;
  padding: 40px 25px;
  width: 100vw;
  height: 100vh;
`

const GreyTextField = styled(TextField)`
  & label.Mui-focused {
    color: #96a2b4;
  }
  & label.Mui {
    color: #96a2b4;
  }
  & .MuiOutlinedInput-root {
    &.Mui-focused fieldset {
      border-color: #96a2b4;
    }
  }

  .MuiOutlinedInput-notchedOutline {
    border-color: #96a2b4;
  }
  .MuiFormLabel-root {
    color: #96a2b4;
  }
  .MuiInputBase-input {
    color: #96a2b4;
  }
`

export const ChiefOfDepartmentOptionalsPage: FunctionComponent = () => {
  const dispatch = useDispatch()
  const state = useSelector((state: AppState) => state.chiefOfDepartment)
  const [selectedOptional, setSelectedOptional] = useState('')

  useEffect(() => {
    dispatch(getOptionalsChiefView())
  }, [dispatch])

  const formik = useFormik({
    initialValues: {
      capacity: 0
    },
    validationSchema: null,
    onSubmit: values => {
      dispatch(getOptionalsChiefView())
    }
  })

  return (
    <MainContainer>
      <div style={{ width: '75%', float: 'left' }}>
        {state.optionalViews.optionals.map(optional => (
          <div key={optional.id}>
            <OptionalContainer
              isActive={selectedOptional == optional.id}
              onClick={() => {
                console.log('clicked')
                setSelectedOptional(optional.id)
              }}
            >
              <p>
                Name : {optional.name} <br />
              </p>
              <p>
                Capacity : {optional.capacity} <br />
              </p>
              <p>
                Credits : {optional.credits} <br />
              </p>
              <p>
                Semester : {optional.semester} <br />
              </p>
              <p>
                Specialization : {optional.specialization} <br />
              </p>
              <p>
                Study degree : {optional.studyDegree} <br />
              </p>
              <p>
                Teacher name :{' '}
                {optional.teacherFirstName + ' ' + optional.teacherLastName}{' '}
                <br />
              </p>
              <p>
                Study line : {optional.studyLine} <br />
              </p>
              <p>
                Is approved : {optional.isApproved && 'yes'}{' '}
                {!optional.isApproved && 'no'} <br />
              </p>
            </OptionalContainer>
            <br /> <br />
          </div>
        ))}
      </div>
      <div style={{ display: 'flex', flexDirection: 'row', width: '25%' }}>
        <StyledButton
          onClick={async () => {
            await Promise.resolve(
              dispatch(approveOptional(selectedOptional))
            ).then(() => window.location.reload())
          }}
        >
          Approve
        </StyledButton>
        <br /> <br />
        <StyledButton
          onClick={async () => {
            await Promise.resolve(
              dispatch(
                setOptionalCapacity({
                  optionalId: selectedOptional,
                  capacity: formik.values.capacity
                })
              )
            ).then(() => window.location.reload())
          }}
        >
          Set capacity
        </StyledButton>
        <br /> <br />
        <GreyTextField
          fullWidth
          id="capacity"
          name="capacity"
          label="capacity"
          value={formik.values.capacity}
          onChange={formik.handleChange}
          type="number"
          variant="filled"
          style={{ paddingBottom: '30px' }}
        />
      </div>
    </MainContainer>
  )
}
