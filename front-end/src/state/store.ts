import { configureStore } from '@reduxjs/toolkit'
import { contractReducer } from './slices/contracts'
import { coursesReducer } from './slices/courses'
import { courseReducer } from './slices/course'
import { globalReducer } from './slices/global'
import { gradeReducer } from './slices/grades'
import { performanceReducer } from './slices/performance'
import { optionalCoursesReducer } from './slices/optionalCourses'
import { profileReducer } from './slices/profile'
import { facultyReducer } from './slices/faculties'
import { chiefResultsReducer } from './slices/chiefResults'

export const store = configureStore({
  reducer: {
    global: globalReducer,
    contracts: contractReducer,
    courses: coursesReducer,
    course: courseReducer,
    grades: gradeReducer,
    optionalCourses: optionalCoursesReducer,
    profile: profileReducer,
    performance: performanceReducer,
    faculties: facultyReducer,
    chiefResults: chiefResultsReducer
  }
})

export type AppState = ReturnType<typeof store.getState>
export type AppDispatch = typeof store.dispatch
