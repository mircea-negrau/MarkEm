import { TeacherOptional } from '../../utility/types/optionalTypes'
import { FetchStatus } from '../../utility/fetchStatus'
import { createSlice } from '@reduxjs/toolkit'
import { getTeacherOptionals } from '../thunks/teacherOptionals'

interface TeacherOptionalsStateType {
  optionals: TeacherOptional[]
  optionalsStatus: FetchStatus
}

const initialState: TeacherOptionalsStateType = {
  optionals: [],
  optionalsStatus: FetchStatus.idle
}

export const teacherOptionalsSlice = createSlice({
  name: 'teacherOptionalsSlice',
  initialState: initialState,
  reducers: {},

  extraReducers: builder => {
    builder.addCase(getTeacherOptionals.fulfilled, (state, action) => {
      if (action.payload) {
        state.optionals = action.payload
        console.log('optionals are loaded', state.optionals)
        state.optionalsStatus = FetchStatus.success
      }
    }),
      builder.addCase(getTeacherOptionals.pending, (state, action) => {
        if (action.payload) {
          state.optionalsStatus = FetchStatus.loading
        }
      }),
      builder.addCase(getTeacherOptionals.rejected, (state, action) => {
        if (action.payload) {
          state.optionalsStatus = FetchStatus.error
        }
      })
  }
})

export const teacherOptionalsActions = teacherOptionalsSlice.actions
export const teacherOptionalsReducer = teacherOptionalsSlice.reducer
