import { configureStore } from '@reduxjs/toolkit'
import { globalReducer } from './slices/global'

export const store = configureStore({
  reducer: {
    global: globalReducer
  }
})

export type AppState = ReturnType<typeof store.getState>
export type AppDispatch = typeof store.dispatch
