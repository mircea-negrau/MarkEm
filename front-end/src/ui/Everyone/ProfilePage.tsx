import { FunctionComponent, useEffect } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import styled from 'styled-components'
import { AppState } from '../../state/store'
import { getProfileByUsername } from '../../state/thunks/profile'
import { FetchStatus } from '../../utility/fetchStatus'
import { useParams } from 'react-router-dom'
import { ProfilePicturePlaceholder } from '../../ui-kit/Avatars/ProfilePicturePlaceholder'

const Container = styled.div`
  padding: 60px;
`

export const ProfilePage: FunctionComponent = () => {
  const { username } = useParams()
  const global = useSelector((state: AppState) => state.global)
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
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [dispatch, state.profileStatus, username])

  return (
    <Container>
      {state.profile && (
        <div>
          <div style={{ display: 'flex' }}>
            {(state.profile.picture && (
              <img
                src={`data:image/png;base64,${state.profile.picture}`}
                style={{
                  width: '200px',
                  height: '200px',
                  objectFit: 'cover',
                  borderRadius: '25px'
                }}
              />
            )) || (
              <ProfilePicturePlaceholder>
                {state.profile.firstName.slice(0, 1)}
                {state.profile.lastName.slice(0, 1)}
              </ProfilePicturePlaceholder>
            )}
            <div style={{ paddingLeft: '20px' }}>
              <p>@{state.profile?.username}</p>
              <p>
                {state.profile?.firstName} {state.profile?.lastName}
              </p>
              <p>{state.profile?.about}</p>
            </div>
          </div>
          <p style={{ paddingTop: '20px' }}>{global.profile?.role}</p>
        </div>
      )}
    </Container>
  )
}
