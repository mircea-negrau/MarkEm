import { FunctionComponent, useEffect, useState } from 'react'
import { SECURE_API } from '../utility/api'

interface Student {
  id: string
  username: string
  firstName: string
  lastName: string
}

export const MainPage: FunctionComponent = () => {
  const [name, setName] = useState('')
  const [isReady, setIsReady] = useState(false)

  useEffect(() => {
    ;(async () => {
      await SECURE_API.get('/auth/user')
        .then(response => {
          const content: Student = response.data
          setName(content.firstName + ' ' + content.lastName)
        })
        .catch()
      setIsReady(true)
    })()
  })

  return (
    <div>
      {isReady && <p>{name ? 'Hello ' + name : 'You are not logged in!'}</p>}
    </div>
  )
}
