import { createSlice, PayloadAction } from '@reduxjs/toolkit'
import { FetchStatus } from '../../utility/fetchStatus'
import { StudentContractGrades } from '../../utility/types/gradeTypes'

import { getAllGrades } from '../thunks/grades'

interface GradeStateType {
  enrichedContracts: StudentContractGrades[]
  enrichedContractsGradeStatus: FetchStatus
}

const initialState: GradeStateType = {
  enrichedContracts: [],
  enrichedContractsGradeStatus: FetchStatus.idle
}

export const gradesSlice = createSlice({
  name: 'gradesSlice',
  initialState: initialState,
  reducers: {
    setGrades: (state, action: PayloadAction<StudentContractGrades[]>) => {
      state.enrichedContracts = action.payload
    }
  },

  extraReducers: builder => {
    builder.addCase(getAllGrades.fulfilled, (state, action) => {
      if (action.payload) {
        state.enrichedContracts = action.payload
        state.enrichedContractsGradeStatus = FetchStatus.success
      }
    }),
      builder.addCase(getAllGrades.pending, (state, action) => {
        if (action.payload) {
          state.enrichedContractsGradeStatus = FetchStatus.loading
        }
      }),
      builder.addCase(getAllGrades.rejected, (state, action) => {
        if (action.payload) {
          state.enrichedContractsGradeStatus = FetchStatus.error
        }
      })
  }
})

export const gradeActions = gradesSlice.actions
export const gradeReducer = gradesSlice.reducer
