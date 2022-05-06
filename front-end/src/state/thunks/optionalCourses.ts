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

export const setOptionalCoursesPreferences = createAsyncThunk(
  'setOptionalCoursesPreferences',
  async (Data: {
    contractId: string
    optionalCoursesList: OptionalCourse[]
  }) => {
    console.log(Data.contractId, Data.optionalCoursesList)
    const newList = Data.optionalCoursesList.map(course => course.id)

    console.log(Data.contractId, newList)
    try {
      const response = await SECURE_API.post(
        `/student/optionalCourses/setAllPreferences`,
        {
          contractId: Data.contractId,
          contractIds: newList
        }
      )
      console.log('printing data', response.data)
      const responseContent: OptionalCourse[] = response.data
      return responseContent
    } catch (error) {
      alert(error)
    }
  }
)
