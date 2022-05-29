import { createAsyncThunk } from '@reduxjs/toolkit'
import localforage from 'localforage'
import { API, SECURE_API } from '../../utility/api'
import { Profile } from '../../utility/types/profileTypes'

export interface UserProfileReturnType {
  id: string
  username: string
  firstName: string
  lastName: string
}

export const login = createAsyncThunk(
  'login',
  async (requestData: { email: string; password: string }) => {
    try {
      const response = await API.post(`/auth/login`, {
        email: requestData.email,
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

export const register = createAsyncThunk(
  'register',
  async (requestData: {
    userType: string
    username: string
    password: string
    email: string
    firstName: string
    lastName: string
  }) => {
    try {
      const response = await API.post(`/auth/register`, {
        userType: requestData.userType,
        username: requestData.username,
        password: requestData.password,
        email: requestData.email,
        firstName: requestData.firstName,
        lastName: requestData.lastName
      })
      const responseContent = response.status
      console.log(responseContent)
      if (responseContent == 200) console.log('You succesfully registered')
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

export const getCurrentProfile = createAsyncThunk(
  'getCurrentProfile',
  async (username: string) => {
    try {
      const response = await SECURE_API.get(`/profile/${username}`)
      const profile: Profile = response.data
      return profile
    } catch (error) {
      console.log(error)
    }
  }
)

export const changePassword = createAsyncThunk(
  'changePassword',
  async (password: string) => {
    try {
      await SECURE_API.post(`/profile/passwordChange`, { password: password })
      return true
    } catch (error) {
      console.log(error)
      return false
    }
  }
)

export const changeAbout = createAsyncThunk(
  'changeAbout',
  async (about: string) => {
    try {
      await SECURE_API.post(`/profile/setAbout`, { about: about })
      return true
    } catch (error) {
      console.log(error)
      return false
    }
  }
)
