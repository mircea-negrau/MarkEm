import { createAsyncThunk } from '@reduxjs/toolkit'
import { SECURE_API } from '../../utility/api'
import { Profile } from '../../utility/types/profileTypes'

export const getProfileByUsername = createAsyncThunk(
  'getProfileByUsername',
  async (username: string) => {
    try {
      const response = await SECURE_API.get(`/profile/${username}`)
      const profile: Profile = response.data
      return profile
    } catch (error) {
      console.log(error)
    }
  }
)
