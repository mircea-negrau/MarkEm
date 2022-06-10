import { createSlice } from '@reduxjs/toolkit'
import { FetchStatus } from '../../utility/fetchStatus'
import { getChiefTeacherResults, getChiefCourseResults } from '../thunks/chief'

export interface TeacherPerformance {
  teacherId: string
  teacherFirstName: string
  teacherLastName: string
  teacherPerformance?: number
}

export interface CoursePerformance {
  courseId: string
  courseName: string
  coursePerformance?: number
}

interface CourseStateType {
  teacherPerformances: TeacherPerformance[]
  coursePerformances: CoursePerformance[]
  teacherPerformancesStatus: FetchStatus
  coursePerformancesStatus: FetchStatus
}

const initialState: CourseStateType = {
  teacherPerformances: [],
  coursePerformances: [],
  teacherPerformancesStatus: FetchStatus.idle,
  coursePerformancesStatus: FetchStatus.idle
}

export const chiefResultsSlice = createSlice({
  name: 'chiefResultsSlice',
  initialState: initialState,
  reducers: {},
  extraReducers: builder => {
    builder.addCase(getChiefTeacherResults.fulfilled, (state, action) => {
      if (action.payload) {
        state.teacherPerformances = action.payload.sort(
          (a: TeacherPerformance, b: TeacherPerformance) => {
            if (
              a.teacherPerformance == undefined &&
              b.teacherPerformance == undefined
            )
              return 0
            else if (a.teacherPerformance == undefined) return 1
            else if (b.teacherPerformance == undefined) return -1
            return b.teacherPerformance - a.teacherPerformance
          }
        )
        state.teacherPerformancesStatus = FetchStatus.success
      }
    }),
      builder.addCase(getChiefTeacherResults.pending, (state, action) => {
        if (action.payload) {
          state.teacherPerformancesStatus = FetchStatus.loading
        }
      }),
      builder.addCase(getChiefTeacherResults.rejected, (state, action) => {
        if (action.payload) {
          state.teacherPerformancesStatus = FetchStatus.error
        }
      })
    builder.addCase(getChiefCourseResults.fulfilled, (state, action) => {
      if (action.payload) {
        state.coursePerformances = action.payload.sort(
          (a: CoursePerformance, b: CoursePerformance) => {
            if (
              a.coursePerformance == undefined &&
              b.coursePerformance == undefined
            )
              return 0
            else if (a.coursePerformance == undefined) return 1
            else if (b.coursePerformance == undefined) return -1
            return b.coursePerformance - a.coursePerformance
          }
        )
        state.coursePerformancesStatus = FetchStatus.success
      }
    }),
      builder.addCase(getChiefCourseResults.pending, (state, action) => {
        if (action.payload) {
          state.coursePerformancesStatus = FetchStatus.loading
        }
      }),
      builder.addCase(getChiefCourseResults.rejected, (state, action) => {
        if (action.payload) {
          state.coursePerformancesStatus = FetchStatus.error
        }
      })
  }
})
export const chiefResultsReducer = chiefResultsSlice.reducer
export const chiefResultsActions = chiefResultsSlice.actions
