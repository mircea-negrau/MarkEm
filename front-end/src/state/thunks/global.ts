import { createAsyncThunk } from '@reduxjs/toolkit'
import { STATUS_CODES } from 'http'
import localforage from 'localforage'
import { Navigate } from 'react-router-dom'
import { SECURE_API, API } from '../../utility/api'
import { UserDetails } from '../slices/global'
import jwt_decode from 'jwt-decode'
import { StudyContractType } from '../../utility/types/studentTypes'

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
      alert(error)
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
    console.log({ aici: requestData })

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
      if (responseContent == 200) alert('You succesfully registered')
      return responseContent
    } catch (error) {
      alert(error)
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

export const GetAllContracts = createAsyncThunk('getAllContracts', async () => {
  try {
    const token = (await localforage.getItem('AMS_access_token')) as string
    const decoded = jwt_decode(token) as UserDetails
    console.log(decoded)

    const response = await SECURE_API.get(
      `/student/contracts/all?studentId=${decoded.uid}`
    )
    const responseContent: StudyContractType[] = response.data
    console.log(responseContent)
    return responseContent
  } catch (error) {
    alert(error)
  }
})
