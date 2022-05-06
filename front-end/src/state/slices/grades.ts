import { createSlice, PayloadAction } from '@reduxjs/toolkit'
import { FetchStatus } from '../../utility/fetchStatus'
import { Grade } from '../../utility/types/gradeTypes'
import {
  Degree,
  Faculty,
  Specialisation,
  StudyContractEnriched
} from '../../utility/types/studentTypes'
import {
  getAllContracts,
  getFaculties,
  getFacultySpecialisations
} from '../thunks/contracts'
import { getAllGrades } from '../thunks/grades'

interface GradeStateType {
  grades: Grade[]
  gradeStatus: FetchStatus
}

const initialState: GradeStateType = {
  grades: [],
  gradeStatus: FetchStatus.idle
}

export const contractsSlice = createSlice({
  name: 'grades',
  initialState: initialState,
  reducers: {
    setGrades: (state, action: PayloadAction<Grade[]>) => {
      state.grades = action.payload
    }
  },

  extraReducers: builder => {
    builder.addCase(getAllGrades.fulfilled, (state, action) => {
      if (action.payload) {
        state.grades = action.payload
        state.gradeStatus = FetchStatus.success
        console.log('fulfilled', action.payload, state.grades)
      }
    }),
      builder.addCase(getAllContracts.pending, (state, action) => {
        if (action.payload) {
          state.gradeStatus = FetchStatus.loading
        }
      }),
      builder.addCase(getAllContracts.rejected, (state, action) => {
        if (action.payload) {
          state.gradeStatus = FetchStatus.error
        }
      })
  }
})

export const gradeActions = contractsSlice.actions
export const gradeReducer = contractsSlice.reducer
