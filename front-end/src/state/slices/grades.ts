import { createSlice, PayloadAction } from '@reduxjs/toolkit'
import { FetchStatus } from '../../utility/fetchStatus'
import { StudentContractGrades } from '../../utility/types/gradeTypes'

import { getAllGrades } from '../thunks/grades'

interface GradeStateType {
  grades: StudentContractGrades[]
  gradeStatus: FetchStatus
}

const initialState: GradeStateType = {
  grades: [],
  gradeStatus: FetchStatus.idle
}

export const gradesSlice = createSlice({
  name: 'gradesSlice',
  initialState: initialState,
  reducers: {
    setGrades: (state, action: PayloadAction<StudentContractGrades[]>) => {
      state.grades = action.payload
    }
  },

  extraReducers: builder => {
    builder.addCase(getAllGrades.fulfilled, (state, action) => {
      if (action.payload) {
        state.grades = action.payload
        state.gradeStatus = FetchStatus.success
      }
    }),
      builder.addCase(getAllGrades.pending, (state, action) => {
        if (action.payload) {
          state.gradeStatus = FetchStatus.loading
        }
      }),
      builder.addCase(getAllGrades.rejected, (state, action) => {
        if (action.payload) {
          state.gradeStatus = FetchStatus.error
        }
      })
  }
})

export const gradeActions = gradesSlice.actions
export const gradeReducer = gradesSlice.reducer
