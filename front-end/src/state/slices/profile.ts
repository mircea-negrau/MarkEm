import { createSlice } from '@reduxjs/toolkit'
import { FetchStatus } from '../../utility/fetchStatus'
import { Profile } from '../../utility/types/profileTypes'
import { getProfileByUsername } from '../thunks/profile'

interface ProfileStateType {
  profile: Profile
  profileStatus: FetchStatus
}

const initialState: ProfileStateType = {
  profile: {
    id: '',
    role: '',
    username: '',
    firstName: '',
    lastName: ''
  },
  profileStatus: FetchStatus.idle
}

export const profileSlice = createSlice({
  name: 'profileSlice',
  initialState: initialState,
  reducers: {},

  extraReducers: builder => {
    builder.addCase(getProfileByUsername.fulfilled, (state, action) => {
      if (action.payload) {
        state.profile = action.payload
        state.profileStatus = FetchStatus.success
      }
    }),
      builder.addCase(getProfileByUsername.pending, (state, action) => {
        if (action.payload) {
          state.profileStatus = FetchStatus.loading
        }
      }),
      builder.addCase(getProfileByUsername.rejected, (state, action) => {
        if (action.payload) {
          state.profileStatus = FetchStatus.error
        }
      })
  }
})

export const profileActions = profileSlice.actions
export const profileReducer = profileSlice.reducer
