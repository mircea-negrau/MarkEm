import { configureStore } from '@reduxjs/toolkit'
import { contractReducer } from './slices/contracts'
import { coursesReducer } from './slices/courses'
import { globalReducer } from './slices/global'
import { profileReducer } from './slices/profile'

export const store = configureStore({
  reducer: {
    global: globalReducer,
    contract: contractReducer,
    courses: coursesReducer,
    profile: profileReducer
  }
})

export type AppState = ReturnType<typeof store.getState>
export type AppDispatch = typeof store.dispatch
