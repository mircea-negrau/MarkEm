import { createAsyncThunk } from '@reduxjs/toolkit'
import { SECURE_API } from '../../utility/api'
import { Semester, StudyYear } from '../../utility/types/facultyTypes'
import {
  StudentAverageGrade,
  Group,
  SemesterReduced,
  StudyYearReduced
} from '../../utility/types/performanceTypes'

export const getGroups = createAsyncThunk('getGroups', async () => {
  try {
    const response = await SECURE_API.get(`/admin/group/all`)
    console.log('Response-start:\n', response, 'Response-end')
    const responseContent: Group[] = response.data
    return responseContent
  } catch (error) {
    alert(error)
  }
})

export const getSemesters = createAsyncThunk('getSemesters', async () => {
  try {
    const response = await SECURE_API.get(`/admin/semester/all`)
    console.log('Response-start:\n', response, 'Response-end')
    const responseContent: SemesterReduced[] = response.data
    return responseContent
  } catch (error) {
    alert(error)
  }
})

export const getStudyYears = createAsyncThunk('getStudyYears', async () => {
  try {
    const response = await SECURE_API.get(`/admin/studyYear/all`)
    console.log('Response-start:\n', response, 'Response-end')
    const responseContent: StudyYearReduced[] = response.data
    return responseContent
  } catch (error) {
    alert(error)
  }
})

export const getPerformanceByGroup = createAsyncThunk(
  'getPerformanceByGroup',
  async (groupId: string) => {
    try {
      const response = await SECURE_API.get(
        `/admin/performance/byGroup?groupId=${groupId}`
      )
      console.log('Response-start:\n', response, 'Response-end')
      const responseContent: StudentAverageGrade[] = response.data
      return responseContent
    } catch (error) {
      alert(error)
    }
  }
)

export const getPerformanceBySemester = createAsyncThunk(
  'getPerformanceBySemester',
  async (semesterId: string) => {
    try {
      const response = await SECURE_API.get(
        `/admin/performance/bySemester?semesterId=${semesterId}`
      )
      console.log('Response-start:\n', response, 'Response-end')
      const responseContent: StudentAverageGrade[] = response.data
      return responseContent
    } catch (error) {
      alert(error)
    }
  }
)

export const getPerformanceByYearWithCriteria = createAsyncThunk(
  'getPerformanceByYearWithCriteria',
  async (Data: { yearId: string; minimumAverage: number }) => {
    try {
      const response = await SECURE_API.post(
        `/admin/performance/byStudyYear`,
        Data
      )
      console.log('Response-start:\n', response, 'Response-end')
      const responseContent: StudentAverageGrade[] = response.data
      return responseContent
    } catch (error) {
      alert(error)
    }
  }
)
