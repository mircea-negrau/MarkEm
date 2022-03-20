import { FunctionComponent, SyntheticEvent, useState } from 'react'
import { Navigate } from 'react-router-dom'

export const LoginPage: FunctionComponent = () => {
  const [username, setUsername] = useState('')
  const [password, setPassword] = useState('')
  const [redirect, setRedirect] = useState(false)

  const submit = async (e: SyntheticEvent) => {
    e.preventDefault()
    await fetch('https://localhost:5001/auth/login/student', {
      method: 'GET',
      headers: { 'Content-Type': 'application/json' },
      credentials: 'include',
      body: JSON.stringify({
        username,
        password
      })
    })

    setRedirect(true)
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
