import { createAsyncThunk } from '@reduxjs/toolkit'
import localforage from 'localforage'
import { API, SECURE_API } from '../../utility/api'

export interface UserProfileReturnType {
  id: string
  username: string
  firstName: string
  lastName: string
}

export const getAccessToken = createAsyncThunk('getAccessToken', async () => {
  try {
    const response = await API.post(`/auth`, {}, {})
    const responseContent: string = response.data.content
    await localforage.setItem('access_token', responseContent)
    return responseContent
  } catch (error) {
    console.log(error)
    window.location.replace('/error')
  }
})

export const getUserProfile = createAsyncThunk('getUserProfile', async () => {
  try {
    const response = await SECURE_API.get(`/auth/user`)
    const responseContent: UserProfileReturnType = response.data.content
    return responseContent
  } catch (error) {
    console.log(error)
    return undefined
  }
})
