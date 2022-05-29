import { createAsyncThunk } from '@reduxjs/toolkit'
import { SECURE_API } from '../../utility/api'

export const getChiefResults = createAsyncThunk(
  'getChiefResults',
  async (chiefId: string) => {
    try {
      const response = await SECURE_API.get(
        `/courses/results/teachers?chiefId=${chiefId}`
      )
      console.log('HERE', response.data)
      return response.data
    } catch (error) {
      console.log(error)
      return false
    }
  }
)
