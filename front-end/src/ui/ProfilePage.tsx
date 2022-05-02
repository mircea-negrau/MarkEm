import { FunctionComponent, useEffect, useState } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { useParams } from 'react-router-dom'
import styled from 'styled-components'
import { AppState } from '../state/store'
import { getProfileByUsername } from '../state/thunks/profile'
import { FetchStatus } from '../utility/fetchStatus'
import { SECURE_API } from '../utility/api'

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
  }, [dispatch, state.profileStatus, username])

  const [file, setFile] = useState()
  const [fileName, setFileName] = useState('')

  const saveFile = e => {
    console.log(e.target.files[0])
    setFile(e.target.files[0])
    setFileName(e.target.files[0].name)
  }

  const uploadFile = async () => {
    if (file) {
      const formData = new FormData()
      formData.append('file', file)
      formData.append('fileName', fileName)
      try {
        const res = await SECURE_API.post('profile/picture/upload', formData)
        console.log(res)
      } catch (ex) {
        console.log(ex)
      }
    }
  }

  return (
    <Container>
      {state.profile && (
        <div>
          <div style={{ display: 'flex' }}>
            {state.profile.picture ? (
              <img
                src={
                  state.profile.picture
                    ? `data:image/png;base64,${state.profile.picture}`
                    : ''
                }
                style={{
                  width: '200px',
                  height: '200px',
                  objectFit: 'cover',
                  borderRadius: '25px'
                }}
              />
            ) : (
              <ProfilePicturePlaceholder />
            )}
            <div style={{ paddingLeft: '20px' }}>
              <p>@{state.profile?.username}</p>
              <p>
                {state.profile?.firstName} {state.profile?.lastName}
              </p>
              <p>{state.profile?.about}</p>
            </div>
          </div>
          {state.profile.id == global.userId && state.profile.id != '' && (
            <div style={{ display: 'flex', flexDirection: 'column' }}>
              <input type="file" onChange={saveFile} />
              <button style={{ width: '88px' }} onClick={uploadFile}>
                Upload
              </button>
            </div>
          )}
          <p style={{ paddingTop: '20px' }}>{global.profile?.role}</p>
        </div>
      )}
    </Container>
  )
}
