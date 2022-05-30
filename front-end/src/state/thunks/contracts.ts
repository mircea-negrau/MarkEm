import { createAsyncThunk } from '@reduxjs/toolkit'
import { SECURE_API } from '../../utility/api'
import { UserDetails } from '../slices/global'
import jwt_decode from 'jwt-decode'
import {
  FacultyDetails,
  Specialisation
} from '../../utility/types/studentTypes'
import {
  SemesterContract,
  StudyContractEnriched
} from '../../utility/types/contractTypes'

export const getAllContracts = createAsyncThunk(
  'getAllContracts',
  async (token: string) => {
    try {
      const decoded = jwt_decode(token) as UserDetails

      const response = await SECURE_API.get(
        `/student/contracts/all?studentId=${decoded.uid}`
      )
      const responseContent: StudyContractEnriched[] = response.data
      return responseContent
    } catch (error) {
      console.log(error)
    }
  }
)

export const getSemesterContracts = createAsyncThunk(
  'getSemesterContracts',
  async (contractId: string) => {
    try {
      const response = await SECURE_API.get(
        `/contract/semesterContract?contractId=${contractId}`
      )
      const responseContent: SemesterContract[] = response.data
      responseContent.sort((a, b) => a.semester - b.semester)
      return responseContent
    } catch (error) {
      console.log(error)
    }
  }
)

export const getFaculties = createAsyncThunk('getFaculties', async () => {
  try {
    const response = await SECURE_API.get(`/faculty/all`)
    console.log('getting all faculties')
    const responseContent: FacultyDetails = response.data
    return responseContent
  } catch (error) {
    console.log(error)
  }
})

export const getFacultySpecialisations = createAsyncThunk(
  'getFacultySpecialisations',
  async (data: { facultyId: string; degreeId: string }) => {
    try {
      const response = await SECURE_API.get(
        `/faculty/specialisations?facultyId=${data.facultyId}&degreeId=${data.degreeId}`
      )
      console.log('getting all specialisations')
      const responseContent: Specialisation[] = response.data
      return responseContent
    } catch (error) {
      console.log(error)
    }
  }
)

export const deleteContract = createAsyncThunk(
  'deleteContract',
  async (data: { contractId: string; token: string }) => {
    try {
      console.log(data.contractId)
      const response = await SECURE_API.post(
        `/student/disenroll?contractId=${data.contractId}`
      )
      console.log(response.status, response.data)
      if (response.status == 200) console.log('succes')
    } catch (error) {
      console.log(error)
    }
  }
)

export const addContract = createAsyncThunk(
  'addContract',
  async (data: { specialisationId: string; token: string }) => {
    try {
      const decoded = jwt_decode(data.token) as UserDetails
      console.log(
        data.token,
        'getting',
        decoded.uid,
        'yes',
        data.specialisationId
      )
      const response = await SECURE_API.post(`/student/enroll`, {
        StudentID: decoded.uid,
        SpecialisationId: data.specialisationId
      })
      console.log(response.status, response.data)
      if (response.status == 200) console.log('succes')
    } catch (error) {
      console.log(error)
    }
  }
)

export const signContract = createAsyncThunk(
  'signContract',
  async (contractId: string) => {
    try {
      await SECURE_API.post(`/student/sign?contractId=${contractId}`)
    } catch (error) {
      console.log(error)
    }
  }
)

export const getStudentsAssigned = createAsyncThunk(
  'getStudentsAssigned',
  async () => {
    try {
      await SECURE_API.post(`/optionals/assign`)
    } catch (error) {
      console.log(error)
    }
  }
)
