import { AppState, store } from '../../state/store'
import { useSelector } from 'react-redux'
import { FunctionComponent, useEffect, useState } from 'react'
import localforage from 'localforage'
import { globalActions, UserDetails } from '../../state/slices/global'
import { Navigate } from 'react-router-dom'
import jwt_decode from 'jwt-decode'
import { getCurrentProfile, logout } from '../../state/thunks/global'
import { DefaultScaffold } from '../../ui-kit/DefaultScaffold'
import { getProfileByUsername } from '../../state/thunks/profile'
import { FetchStatus } from '../../utility/fetchStatus'

export const AuthComponent: FunctionComponent = props => {
  const state = useSelector((state: AppState) => state.global)
  const [isCheckingJwt, setIsCheckingJwt] = useState<boolean>(true)
  const [isValidJwt, setIsValidJwt] = useState<boolean>(false)
  const [isFetchingProfile, setIsFetchingProfile] = useState<boolean>(false)
  const [isDone, setIsDone] = useState<boolean>(false)

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
          setIsValidJwt(false)
        } else {
          store.dispatch(globalActions.setAccessToken(accessToken))
          store.dispatch(globalActions.setUserDetails(decoded))
          setIsValidJwt(true)
        }
      } else {
        setIsValidJwt(false)
        setIsDone(true)
      }

      setIsCheckingJwt(false)
    }

    validateLogin()
  }, [state.accessToken])

  useEffect(() => {
    if (!isCheckingJwt && !isFetchingProfile && !isDone) {
      setIsFetchingProfile(true)
      store.dispatch(getCurrentProfile(state.username))
    }
    if (isFetchingProfile && state.profileStatus == FetchStatus.success) {
      setIsFetchingProfile(false)
      setIsDone(true)
    }
  }, [
    isCheckingJwt,
    isDone,
    isFetchingProfile,
    state.profileStatus,
    state.username
  ])

  return (
    <>
      {isDone && isValidJwt && (
        <DefaultScaffold>{props.children}</DefaultScaffold>
      )}
      {isDone && !isValidJwt && <Navigate to="/login" />}
    </>
  )
}
