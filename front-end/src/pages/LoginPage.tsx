import localforage from 'localforage'
import { FunctionComponent, SyntheticEvent, useEffect, useState } from 'react'
import { Navigate } from 'react-router-dom'
import { API } from '../utility/api'
import jwt_decode from 'jwt-decode'
import { useSelector } from 'react-redux'

export const LoginPage: FunctionComponent = () => {
  const globalState = useSelector((state: AppState) => state.global)
  const [username, setUsername] = useState('')
  const [password, setPassword] = useState('')
  const [redirect, setRedirect] = useState(false)

  const submit = async (e: SyntheticEvent) => {
    e.preventDefault()
    const response = await API.post('/auth', { username, password })
    if (response.status == 200) {
      const token = response.data
      await localforage.setItem<string>('academic_access_token', token)
      setRedirect(true)
    }
  }

  if (redirect) {
    return <Navigate to="/" />
  }

  return (
    <div>
      <form onSubmit={submit}>
        <input
          type="text"
          placeholder="Username"
          required
          autoFocus
          onChange={e => setUsername(e.target.value)}
        />
        <input
          type="password"
          placeholder="Password"
          required
          autoFocus
          onChange={e => setPassword(e.target.value)}
        />
        <button type="submit">Sign in</button>
      </form>
    </div>
  )
}
