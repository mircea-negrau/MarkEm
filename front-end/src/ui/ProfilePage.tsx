import { FunctionComponent, useEffect } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { useParams } from 'react-router-dom'
import styled from 'styled-components'
import { AppState } from '../state/store'
import { getProfileByUsername } from '../state/thunks/profile'
import { FetchStatus } from '../utility/fetchStatus'

const Container = styled.div`
  padding: 60px;
`

const ProfilePicturePlaceholder = styled.div`
  width: 200px;
  height: 200px;
  background-color: grey;
  border-radius: 25px;
`

export const ProfilePage: FunctionComponent = () => {
  const { username } = useParams()
  const state = useSelector((state: AppState) => state.profile)
  const dispatch = useDispatch()

  useEffect(() => {
    if (username == undefined) {
      window.location.replace('/error')
    } else {
      if (state.profileStatus != FetchStatus.success) {
        dispatch(getProfileByUsername(username))
      }
    }
  }, [dispatch, state.profileStatus, username])

  return (
    <Container>
      {state.profile && (
        <div>
          <div style={{ display: 'flex' }}>
            {state.profile?.picture ? <p>Hi</p> : <ProfilePicturePlaceholder />}
            <div style={{ paddingLeft: '20px' }}>
              <p>@{state.profile?.username}</p>
              <p>
                {state.profile?.firstName} {state.profile?.lastName}
              </p>
              <p>{state.profile?.about}</p>
            </div>
          </div>
          <p style={{ paddingTop: '20px' }}>{state.profile?.role}</p>
        </div>
      )}
    </Container>
  )
}
