import { FunctionComponent, useEffect, useState } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import styled from 'styled-components'
import { AppState } from '../state/store'
import { login } from '../state/thunks/global'

const FormField = styled.input`
  border: 1px solid grey;
  border-radius: 50px;
  padding: 0px 15px;
  text-align: center;
  height: 30px;
  margin-bottom: 15px;
  width: 250px;
  outline-width: 0;

  :last-of-type {
    margin-bottom: 20px;
  }
`

const Button = styled.button`
  background-color: #52ab98;
  color: white;
  border-color: transparent;
  border-radius: 50px;
  height: 40px;
  font-weight: 600;

  :hover {
    cursor: pointer;
  }
`

export const LoginPage: FunctionComponent = () => {
  const state = useSelector((state: AppState) => state.global)
  const dispatch = useDispatch()

  const [username, setUsername] = useState('')
  const [password, setPassword] = useState('')

  useEffect(() => {
    if (state.accessToken != '') {
      window.location.replace('/')
    }
  }, [state.accessToken])

  return (
    <div
      style={{
        display: 'flex',
        flexDirection: 'column',
        margin: 0,
        left: '50%',
        top: '50%',
        position: 'absolute',
        transform: 'translateY(-50%) translateX(-50%)',
        justifyContent: 'center',
        alignItems: 'center'
      }}
    >
      <form
        style={{
          display: 'flex',
          flexDirection: 'column',
          padding: '100px 50px',
          backgroundColor: '#2b6777',
          borderRadius: '50px'
        }}
        onSubmit={e => {
          e.preventDefault()
          dispatch(login({ username, password }))
        }}
      >
        <p
          style={{
            color: '#f2f2f2',
            textAlign: 'center',
            paddingBottom: '40px',
            fontSize: '24px'
          }}
        >
          Sign in
        </p>
        <FormField
          type="text"
          placeholder="Username"
          required
          autoFocus
          onChange={e => setUsername(e.target.value)}
        />
        <FormField
          type="password"
          placeholder="Password"
          required
          autoFocus
          onChange={e => setPassword(e.target.value)}
        />
        <hr style={{ width: '100%', marginBottom: '25px' }} />
        <Button type="submit">Sign in</Button>
      </form>
    </div>
  )
}
