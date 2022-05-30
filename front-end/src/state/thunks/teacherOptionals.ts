import { createAsyncThunk } from '@reduxjs/toolkit'
import { SECURE_API } from '../../utility/api'
import { TeacherOptional } from '../../utility/types/optionalTypes'

export const getTeacherOptionals = createAsyncThunk(
  'getTeacherOptionals',
  async () => {
    try {
      console.log(`getting teacher optionals`)

      const response = await SECURE_API.get(
        `/optionals/all/for-teacher-optionals-page`
      )
      const responseContent: TeacherOptional[] = response.data.optionals

      console.log(
        `getting teacher optionals - responseContent: ${responseContent}`
      )

      return responseContent
    } catch (error) {
      console.log(error)
    }
  }
)

export const proposeOptionals = createAsyncThunk(
  'getTeacherOptionals',
  async (data: { first: string; second: string }) => {
    try {
      const first = data.first
      const second = data.second
      console.log(`proposing optionals ${first} ${second}`)

      const response = await SECURE_API.post(`/optionals/propose`, {
        first: first,
        second: second
      })

      console.log(`proposing optionals - response: ${response}`)

      return response
    } catch (error) {
      console.log(error)
    }
  }
)
