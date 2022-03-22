import { createSlice, PayloadAction } from '@reduxjs/toolkit'
import { FetchStatus } from '../utility/fetch-status'
import { getAccessToken } from './thunks/global'

// eslint-disable-next-line @typescript-eslint/no-empty-interface

interface GlobalStateType {
  authToken: string
  accessTokenStatus: FetchStatus
}

const initialState: GlobalStateType = {
  authToken: '',
  accessTokenStatus: FetchStatus.idle
}

export const globalSlice = createSlice({
  name: 'global',
  initialState: initialState,
  reducers: {
    setAuthToken: (state, action: PayloadAction<string>) => {
      state.authToken = action.payload
    },
    removeAuthToken: state => {
      state.authToken = ''
    }
  },
  extraReducers: builder => {
    builder.addCase(getAccessToken.fulfilled, state => {
      state.accessTokenStatus = FetchStatus.success
    })
    builder.addCase(getAccessToken.pending, state => {
      state.accessTokenStatus = FetchStatus.loading
    })
    builder.addCase(getAccessToken.rejected, state => {
      state.accessTokenStatus = FetchStatus.error
    })
  }
})

export const globalActions = globalSlice.actions
export const globalReducer = globalSlice.reducer
