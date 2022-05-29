import { FunctionComponent, useEffect, useState } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import styled from 'styled-components'
import { AppState } from '../../state/store'
import { register } from '../../state/thunks/global'
import Image from '../../assets/login-icon.png'
import { useFormik } from 'formik'
import * as Yup from 'yup'
import Visibility from '@mui/icons-material/Visibility'
import VisibilityOffIcon from '@mui/icons-material/VisibilityOff'
import PersonIcon from '@mui/icons-material/Person'
import { Button, CircularProgress, TextField } from '@mui/material'
import { FetchStatus } from '../../utility/fetchStatus'
import React from 'react'
import EmailIcon from '@mui/icons-material/Email'
import { useNavigate } from 'react-router-dom'

const roleOptions = ['Student', 'Teacher', 'Admin']

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

const RegisterButton = styled(Button)<{ available: boolean }>`
  background-color: ${props =>
    props.available ? '#3f51b5' : '#0f1218'} !important;
  color: ${props =>
    props.available ? 'white' : 'rgba(255, 255, 255, 0.23)'} !important;
  border-color: transparent;
  border-radius: 5px;
  height: 50px;
  padding: 0px 16px;
  font-weight: 600;
`

export const RegisterPage: FunctionComponent = () => {
  const state = useSelector((state: AppState) => state.global)
  const [isPasswordVisible, setIsPasswordVisible] = useState(false)
  const [userRole, setUserRole] = useState(roleOptions[0])

  const dispatch = useDispatch()
  const navigate = useNavigate()

  const Dropdown = ({ options }) => {
    return (
      <select
        value={userRole}
        onChange={e => [
          setUserRole(e.target.value),
          (formik.values.userType = e.target.value)
        ]}
        style={{
          background: '#0f1218',
          color: '#96a2b4',
          height: '40px',
          fontSize: '20px',
          width: '50%',
          paddingLeft: '7px',
          marginTop: '7px',
          borderRadius: '5px'
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

  const validationSchema = Yup.object({
    username: Yup.string().required('Username is required'),
    password: Yup.string()
      .min(8, 'Password should be of minimum 8 characters length')
      .required('Password is required'),
    firstName: Yup.string().required('First Name is required'),
    lastName: Yup.string().required('Last Name is required'),
    userType: Yup.string().required('Role is required'),
    email: Yup.string().email().required('Email is required')
  })

  const formik = useFormik({
    initialValues: {
      userType: userRole,
      username: '',
      password: '',
      email: '',
      firstName: '',
      lastName: ''
    },
    validationSchema: validationSchema,
    onSubmit: values => {
      dispatch(register(values))
    }
  })

  useEffect(() => {
    if (state.accessToken != '') {
      window.location.replace('/')
    }
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [state.accessToken])

  let icon = <></>
  if (isPasswordVisible)
    icon = (
      <Visibility
        style={{ color: '#96a2b4', cursor: 'pointer' }}
        onClick={() => {
          setIsPasswordVisible(false)
        }}
      />
    )
  else
    icon = (
      <VisibilityOffIcon
        style={{ color: '#96a2b4', cursor: 'pointer' }}
        onClick={() => {
          setIsPasswordVisible(true)
        }}
      />
    )
  return (
    <div style={{ display: 'flex', width: '100%', height: '100vh' }}>
      <div
        style={{
          width: '50%',
          height: '100%',
          backgroundImage: `url(${Image})`,
          backgroundRepeat: 'no-repeat',
          backgroundPosition: 'center center',
          backgroundSize: 'cover'
        }}
      />
      <div
        style={{
          width: '50%',
          height: '100%',
          backgroundColor: '#11141b',
          display: 'flex',
          flexDirection: 'column',
          alignItems: 'center',
          justifyContent: 'center'
        }}
      >
        <div
          style={{
            width: '410px',
            maxWidth: '100%',
            marginTop: 'auto',
            marginBottom: 'auto'
          }}
        >
          <form
            style={{
              display: 'flex',
              flexDirection: 'column'
            }}
            onSubmit={formik.handleSubmit}
          >
            <div
              style={{
                display: 'flex',
                width: '100%'
              }}
            />
            <p
              style={{
                color: '#96a2b4',
                fontFamily: 'Roboto, sans-serif',
                fontSize: '28px',
                fontWeight: '500',
                marginBottom: '20px'
              }}
            >
              Create an account
            </p>
            <GreyTextField
              fullWidth
              id="email"
              name="email"
              label="Email"
              value={formik.values.email}
              onChange={formik.handleChange}
              error={formik.touched.email && Boolean(formik.errors.email)}
              helperText={formik.touched.email && formik.errors.email}
              variant="filled"
              style={{ paddingBottom: '30px' }}
              InputProps={{
                endAdornment: <EmailIcon style={{ color: '#96a2b4' }} />
              }}
            />
            <GreyTextField
              fullWidth
              id="password"
              name="password"
              label="Password"
              type={isPasswordVisible ? 'text' : 'password'}
              value={formik.values.password}
              onChange={formik.handleChange}
              error={formik.touched.password && Boolean(formik.errors.password)}
              helperText={formik.touched.password && formik.errors.password}
              variant="filled"
              InputProps={{
                endAdornment: icon
              }}
              style={{ paddingBottom: '30px' }}
            />

            <div
              style={{
                display: 'flex',
                width: '100%'
              }}
            >
              <GreyTextField
                fullWidth
                id="username"
                name="username"
                label="Username"
                value={formik.values.username}
                onChange={formik.handleChange}
                error={
                  formik.touched.username && Boolean(formik.errors.username)
                }
                helperText={formik.touched.username && formik.errors.username}
                variant="filled"
                InputProps={{
                  endAdornment: <PersonIcon style={{ color: '#96a2b4' }} />
                }}
                style={{ paddingBottom: '30px', width: '50%' }}
              />
              <Dropdown options={roleOptions} />
            </div>
            <div
              style={{
                display: 'flex',
                width: '100%'
              }}
            >
              <GreyTextField
                fullWidth
                id="firstName"
                name="firstName"
                label="First name"
                value={formik.values.firstName}
                onChange={formik.handleChange}
                error={formik.touched.email && Boolean(formik.errors.email)}
                helperText={formik.touched.email && formik.errors.email}
                variant="filled"
                style={{
                  paddingBottom: '30px',
                  width: '50%',
                  paddingRight: '20px'
                }}
              />
              <GreyTextField
                fullWidth
                id="lastName"
                name="lastName"
                label="Last Name"
                value={formik.values.lastName}
                onChange={formik.handleChange}
                error={formik.touched.email && Boolean(formik.errors.email)}
                helperText={formik.touched.email && formik.errors.email}
                variant="filled"
                style={{ paddingBottom: '30px', width: '50%' }}
              />
            </div>

            <div
              style={{
                display: 'flex',
                justifyContent: 'space-between',
                paddingTop: '15px',
                paddingBottom: '50px',
                alignItems: 'center'
              }}
            >
              <p>
                Already have an account ?
                <a
                  href="login"
                  style={{
                    color: '#3699ff',
                    fontFamily: 'Roboto, sans-serif',
                    fontSize: '18px',
                    paddingBottom: '30px'
                  }}
                >
                  &nbsp;Sign In
                </a>
              </p>
            </div>
            <RegisterButton
              available={
                formik.values.username != '' &&
                formik.values.password != '' &&
                formik.values.email != '' &&
                formik.values.firstName != '' &&
                formik.values.lastName != ''
              }
              type="submit"
            >
              {state.accessTokenStatus != FetchStatus.loading && 'Register'}
              {state.accessTokenStatus === FetchStatus.loading && (
                <CircularProgress size={18} style={{ color: 'yellow' }} />
              )}
            </RegisterButton>
          </form>
        </div>
      </div>
    </div>
  )
}
