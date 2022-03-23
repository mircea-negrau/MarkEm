import { FunctionComponent, useEffect, useState } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { AppState } from '../state/store'
import { login } from '../state/thunks/global'

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
    <div>
      <form
        onSubmit={e => {
          e.preventDefault()
          dispatch(login({ username, password }))
        }}
      >
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
