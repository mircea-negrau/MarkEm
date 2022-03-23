import { createAsyncThunk } from '@reduxjs/toolkit'
import localforage from 'localforage'
import { API } from '../../utility/api'

export interface UserProfileReturnType {
  id: string
  username: string
  firstName: string
  lastName: string
}

export const login = createAsyncThunk(
  'login',
  async (requestData: { username: string; password: string }) => {
    try {
      const response = await API.post(`/auth/login`, {
        username: requestData.username,
        password: requestData.password
      })
      const responseContent: string = response.data
      await localforage.setItem('AMS_access_token', responseContent)
      return responseContent
    } catch (error) {
      console.log(error)
    }
  }
)

export const logout = createAsyncThunk('logout', async () => {
  try {
    await localforage.removeItem('AMS_access_token')
  } catch (error) {
    console.log(error)
  }
})
