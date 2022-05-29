import React, { FunctionComponent, useEffect, useState } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import styled from 'styled-components'
import { AppState } from '../../state/store'
import { changeAbout, changePassword } from '../../state/thunks/global'
import { getProfileByUsername } from '../../state/thunks/profile'
import { ProfilePicturePlaceholder } from '../../ui-kit/Avatars/ProfilePicturePlaceholder'
import { SECURE_API } from '../../utility/api'
import { FetchStatus } from '../../utility/fetchStatus'

const MainContainer = styled.div`
  display: flex;
  flex-direction: column;
  padding: 40px 25px;
  width: 25%;
  height: 100%;
`

export const Settings: FunctionComponent = () => {
  const username = useSelector((state: AppState) => state.global.username)
  const state = useSelector((state: AppState) => state.profile)

  const dispatch = useDispatch()

  const [about, setAbout] = useState('')
  const [password, setPassword] = useState('')
  const [confirmPassword, setConfirmPassword] = useState('')
  const [passwordError, setPasswordError] = useState('')

  const [image, setImage] = useState('')
  const [file, setFile] = useState('')
  const [fileName, setFileName] = useState('')

  const saveFile = e => {
    const [file] = e.target.files
    setImage(URL.createObjectURL(file))
    setFile(e.target.files[0])
    setFileName(e.target.files[0].name)
  }

  const uploadFile = async () => {
    if (file) {
      const formData = new FormData()
      formData.append('file', file)
      formData.append('fileName', fileName)
      try {
        await SECURE_API.post('profile/picture/upload', formData)
      } catch (ex) {
        console.log(ex)
      }
    }
  }

  useEffect(() => {
    if (state.profileStatus !== FetchStatus.success) {
      dispatch(getProfileByUsername(username))
    }
  }, [dispatch, state.profileStatus, username])

  useEffect(() => {
    if (!about && state.profile.about) {
      setAbout(state.profile.about)
    }
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [state.profile.about])

  const handleAboutChange = (
    e: React.ChangeEvent<HTMLTextAreaElement | HTMLInputElement>
  ) => {
    setAbout(e.target.value)
  }

  const handlePasswordChange = (
    e: React.ChangeEvent<HTMLTextAreaElement | HTMLInputElement>
  ) => {
    setPassword(e.target.value)
  }

  const handleConfirmPasswordChange = (
    e: React.ChangeEvent<HTMLTextAreaElement | HTMLInputElement>
  ) => {
    setConfirmPassword(e.target.value)
  }

  const handleUpdatePassword = async () => {
    if (password.length < 8) {
      setPasswordError('Password too short!')
      return
    }
    if (password != confirmPassword) {
      setPasswordError('Passwords do not match!')
      return
    }
    await Promise.resolve(dispatch(changePassword(password)))
      .then(() => alert('Updated password successfully!'))
      .catch(() => alert('Failed to update password!'))
  }

  const handleUpdateAbout = async () => {
    await Promise.resolve(dispatch(changeAbout(about)))
      .then(() => alert('Updated about successfully!'))
      .catch(() => alert('Failed to update about!'))
  }

  return (
    <MainContainer>
      {(state.profile && (
        <>
          <div style={{ display: 'flex', alignItems: 'end' }}>
            {(file && (
              <img
                src={`${image}`}
                style={{
                  width: '200px',
                  height: '200px',
                  objectFit: 'cover',
                  borderRadius: '25px'
                }}
              />
            )) ||
              (state.profile.picture && (
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
            <div
              style={{
                display: 'flex',
                flexDirection: 'column',
                paddingBottom: '30px',
                paddingLeft: '30px'
              }}
            >
              <input type="file" onChange={saveFile} />
              <button
                disabled={file == ''}
                style={{ width: '88px' }}
                onClick={uploadFile}
              >
                Upload
              </button>
              <button
                style={{ width: '88px' }}
                disabled={image == ''}
                onClick={() => {
                  setFile(''), setFileName(''), setImage('')
                }}
              >
                Clear
              </button>
            </div>
          </div>
          <p style={{ paddingTop: '20px' }}>About</p>
          <textarea
            placeholder="About"
            rows={5}
            maxLength={250}
            value={about}
            onChange={handleAboutChange}
          />
          <div
            style={{
              display: 'flex',
              width: '100%',
              justifyContent: 'space-between'
            }}
          >
            <button onClick={handleUpdateAbout} style={{ width: '150px' }}>
              Update
            </button>
            <p>{about.length}/250</p>
          </div>
          <div style={{ display: 'flex', paddingTop: '25px' }}>
            <p>Change password</p>
            <p style={{ paddingLeft: '20px', color: 'red' }}>{passwordError}</p>
          </div>
          <div style={{ display: 'flex', justifyContent: 'space-evenly' }}>
            <input
              placeholder="Password"
              style={{ width: '100%' }}
              type="password"
              onChange={handlePasswordChange}
            />
            <input
              placeholder="Confirm password"
              style={{ width: '100%' }}
              type="password"
              onChange={handleConfirmPasswordChange}
            />
          </div>
          <button
            onClick={() => {
              handleUpdatePassword()
            }}
          >
            Apply
          </button>
        </>
      )) || <p>Loading...</p>}
    </MainContainer>
  )
}
