import { createSlice, PayloadAction } from '@reduxjs/toolkit'
import { FetchStatus } from '../../utility/fetchStatus'
import {
  StudyContractType,
  StudyContractTypeEnriched
} from '../../utility/types/studentTypes'
import { getAllContracts } from '../thunks/contracts'

interface ContractsStateType {
  contracts: StudyContractTypeEnriched[]
  contractsStatus: FetchStatus
}

const initialState: ContractsStateType = {
  contracts: [],
  contractsStatus: FetchStatus.idle
}

export const contractsSlice = createSlice({
  name: 'contracts',
  initialState: initialState,
  reducers: {
    setContracts: (
      state,
      action: PayloadAction<StudyContractTypeEnriched[]>
    ) => {
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
  }
})

export const contractActions = contractsSlice.actions
export const contractReducer = contractsSlice.reducer
