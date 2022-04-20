import { createAsyncThunk } from '@reduxjs/toolkit'
import { SECURE_API, API } from '../../utility/api'
import { UserDetails } from '../slices/global'
import jwt_decode from 'jwt-decode'
import { StudyContractType } from '../../utility/types/studentTypes'

export const getAllContracts = createAsyncThunk(
  'getAllContracts',
  async (token: string) => {
    try {
      const decoded = jwt_decode(token) as UserDetails

      const response = await SECURE_API.get(
        `/student/contracts/all?studentId=${decoded.uid}`
      )
      const responseContent: StudyContractType[] = response.data
      return responseContent
    } catch (error) {
      alert(error)
    }
  }
)
