import { FunctionComponent, useEffect, useState } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import styled from 'styled-components'
import { AppState } from '../state/store'
import { login } from '../state/thunks/global'
import Image from '../assets/login-icon.png'
import { useFormik } from 'formik'
import * as Yup from 'yup'
import Visibility from '@mui/icons-material/Visibility'
import VisibilityOffIcon from '@mui/icons-material/VisibilityOff'
import PersonIcon from '@mui/icons-material/Person'
import { Button, Checkbox, CircularProgress, TextField } from '@mui/material'
import { FetchStatus } from '../utility/fetchStatus'
import { useNavigate } from 'react-router-dom'

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

const LoginButton = styled(Button)<{ available: boolean }>`
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

export const LoginPage: FunctionComponent = () => {
  const state = useSelector((state: AppState) => state.global)
  const [isPasswordVisible, setIsPasswordVisible] = useState(false)

  const dispatch = useDispatch()
  const navigate = useNavigate()

  const validationSchema = Yup.object({
    email: Yup.string().email('Enter a valid email'),
    password: Yup.string()
      .min(8, 'Password should be of minimum 8 characters length')
      .required('Password is required')
  })

  const formik = useFormik({
    initialValues: {
      email: '',
      password: ''
    },
    validationSchema: validationSchema,
    onSubmit: values => {
      dispatch(login(values))
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
            <p
              style={{
                color: '#96a2b4',
                fontFamily: 'Roboto, sans-serif',
                fontSize: '28px',
                fontWeight: '500',
                marginBottom: '7px'
              }}
            >
              {"Welcome to Mark'Em"}
            </p>
            <div
              style={{
                display: 'flex',
                width: '100%'
              }}
            >
              <p
                style={{
                  color: '#96a2b4',
                  fontFamily: 'Roboto, sans-serif',
                  fontSize: '18px',
                  paddingBottom: '30px'
                }}
              >
                Need an account?
              </p>
              <a
                href="register"
                style={{
                  color: '#3699ff',
                  fontFamily: 'Roboto, sans-serif',
                  fontSize: '18px',
                  paddingBottom: '30px'
                }}
              >
                &nbsp;Sign Up
              </a>
            </div>
            <p
              style={{
                color: '#96a2b4',
                fontFamily: 'Roboto, sans-serif',
                fontSize: '28px',
                fontWeight: '500',
                marginBottom: '20px'
              }}
            >
              Sign in
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
              InputProps={{
                endAdornment: <PersonIcon style={{ color: '#96a2b4' }} />
              }}
              style={{ paddingBottom: '30px' }}
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
            />
            <div
              style={{
                display: 'flex',
                justifyContent: 'space-between',
                paddingTop: '15px',
                paddingBottom: '50px',
                alignItems: 'center'
              }}
            >
              <div style={{ display: 'flex', alignItems: 'center' }}>
                <Checkbox style={{ alignSelf: 'start' }} />
                <p>Remember me</p>
              </div>
              <p>Forgot password?</p>
            </div>
            <LoginButton
              available={
                formik.values.email != '' && formik.values.password != ''
              }
              type="submit"
            >
              {state.accessTokenStatus != FetchStatus.loading && 'Login'}
              {state.accessTokenStatus === FetchStatus.loading && (
                <CircularProgress size={18} style={{ color: 'yellow' }} />
              )}
            </LoginButton>
          </form>
        </div>
      </div>
    </div>
  )
}
