import { createSlice, PayloadAction } from '@reduxjs/toolkit'
import { FetchStatus } from '../../utility/fetchStatus'
import {
  SemesterContract,
  StudyContractEnriched
} from '../../utility/types/contractTypes'
import {
  Degree,
  Faculty,
  Specialisation
} from '../../utility/types/studentTypes'
import {
  getAllContracts,
  getFaculties,
  getFacultySpecialisations,
  getSemesterContracts
} from '../thunks/contracts'

interface FacultyStateType {
  faculties: Faculty[]
  degrees: Degree[]
  specialisations: Specialisation[]
  facultyStatus: FetchStatus
}

const initialState: FacultyStateType = {
  faculties: [],
  degrees: [],
  specialisations: [],
  facultyStatus: FetchStatus.idle
}

export const contractsSlice = createSlice({
  name: 'contracts',
  initialState: initialState,
  reducers: {
    setFaculties: (state, action: PayloadAction<Faculty[]>) => {
      state.faculties = action.payload
    }
  },

  extraReducers: builder => {
    builder.addCase(getFaculties.fulfilled, (state, action) => {
      if (action.payload) {
        state.faculties = action.payload.faculties
        state.degrees = action.payload.degrees
        state.facultyStatus = FetchStatus.success
        console.log('fulfilled', action.payload)
      }
    }),
      builder.addCase(getFaculties.pending, (state, action) => {
        if (action.payload) {
          state.facultyStatus = FetchStatus.loading
        }
      }),
      builder.addCase(getFaculties.rejected, (state, action) => {
        if (action.payload) {
          state.facultyStatus = FetchStatus.error
        }
      }),
      builder.addCase(getFacultySpecialisations.fulfilled, (state, action) => {
        if (action.payload) {
          state.specialisations = action.payload
          console.log('fulfilled getting specialisations', action.payload)
        }
      })
  }
})

export const facultyActions = contractsSlice.actions
export const facultyReducer = contractsSlice.reducer
