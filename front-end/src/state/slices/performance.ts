import { createSlice, PayloadAction } from '@reduxjs/toolkit'
import { FetchStatus } from '../../utility/fetchStatus'
import {
  Group,
  SemesterReduced,
  StudentAverageGrade,
  StudyYearReduced
} from '../../utility/types/performanceTypes'
import {
  getGroups,
  getPerformanceByGroup,
  getPerformanceBySemester,
  getPerformanceByYearWithCriteria,
  getSemesters,
  getStudyYears
} from '../thunks/performance'

interface PerformanceStateType {
  groups: Group[]
  students: StudentAverageGrade[]
  semesters: SemesterReduced[]
  studyYears: StudyYearReduced[]
  performanceStatus: FetchStatus
}

const initialState: PerformanceStateType = {
  groups: [],
  students: [],
  semesters: [],
  studyYears: [],
  performanceStatus: FetchStatus.idle
}

export const performanceSlice = createSlice({
  name: 'performanceSlice',
  initialState: initialState,
  reducers: {
    setGroups: (state, action: PayloadAction<Group[]>) => {
      state.groups = action.payload
    },
    setStudents: (state, action: PayloadAction<StudentAverageGrade[]>) => {
      state.students = action.payload
    }
  },

  extraReducers: builder => {
    builder.addCase(getGroups.fulfilled, (state, action) => {
      if (action.payload) {
        state.groups = action.payload
        state.performanceStatus = FetchStatus.success
      }
    }),
      builder.addCase(getGroups.pending, (state, action) => {
        if (action.payload) {
          state.performanceStatus = FetchStatus.loading
        }
      }),
      builder.addCase(getGroups.rejected, (state, action) => {
        if (action.payload) {
          state.performanceStatus = FetchStatus.error
        }
      }),
      builder.addCase(getPerformanceByGroup.fulfilled, (state, action) => {
        if (action.payload) {
          state.students = action.payload
          state.performanceStatus = FetchStatus.success
        }
      }),
      builder.addCase(getPerformanceByGroup.pending, (state, action) => {
        if (action.payload) {
          state.performanceStatus = FetchStatus.loading
        }
      }),
      builder.addCase(getPerformanceByGroup.rejected, (state, action) => {
        if (action.payload) {
          state.performanceStatus = FetchStatus.error
        }
      }),
      builder.addCase(
        getPerformanceByYearWithCriteria.fulfilled,
        (state, action) => {
          if (action.payload) {
            state.students = action.payload
            state.performanceStatus = FetchStatus.success
          }
        }
      ),
      builder.addCase(
        getPerformanceByYearWithCriteria.pending,
        (state, action) => {
          if (action.payload) {
            state.performanceStatus = FetchStatus.loading
          }
        }
      ),
      builder.addCase(
        getPerformanceByYearWithCriteria.rejected,
        (state, action) => {
          if (action.payload) {
            state.performanceStatus = FetchStatus.error
          }
        }
      ),
      builder.addCase(getPerformanceBySemester.fulfilled, (state, action) => {
        if (action.payload) {
          state.students = action.payload
          state.performanceStatus = FetchStatus.success
        }
      }),
      builder.addCase(getPerformanceBySemester.pending, (state, action) => {
        if (action.payload) {
          state.performanceStatus = FetchStatus.loading
        }
      }),
      builder.addCase(getPerformanceBySemester.rejected, (state, action) => {
        if (action.payload) {
          state.performanceStatus = FetchStatus.error
        }
      }),
      builder.addCase(getSemesters.fulfilled, (state, action) => {
        if (action.payload) {
          state.semesters = action.payload
          state.performanceStatus = FetchStatus.success
        }
      }),
      builder.addCase(getSemesters.pending, (state, action) => {
        if (action.payload) {
          state.performanceStatus = FetchStatus.loading
        }
      }),
      builder.addCase(getSemesters.rejected, (state, action) => {
        if (action.payload) {
          state.performanceStatus = FetchStatus.error
        }
      }),
      builder.addCase(getStudyYears.fulfilled, (state, action) => {
        if (action.payload) {
          state.studyYears = action.payload
          state.performanceStatus = FetchStatus.success
        }
      }),
      builder.addCase(getStudyYears.pending, (state, action) => {
        if (action.payload) {
          state.performanceStatus = FetchStatus.loading
        }
      }),
      builder.addCase(getStudyYears.rejected, (state, action) => {
        if (action.payload) {
          state.performanceStatus = FetchStatus.error
        }
      })
  }
})

export const performanceActions = performanceSlice.actions
export const performanceReducer = performanceSlice.reducer
