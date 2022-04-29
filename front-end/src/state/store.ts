import { configureStore } from '@reduxjs/toolkit'
import { contractReducer } from './slices/contracts'
import { globalReducer } from './slices/global'
import { profileReducer } from './slices/profile'

export const store = configureStore({
  reducer: {
    global: globalReducer,
    contract: contractReducer,
    profile: profileReducer
  }
})

export type AppState = ReturnType<typeof store.getState>
export type AppDispatch = typeof store.dispatch
