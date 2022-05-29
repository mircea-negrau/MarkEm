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

interface ContractsStateType {
  contracts: StudyContractEnriched[]
  semesterContracts: SemesterContract[]
  contractsStatus: FetchStatus
}

const initialState: ContractsStateType = {
  contracts: [],
  semesterContracts: [],
  contractsStatus: FetchStatus.idle
}

export const contractsSlice = createSlice({
  name: 'contracts',
  initialState: initialState,
  reducers: {
    setContracts: (state, action: PayloadAction<StudyContractEnriched[]>) => {
      state.contracts = action.payload
    },
    resetContractsStatus: state => {
      state.contractsStatus = FetchStatus.idle
    }
  },

  extraReducers: builder => {
    builder.addCase(getAllContracts.fulfilled, (state, action) => {
      if (action.payload) {
        state.contracts = action.payload
        state.contractsStatus = FetchStatus.success
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
    builder.addCase(getSemesterContracts.fulfilled, (state, action) => {
      if (action.payload) {
        state.semesterContracts = action.payload
        state.contractsStatus = FetchStatus.success
        console.log('fulfilled', action.payload, state.contracts)
      }
    }),
      builder.addCase(getSemesterContracts.pending, (state, action) => {
        if (action.payload) {
          state.contractsStatus = FetchStatus.loading
        }
      }),
      builder.addCase(getSemesterContracts.rejected, (state, action) => {
        if (action.payload) {
          state.contractsStatus = FetchStatus.error
        }
      })
  }
})

export const contractActions = contractsSlice.actions
export const contractReducer = contractsSlice.reducer
