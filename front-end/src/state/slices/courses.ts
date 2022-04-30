import { createSlice } from '@reduxjs/toolkit'
import { FetchStatus } from '../../utility/fetchStatus'
import { TeacherMandatoryEnrichedCourses } from '../../utility/types/courseTypes'
import { getCoursesByTeacher } from '../thunks/courses'

interface CoursesStateType {
  courses: TeacherMandatoryEnrichedCourses[]
  coursesStatus: FetchStatus
}

const initialState: CoursesStateType = {
  courses: [],
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
  }
})

export const coursesActions = coursesSlice.actions
export const coursesReducer = coursesSlice.reducer
