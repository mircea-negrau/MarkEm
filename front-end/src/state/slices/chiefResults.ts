import { createSlice } from '@reduxjs/toolkit'
import { FetchStatus } from '../../utility/fetchStatus'
import { getChiefResults } from '../thunks/chief'

export interface TeacherPerformance {
  id: string
  lastName: string
  firstName: string
  teacherPerformance: number
}

interface CourseStateType {
  performances: TeacherPerformance[]
  performancesStatus: FetchStatus
}

const initialState: CourseStateType = {
  performances: [],
  performancesStatus: FetchStatus.idle
}

export const chiefResultsSlice = createSlice({
  name: 'chiefResultsSlice',
  initialState: initialState,
  reducers: {},
  extraReducers: builder => {
    builder.addCase(getChiefResults.fulfilled, (state, action) => {
      if (action.payload) {
        state.performances = action.payload
        state.performancesStatus = FetchStatus.success
      }
    }),
      builder.addCase(getChiefResults.pending, (state, action) => {
        if (action.payload) {
          state.performancesStatus = FetchStatus.loading
        }
      }),
      builder.addCase(getChiefResults.rejected, (state, action) => {
        if (action.payload) {
          state.performancesStatus = FetchStatus.error
        }
      })
  }
})
export const chiefResultsReducer = chiefResultsSlice.reducer
export const chiefResultsActions = chiefResultsSlice.actions
