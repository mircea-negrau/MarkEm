import { configureStore } from '@reduxjs/toolkit'
import { globalReducer } from './global-state'

export const store = configureStore({
  reducer: {
    global: globalReducer
  }
})

export type AppState = ReturnType<typeof store.getState>
export type AppDispatch = typeof store.dispatch
