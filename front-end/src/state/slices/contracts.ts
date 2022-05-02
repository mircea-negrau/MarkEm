import { createSlice, PayloadAction } from '@reduxjs/toolkit'
import { FetchStatus } from '../../utility/fetchStatus'
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

interface ContractsStateType {
  contracts: StudyContractEnriched[]
  faculties: Faculty[]
  degrees: Degree[]
  specialisations: Specialisation[]
  contractsStatus: FetchStatus
}

const initialState: ContractsStateType = {
  contracts: [],
  faculties: [],
  degrees: [],
  specialisations: [],
  contractsStatus: FetchStatus.idle
}

export const contractsSlice = createSlice({
  name: 'contracts',
  initialState: initialState,
  reducers: {
    setContracts: (state, action: PayloadAction<StudyContractEnriched[]>) => {
      state.contracts = action.payload
    }
  },

  extraReducers: builder => {
    builder.addCase(getAllContracts.fulfilled, (state, action) => {
      if (action.payload) {
        state.contracts = action.payload
        state.contractsStatus = FetchStatus.success
        console.log('fulfilled', action.payload, state.contracts)
      }
    }),
      builder.addCase(getAllContracts.pending, (state, action) => {
        if (action.payload) {
          state.contractsStatus = FetchStatus.loading
        }
      }),
      builder.addCase(getAllContracts.rejected, (state, action) => {
        if (action.payload) {
          state.contractsStatus = FetchStatus.error
        }
      })
    builder.addCase(getFaculties.fulfilled, (state, action) => {
      if (action.payload) {
        state.faculties = action.payload.faculties
        state.degrees = action.payload.degrees
        state.contractsStatus = FetchStatus.success
        console.log('fulfilled', action.payload, state.contracts)
      }
    }),
      builder.addCase(getFaculties.pending, (state, action) => {
        if (action.payload) {
          state.contractsStatus = FetchStatus.loading
        }
      }),
      builder.addCase(getFaculties.rejected, (state, action) => {
        if (action.payload) {
          state.contractsStatus = FetchStatus.error
        }
      }),
      builder.addCase(getFacultySpecialisations.fulfilled, (state, action) => {
        if (action.payload) {
          state.specialisations = action.payload
          state.contractsStatus = FetchStatus.success
          console.log(
            'fulfilled getting specialisations',
            action.payload,
            state.contracts
          )
        }
      }),
      builder.addCase(getFacultySpecialisations.pending, (state, action) => {
        if (action.payload) {
          state.contractsStatus = FetchStatus.loading
        }
      }),
      builder.addCase(getFacultySpecialisations.rejected, (state, action) => {
        if (action.payload) {
          state.contractsStatus = FetchStatus.error
        }
      })
  }
})

export const contractActions = contractsSlice.actions
export const contractReducer = contractsSlice.reducer
