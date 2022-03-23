import { AppState, store } from '../../state/store'
import { useSelector } from 'react-redux'
import { FunctionComponent, useEffect, useState } from 'react'
import localforage from 'localforage'
import { globalActions, UserDetails } from '../../state/slices/global'
import { Navigate } from 'react-router-dom'
import jwt_decode from 'jwt-decode'
import { logout } from '../../state/thunks/global'

export const AuthComponent: FunctionComponent = props => {
  const state = useSelector((state: AppState) => state.global)
  const accessTokenStatus = useSelector(
    (state: AppState) => state.global.accessTokenStatus
  )
  const [isAuthorised, setIsAuthorised] = useState<boolean>(false)
  const [isValidating, setIsValidating] = useState<boolean>(true)

  useEffect(() => {
    const validateLogin = async () => {
      const accessToken = (await localforage.getItem(
        'AMS_access_token'
      )) as string

      if (accessToken) {
        const decoded = jwt_decode(accessToken) as UserDetails
        const currentTimestamp = Math.floor(Date.now() / 1000)
        if (decoded.exp - currentTimestamp < 0) {
          store.dispatch(logout())
          setIsAuthorised(false)
        } else {
          store.dispatch(globalActions.setAccessToken(accessToken))
          store.dispatch(globalActions.setUserDetails(decoded))
          setIsAuthorised(true)
        }
      } else {
        setIsAuthorised(false)
      }

      setIsValidating(false)
    }

    validateLogin()
  }, [accessTokenStatus, state.accessToken])

  return (
    <>
      {isValidating && <p>Loading...</p>}
      {!isValidating && isAuthorised && props.children}
      {!isValidating && !isAuthorised && <Navigate to="/login" />}
    </>
  )
}
