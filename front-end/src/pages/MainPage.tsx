import { FunctionComponent, useEffect, useState } from 'react'

export const MainPage: FunctionComponent = () => {
  const [name, setName] = useState('')

  useEffect(() => {
    ;async () => {
      const response = await fetch('https://localhost:5001/auth/student', {
        headers: { 'Content-Type': 'application/json' },
        credentials: 'include'
      })

      const content = await response.json()
      setName(content.FirstName + ' ' + content.LastName)
    }
  })

  return (
    <div>
      <p>{name ? 'Hello ' + name : 'You are not logged in!'}</p>
    </div>
  )
}
