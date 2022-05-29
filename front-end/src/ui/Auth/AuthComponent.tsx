import { AppState, store } from '../../state/store'
import { useSelector } from 'react-redux'
import React, { FunctionComponent, useEffect, useState } from 'react'
import localforage from 'localforage'
import { globalActions, UserDetails } from '../../state/slices/global'
import jwt_decode from 'jwt-decode'
import { getCurrentProfile, logout } from '../../state/thunks/global'
import { DefaultScaffold } from '../../ui-kit/DefaultScaffold'
import { FetchStatus } from '../../utility/fetchStatus'
import { UserType } from '../../utility/types/userTypes'
import { getUserType } from '../../utility/getUserType'

export const AuthComponent: FunctionComponent<{
  roles?: UserType[]
}> = props => {
  const state = useSelector((state: AppState) => state.global)
  const [isValidJwt, setIsValidJwt] = useState<boolean>(false)
  const [isProfileReady, setIsProfileReady] = useState<boolean>(false)

  useEffect(() => {
    const validateLogin = async () => {
      const accessToken = (await localforage.getItem(
        'AMS_access_token'
      )) as string

      if (!accessToken) {
        window.location.replace('/login')
      }

      const decoded = jwt_decode(accessToken) as UserDetails
      const currentTimestamp = Math.floor(Date.now() / 1000)
      if (decoded.exp - currentTimestamp < 0) {
        await Promise.all([store.dispatch(logout())]).then(() =>
          window.location.replace('/login')
        )
      }

      if (props.roles && !props.roles.includes(getUserType(decoded.role))) {
        window.location.replace('/error')
      }

      store.dispatch(globalActions.setAccessToken(accessToken))
      store.dispatch(globalActions.setUserDetails(decoded))
      setIsValidJwt(true)
    }

    validateLogin()
  }, [props.roles, state.accessToken])

  useEffect(() => {
    if (isValidJwt) {
      store.dispatch(getCurrentProfile(state.username))
    }
  }, [isValidJwt, state.username])

  useEffect(() => {
    if (state.profileStatus === FetchStatus.success) setIsProfileReady(true)
    else if (state.profileStatus === FetchStatus.error)
      window.location.replace('/error')
  }, [state.profileStatus])

  return (
    <>
      {isValidJwt && isProfileReady && (
        <DefaultScaffold>{props.children}</DefaultScaffold>
      )}
    </>
  )
}

export const AuthTeacher: FunctionComponent = props => {
  return (
    <AuthComponent roles={[UserType.Teacher]}>{props.children}</AuthComponent>
  )
}
