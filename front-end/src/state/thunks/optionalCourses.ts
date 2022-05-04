import { createAsyncThunk } from '@reduxjs/toolkit'
import { SECURE_API } from '../../utility/api'
import { UserDetails } from '../slices/global'
import jwt_decode from 'jwt-decode'
import { OptionalCourse } from '../../utility/types/courseTypes'

export const getOptionalCoursesByContract = createAsyncThunk(
  'getOptionalCoursesByContract',
  async (contractId: string) => {
    try {
      const response = await SECURE_API.get(
        `/student/optionalCourses/contract?contractId=${contractId}`
      )
      console.log('printing data', response.data)
      const responseContent: OptionalCourse[] = response.data
      return responseContent
    } catch (error) {
      alert(error)
    }
  }
)
