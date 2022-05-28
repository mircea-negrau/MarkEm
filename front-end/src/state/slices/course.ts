import {
  GroupEnrichedWithStudents,
  TeacherEnrichedCourses
} from '../../utility/types/courseTypes'
import { FetchStatus } from '../../utility/fetchStatus'
import { createSlice } from '@reduxjs/toolkit'
import { getCourseById, getCourseGroups } from '../thunks/courses'

interface CourseStateType {
  course: TeacherEnrichedCourses
  groups: GroupEnrichedWithStudents[]
  courseStatus: FetchStatus
  groupsStatus: FetchStatus
}

const initialState: CourseStateType = {
  course: {
    id: '',
    name: '',
    credits: 0,
    semester: 0,
    startDate: 0,
    endDate: 0,
    facultyDetails: {
      faculty: '',
      specialization: '',
      specializationSemesters: 0,
      studyDegree: '',
      studyLine: '',
      studyLineShort: ''
    }
  },
  groups: [],
  courseStatus: FetchStatus.idle,
  groupsStatus: FetchStatus.idle
}

export const courseSlice = createSlice({
  name: 'courseSlice',
  initialState: initialState,
  reducers: {},
  extraReducers: builder => {
    builder.addCase(getCourseById.fulfilled, (state, action) => {
      if (action.payload) {
        state.course = action.payload
        state.courseStatus = FetchStatus.success
      }
    }),
      builder.addCase(getCourseById.pending, (state, action) => {
        if (action.payload) {
          state.courseStatus = FetchStatus.loading
        }
      }),
      builder.addCase(getCourseById.rejected, (state, action) => {
        if (action.payload) {
          state.courseStatus = FetchStatus.error
        }
      }),
      builder.addCase(getCourseGroups.fulfilled, (state, action) => {
        if (action.payload) {
          state.groups = action.payload
          state.groupsStatus = FetchStatus.success
        }
      }),
      builder.addCase(getCourseGroups.pending, (state, action) => {
        if (action.payload) {
          state.groupsStatus = FetchStatus.loading
        }
      }),
      builder.addCase(getCourseGroups.rejected, (state, action) => {
        if (action.payload) {
          state.groupsStatus = FetchStatus.error
        }
      })
  }
})
export const courseReducer = courseSlice.reducer
