import React, { useEffect, useState } from 'react'
import { AppState, store } from '../../state/store'
import localforage from 'localforage'
import { useSelector } from 'react-redux'
import { getUserProfile } from '../../state/thunks/global'
import { Navigate } from 'react-router-dom'

export function RequireAuth({ children }: { children: JSX.Element }) {
  const accessTokenStatus = useSelector(
    (state: AppState) => state.global.accessTokenStatus
  )
  const [isAuthorised, setIsAuthorised] = useState<boolean>(false)

  useEffect(() => {
    const getAuthParams = async () => {
      const accessToken = await localforage.getItem('academic_access_token')
      if (accessToken) {
        setIsAuthorised(true)
      }
    }

    getAuthParams()
  }, [accessTokenStatus])

  useEffect(() => {
    if (isAuthorised) {
      store.dispatch(getUserProfile())
    }
  }, [isAuthorised])

  if (!isAuthorised) {
    return <Navigate to="/login" />
  }

  return children
}
