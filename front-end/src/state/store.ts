import { configureStore } from '@reduxjs/toolkit'
import { contractReducer } from './slices/contracts'
import { globalReducer } from './slices/global'

export const store = configureStore({
  reducer: {
    global: globalReducer,
    contract: contractReducer
  }
})

export type AppState = ReturnType<typeof store.getState>
export type AppDispatch = typeof store.dispatch
