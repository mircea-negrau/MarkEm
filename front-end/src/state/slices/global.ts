import { createSlice, PayloadAction } from '@reduxjs/toolkit'
import { FetchStatus } from '../../utility/fetchStatus'
import { login, logout } from '../thunks/global'

interface GlobalStateType {
  accessToken: string
  accessTokenStatus: FetchStatus
  userId: string
  userRole: 'Student' | 'Teacher' | 'Admin' | 'Guest'
  username: string
  expiration: number
}

const initialState: GlobalStateType = {
  accessToken: '',
  accessTokenStatus: FetchStatus.idle,
  userId: '',
  userRole: 'Guest',
  username: '',
  expiration: 0
}

export interface UserDetails {
  Id: string
  aud: string
  Role: string
  Username: string
  iss: string
  exp: number
}

export const globalSlice = createSlice({
  name: 'global',
  initialState: initialState,
  reducers: {
    setAccessToken: (state, action: PayloadAction<string>) => {
      state.accessToken = action.payload
    },
    setUserDetails: (state, action: PayloadAction<UserDetails>) => {
      state.userId = action.payload.Id
      state.userRole = action.payload.Role as
        | 'Student'
        | 'Teacher'
        | 'Admin'
        | 'Guest'
      state.username = action.payload.Username
      state.expiration = action.payload.exp
    }
  },
  extraReducers: builder => {
    builder.addCase(login.fulfilled, (state, action) => {
      if (action.payload) {
        state.accessToken = action.payload
      }
    })

    builder.addCase(login.pending, state => {
      state.accessTokenStatus = FetchStatus.loading
    })

    builder.addCase(login.rejected, state => {
      state.accessTokenStatus = FetchStatus.error
    })

    builder.addCase(logout.fulfilled, state => {
      state.accessToken = ''
    })

    builder.addCase(logout.pending, state => {
      state.accessTokenStatus = FetchStatus.loading
    })

    builder.addCase(logout.rejected, state => {
      state.accessTokenStatus = FetchStatus.error
    })
  }
})

export const globalActions = globalSlice.actions
export const globalReducer = globalSlice.reducer
