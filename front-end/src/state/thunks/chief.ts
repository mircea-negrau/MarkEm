import { createAsyncThunk } from '@reduxjs/toolkit'
import { SECURE_API } from '../../utility/api'

export const getChiefTeacherResults = createAsyncThunk(
  'getChiefResults',
  async (chiefId: string) => {
    try {
      const response = await SECURE_API.get(
        `/courses/results/teachers?chiefId=${chiefId}`
      )
      return response.data
    } catch (error) {
      console.log(error)
      return false
    }
  }
)

export const getChiefCourseResults = createAsyncThunk(
  'getChiefCourseResults',
  async (chiefId: string) => {
    try {
      const response = await SECURE_API.get(
        `/courses/results/courses?chiefId=${chiefId}`
      )
      return response.data
    } catch (error) {
      console.log(error)
      return false
    }
  }
)
