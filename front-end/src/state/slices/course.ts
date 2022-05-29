import {
  GroupEnrichedWithStudents,
  StudentWithGrade,
  TeacherEnrichedCourse
} from '../../utility/types/courseTypes'
import { FetchStatus } from '../../utility/fetchStatus'
import { createSlice } from '@reduxjs/toolkit'
import {
  getCourseById,
  getCourseGroups,
  getOptionalStudents
} from '../thunks/courses'

interface CourseStateType {
  course: TeacherEnrichedCourse
  groups: GroupEnrichedWithStudents[]
  optionalStudents: StudentWithGrade[]
  courseStatus: FetchStatus
  groupsStatus: FetchStatus
  studentsStatus: FetchStatus
}

const initialState: CourseStateType = {
  course: {
    id: '',
    name: '',
    credits: 0,
    semester: 0,
    startDate: 0,
    endDate: 0,
    isOptional: false,
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
  optionalStudents: [],
  courseStatus: FetchStatus.idle,
  groupsStatus: FetchStatus.idle,
  studentsStatus: FetchStatus.idle
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
      }),
      builder.addCase(getOptionalStudents.fulfilled, (state, action) => {
        if (action.payload) {
          state.optionalStudents = action.payload
          state.courseStatus = FetchStatus.success
        }
      }),
      builder.addCase(getOptionalStudents.pending, (state, action) => {
        if (action.payload) {
          state.courseStatus = FetchStatus.loading
        }
      }),
      builder.addCase(getOptionalStudents.rejected, (state, action) => {
        if (action.payload) {
          state.courseStatus = FetchStatus.error
        }
      })
  }
})
export const courseReducer = courseSlice.reducer
export const courseActions = courseSlice.actions
