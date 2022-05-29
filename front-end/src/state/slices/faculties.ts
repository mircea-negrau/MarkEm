import { createSlice, PayloadAction } from '@reduxjs/toolkit'
import { FetchStatus } from '../../utility/fetchStatus'
import {
  Degree,
  Faculty,
  Specialisation
} from '../../utility/types/studentTypes'
import { getFaculties, getFacultySpecialisations } from '../thunks/contracts'

interface FacultyStateType {
  faculties: Faculty[]
  degrees: Degree[]
  specialisations: Specialisation[]
  facultyStatus: FetchStatus
  specialisationsStatus: FetchStatus
}

const initialState: FacultyStateType = {
  faculties: [],
  degrees: [],
  specialisations: [],
  facultyStatus: FetchStatus.idle,
  specialisationsStatus: FetchStatus.idle
}

export const facultiesSlice = createSlice({
  name: 'facultiesSlice',
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
          state.specialisationsStatus = FetchStatus.success
        }
      }),
      builder.addCase(getFacultySpecialisations.pending, (state, action) => {
        if (action.payload) {
          state.specialisationsStatus = FetchStatus.loading
        }
      }),
      builder.addCase(getFacultySpecialisations.rejected, (state, action) => {
        if (action.payload) {
          state.specialisationsStatus = FetchStatus.error
        }
      })
  }
})

export const facultyActions = facultiesSlice.actions
export const facultyReducer = facultiesSlice.reducer
