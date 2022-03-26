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
  'http://schemas.microsoft.com/ws/2008/06/identity/claims/role': string
  'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier': string
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
      state.userRole = action.payload[
        'http://schemas.microsoft.com/ws/2008/06/identity/claims/role'
      ] as 'Student' | 'Teacher' | 'Admin' | 'Guest'
      state.username =
        action.payload[
          'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier'
        ]
      state.expiration = action.payload.exp
    }
  },
  extraReducers: builder => {
    builder.addCase(login.fulfilled, (state, action) => {
      if (action.payload) {
        state.accessToken = action.payload
      }
      state.accessTokenStatus = FetchStatus.success
    })

    builder.addCase(login.pending, state => {
      state.accessTokenStatus = FetchStatus.loading
    })

    builder.addCase(login.rejected, state => {
      state.accessTokenStatus = FetchStatus.error
    })

    builder.addCase(logout.fulfilled, state => {
      state.accessToken = ''
      state.accessTokenStatus = FetchStatus.success
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
