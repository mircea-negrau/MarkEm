import { createAsyncThunk } from '@reduxjs/toolkit'
import { SECURE_API } from '../../utility/api'
import { UserDetails } from '../slices/global'
import jwt_decode from 'jwt-decode'
import { OptionalCourse } from '../../utility/types/courseTypes'

export const getOptionalCoursesBySemesterContract = createAsyncThunk(
  'getOptionalCoursesByContract',
  async (contractId: string) => {
    try {
      const response = await SECURE_API.get(
        `/contract/optionalCourses/bySemesterContract?semesterContractId=${contractId}`
      )
      const responseContent: OptionalCourse[] = response.data
      return responseContent
    } catch (error) {
      console.log(error)
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
      const response = await SECURE_API.post(`/student/setAllPreferences`, {
        contractId: Data.contractId,
        coursesIds: newList
      })
      const responseContent: OptionalCourse[] = response.data
      return responseContent
    } catch (error) {
      console.log(error)
    }
  }
)
