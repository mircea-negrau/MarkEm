import { createSlice } from '@reduxjs/toolkit'
import { FetchStatus } from '../../utility/fetchStatus'
import {
  CourseShort,
  TeacherEnrichedCourses
} from '../../utility/types/courseTypes'
import {
  getCoursesByTeacher,
  getCoursesNamesByContract
} from '../thunks/courses'

interface CoursesStateType {
  courses: TeacherEnrichedCourses[]
  coursesNames: CourseShort[]
  coursesStatus: FetchStatus
}

const initialState: CoursesStateType = {
  courses: [],
  coursesNames: [],
  coursesStatus: FetchStatus.idle
}

export const coursesSlice = createSlice({
  name: 'coursesSlice',
  initialState: initialState,
  reducers: {},

  extraReducers: builder => {
    builder.addCase(getCoursesByTeacher.fulfilled, (state, action) => {
      if (action.payload) {
        state.courses = action.payload
        state.coursesStatus = FetchStatus.success
      }
    }),
      builder.addCase(getCoursesByTeacher.pending, (state, action) => {
        if (action.payload) {
          state.coursesStatus = FetchStatus.loading
        }
      }),
      builder.addCase(getCoursesByTeacher.rejected, (state, action) => {
        if (action.payload) {
          state.coursesStatus = FetchStatus.error
        }
      })
    builder.addCase(getCoursesNamesByContract.fulfilled, (state, action) => {
      if (action.payload) {
        state.coursesNames = action.payload
        state.coursesStatus = FetchStatus.success
      }
    }),
      builder.addCase(getCoursesNamesByContract.pending, (state, action) => {
        if (action.payload) {
          state.coursesStatus = FetchStatus.loading
        }
      }),
      builder.addCase(getCoursesNamesByContract.rejected, (state, action) => {
        if (action.payload) {
          state.coursesStatus = FetchStatus.error
        }
      })
  }
})

export const coursesActions = coursesSlice.actions
export const coursesReducer = coursesSlice.reducer
