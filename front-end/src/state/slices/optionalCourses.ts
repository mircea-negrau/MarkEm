import { createSlice } from '@reduxjs/toolkit'
import { FetchStatus } from '../../utility/fetchStatus'
import { OptionalCourse } from '../../utility/types/courseTypes'
import { getOptionalCoursesBySemesterContract } from '../thunks/optionalCourses'
interface OptionalCoursesStateType {
  courses: OptionalCourse[]
  coursesStatus: FetchStatus
}

const initialState: OptionalCoursesStateType = {
  courses: [],
  coursesStatus: FetchStatus.idle
}

export const optionalCoursesSlice = createSlice({
  name: 'optionalCoursesSlice',
  initialState: initialState,
  reducers: {},

  extraReducers: builder => {
    builder.addCase(
      getOptionalCoursesBySemesterContract.fulfilled,
      (state, action) => {
        if (action.payload) {
          state.courses = action.payload
          console.log('courses are loaded', state.courses)
          state.coursesStatus = FetchStatus.success
        }
      }
    ),
      builder.addCase(
        getOptionalCoursesBySemesterContract.pending,
        (state, action) => {
          if (action.payload) {
            state.coursesStatus = FetchStatus.loading
          }
        }
      ),
      builder.addCase(
        getOptionalCoursesBySemesterContract.rejected,
        (state, action) => {
          if (action.payload) {
            state.coursesStatus = FetchStatus.error
          }
        }
      )
  }
})

export const optionalCoursesAction = optionalCoursesSlice.actions
export const optionalCoursesReducer = optionalCoursesSlice.reducer
