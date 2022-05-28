import { createAsyncThunk } from '@reduxjs/toolkit'
import { SECURE_API } from '../../utility/api'
import { UserDetails } from '../slices/global'
import jwt_decode from 'jwt-decode'
import {
  CourseShort,
  GroupEnrichedWithStudents,
  StudentWithGrade,
  TeacherEnrichedCourses
} from '../../utility/types/courseTypes'
import { SetGradeData } from '../../utility/types/gradeTypes'

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

export const getOptionalStudents = createAsyncThunk(
  'getOptionalStudents',
  async (courseId: string) => {
    try {
      console.log('getting optional students')
      const response = await SECURE_API.get(
        `/courses/course/${courseId}/groups`
      )
      const responseContent: StudentWithGrade[] =
        response.data.studentsWithGrade
      console.log(
        'getting optional students - responseContent:',
        responseContent
      )
      return responseContent
    } catch (error) {
      alert(error)
    }
  }
)

export const setStudentGrade = createAsyncThunk(
  'setStudentGrade',
  async (setGradeData: SetGradeData) => {
    try {
      console.log(
        `setting student grade for ${setGradeData.gradeType.type} course ${setGradeData.courseId} for student ${setGradeData.studentId} to ${setGradeData.grade}`
      )
      await SECURE_API.post(
        // `/courses/course/${setGradeData.courseId}/gradeStudent`,
        setGradeData.gradeType.getURL(setGradeData.courseId),
        {
          studentId: setGradeData.studentId,
          value: setGradeData.grade
        }
      )
      console.log(`setting student grade finish`)
      // console.log(`setting student grade response:`, response)
      // return response
    } catch (error) {
      alert(error)
    }
  }
)
