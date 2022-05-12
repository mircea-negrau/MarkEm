import { createSlice, PayloadAction } from '@reduxjs/toolkit'
import { FetchStatus } from '../../utility/fetchStatus'
import { Profile } from '../../utility/types/profileTypes'
import { getCurrentProfile, login, logout } from '../thunks/global'

interface GlobalStateType {
  accessToken: string
  accessTokenStatus: FetchStatus
  userId: string
  userRole: 'Student' | 'Teacher' | 'Admin' | 'Guest'
  username: string
  firstName: string
  lastName: string
  expiration: number
  profilePicture: string
  profileStatus: FetchStatus
  profile: Profile
}

const initialState: GlobalStateType = {
  accessToken: '',
  accessTokenStatus: FetchStatus.idle,
  userId: '',
  userRole: 'Guest',
  username: '',
  firstName: '',
  lastName: '',
  expiration: 0,
  profilePicture: '',
  profileStatus: FetchStatus.idle,
  profile: {
    id: '',
    role: '',
    username: '',
    firstName: '',
    lastName: ''
  }
}

export interface UserDetails {
  uid: string
  aud: string
  role: string
  username: string
  firstName: string
  lastName: string
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
      state.userId = action.payload.uid
      state.userRole = action.payload.role as 'Student' | 'Teacher' | 'Admin'
      state.username = action.payload.username
      state.expiration = action.payload.exp
      state.firstName = action.payload.firstName
      state.lastName = action.payload.lastName
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

    builder.addCase(getCurrentProfile.fulfilled, (state, action) => {
      if (action.payload) {
        state.profile = action.payload
      }
      state.profileStatus = FetchStatus.success
    })

    builder.addCase(getCurrentProfile.pending, state => {
      state.profileStatus = FetchStatus.loading
    })

    builder.addCase(getCurrentProfile.rejected, state => {
      state.profileStatus = FetchStatus.error
    })
  }
})

export const globalActions = globalSlice.actions
export const globalReducer = globalSlice.reducer
