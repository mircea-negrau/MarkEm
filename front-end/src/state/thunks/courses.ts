import { createAsyncThunk } from '@reduxjs/toolkit'
import { SECURE_API } from '../../utility/api'
import { UserDetails } from '../slices/global'
import jwt_decode from 'jwt-decode'
import { TeacherMandatoryEnrichedCourses } from '../../utility/types/courseTypes'

export const getCoursesByTeacher = createAsyncThunk(
  'getCoursesByTeacher',
  async (token: string) => {
    try {
      const decoded = jwt_decode(token) as UserDetails

      const response = await SECURE_API.get(
        `/teacher/courses/all?teacherId=${decoded.uid}`
      )
      console.log(response)
      const responseContent: TeacherMandatoryEnrichedCourses[] =
        response.data.courses
      return responseContent
    } catch (error) {
      alert(error)
    }
  }
)
