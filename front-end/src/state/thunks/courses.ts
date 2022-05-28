import { createAsyncThunk } from '@reduxjs/toolkit'
import { SECURE_API } from '../../utility/api'
import { UserDetails } from '../slices/global'
import jwt_decode from 'jwt-decode'
import {
  CourseShort,
  GroupEnrichedWithStudents,
  TeacherEnrichedCourses
} from '../../utility/types/courseTypes'

export const getCoursesByTeacher = createAsyncThunk(
  'getCoursesByTeacher',
  async (token: string) => {
    try {
      const decoded = jwt_decode(token) as UserDetails

      const mandatoryCoursesResponse = await SECURE_API.get(
        `/courses/all?teacherId=${decoded.uid}`
      )
      console.log(
        'Response-mandatoryCoursesResponse:\n',
        mandatoryCoursesResponse,
        'Response-end'
      )
      const optionalCoursesResponse = await SECURE_API.get(
        `/optionals/all?teacherId=${decoded.uid}`
      )
      console.log(
        'Response-optionalCoursesResponse:\n',
        optionalCoursesResponse,
        'Response-end'
      )
      const partialResponseContent: TeacherEnrichedCourses[] =
        mandatoryCoursesResponse.data.courses
      // mandatoryCoursesResponse.data.courses.push(
      //   ...optionalCoursesResponse.data.courses
      // )
      const responseContent: TeacherEnrichedCourses[] =
        partialResponseContent.concat(optionalCoursesResponse.data.courses)
      console.log('responseContent =', responseContent)
      return responseContent
    } catch (error) {
      alert(error)
    }
  }
)

export const getCoursesNamesByContract = createAsyncThunk(
  'getCoursesNamesByContract',
  async (contractId: string) => {
    try {
      console.log('getting courses')
      const response = await SECURE_API.get(
        `contract/courses?contractId=${contractId}`
      )
      console.log('Response-start:\n', response, 'Response-end')
      const responseContent: CourseShort[] = response.data
      return responseContent
    } catch (error) {
      alert(error)
    }
  }
)

export const getCourseGroups = createAsyncThunk(
  'getCourseGroups',
  async (courseId: string) => {
    try {
      console.log('getting course groups')
      const response = await SECURE_API.get(
        `/courses/course/${courseId}/groups`
      )
      const responseContent: GroupEnrichedWithStudents[] = response.data.groups
      console.log('getting course groups - responseContent:', responseContent)
      return responseContent
    } catch (error) {
      alert(error)
    }
  }
)

export const getCourseById = createAsyncThunk(
  'getCourseById',
  async (courseId: string) => {
    try {
      console.log('getting course by id')
      const response = await SECURE_API.get(`/courses/course/${courseId}`)
      const responseContent: TeacherEnrichedCourses = response.data
      console.log('getting course by id - responseContent:', responseContent)

      return responseContent
    } catch (error) {
      alert(error)
    }
  }
)
