import { createSlice, PayloadAction } from '@reduxjs/toolkit'
import { FetchStatus } from '../../utility/fetchStatus'
import {
  chiefTeachersWithCoursesInfo,
  optionalsChiefView
} from '../../utility/types/chiefOfDepartmentTypes'
import {
  SemesterContract,
  StudyContractEnriched
} from '../../utility/types/contractTypes'
import {
  getChiefCoursesByTeacher,
  getOptionalsChiefView
} from '../thunks/chiefOfDepartment'
import { getAllContracts, getSemesterContracts } from '../thunks/contracts'

interface ChiefOfDepartmentStateType {
  optionalViews: optionalsChiefView
  teachers: chiefTeachersWithCoursesInfo
  chiefOfDepartmentStatus: FetchStatus
  teachersStatus: FetchStatus
}

const initialState: ChiefOfDepartmentStateType = {
  optionalViews: { optionals: [] },
  teachers: { chiefTeachersWithCoursesInfoList: [] },
  chiefOfDepartmentStatus: FetchStatus.idle,
  teachersStatus: FetchStatus.idle
}

export const chiefOfDepartmentSlice = createSlice({
  name: 'chiefOfDepartmentSlice',
  initialState: initialState,
  reducers: {
    setContracts: (state, action: PayloadAction<optionalsChiefView>) => {
      state.optionalViews = action.payload
    },
    resetContractsStatus: state => {
      state.chiefOfDepartmentStatus = FetchStatus.idle
    }
  },

  extraReducers: builder => {
    builder.addCase(getOptionalsChiefView.fulfilled, (state, action) => {
      if (action.payload) {
        state.optionalViews = action.payload
        state.chiefOfDepartmentStatus = FetchStatus.success
      }
    }),
      builder.addCase(getOptionalsChiefView.pending, (state, action) => {
        if (action.payload) {
          state.chiefOfDepartmentStatus = FetchStatus.loading
        }
      }),
      builder.addCase(getOptionalsChiefView.rejected, (state, action) => {
        if (action.payload) {
          state.chiefOfDepartmentStatus = FetchStatus.error
        }
      }),
      builder.addCase(getChiefCoursesByTeacher.fulfilled, (state, action) => {
        if (action.payload) {
          state.teachers = action.payload
          state.teachersStatus = FetchStatus.success
        }
      }),
      builder.addCase(getChiefCoursesByTeacher.pending, (state, action) => {
        if (action.payload) {
          state.teachersStatus = FetchStatus.loading
        }
      }),
      builder.addCase(getChiefCoursesByTeacher.rejected, (state, action) => {
        if (action.payload) {
          state.teachersStatus = FetchStatus.error
        }
      })
  }
})

export const chiefOfDepartmentActions = chiefOfDepartmentSlice.actions
export const chiefOfDepartmentReducer = chiefOfDepartmentSlice.reducer
