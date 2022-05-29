import { createAsyncThunk } from '@reduxjs/toolkit'
import { SECURE_API } from '../../utility/api'
import { UserDetails } from '../slices/global'
import jwt_decode from 'jwt-decode'
import { StudentContractGrades } from '../../utility/types/gradeTypes'

export const getAllGrades = createAsyncThunk(
  'getAllContracts',
  async (token: string) => {
    try {
      const decoded = jwt_decode(token) as UserDetails

      const response = await SECURE_API.get(
        `/student/grades/all?studentId=${decoded.uid}`
      )
      const responseContent: StudentContractGrades[] = response.data
      return responseContent
    } catch (error) {
      alert(error)
    }
  }
)
