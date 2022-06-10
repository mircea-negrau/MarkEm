import { createAsyncThunk } from '@reduxjs/toolkit'
import { SECURE_API } from '../../utility/api'
import {
  chiefTeachersWithCoursesInfo,
  optionalsChiefView as optionalsChiefView
} from '../../utility/types/chiefOfDepartmentTypes'
import { OptionalCourse } from '../../utility/types/courseTypes'

export const getOptionalsChiefView = createAsyncThunk(
  'getOptionalsChiefView',
  async () => {
    try {
      const response = await SECURE_API.get(`/optionals/all/chiefPage`)
      console.log('getting chief view')
      const responseContent: optionalsChiefView = response.data
      console.log(responseContent)
      return responseContent
    } catch (error) {
      console.log(error)
    }
  }
)

export const getChiefCoursesByTeacher = createAsyncThunk(
  'getChiefCoursesByTeacher',
  async () => {
    try {
      const response = await SECURE_API.get(`/courses/all/by-teachers`)
      console.log('getting chief view')
      const responseContent: chiefTeachersWithCoursesInfo = response.data
      console.log(responseContent)
      return responseContent
    } catch (error) {
      console.log(error)
    }
  }
)

export const approveOptional = createAsyncThunk(
  'approveOptional',
  async (optionalId: string) => {
    try {
      const response = await SECURE_API.post(
        `/optionals/optional/${optionalId}/approve`
      )
      console.log('getting chief view')
      const responseContent: string = response.data
      console.log(responseContent)
      return responseContent
    } catch (error) {
      console.log(error)
    }
  }
)

export const setOptionalCapacity = createAsyncThunk(
  'setCapacity',
  async (data: { optionalId: string; capacity: number }) => {
    console.log('capacity', data.capacity)

    try {
      const response = await SECURE_API.post(
        `/optionals/optional/${data.optionalId}/setCapacity?capacity=${data.capacity}`,
        { capacity: data.capacity }
      )
      const responseContent: string = response.data
      console.log(responseContent)
      return responseContent
    } catch (error) {
      console.log(error)
    }
  }
)
