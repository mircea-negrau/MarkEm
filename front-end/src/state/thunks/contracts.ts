import { createAsyncThunk } from '@reduxjs/toolkit'
import { SECURE_API, API } from '../../utility/api'
import { UserDetails } from '../slices/global'
import jwt_decode from 'jwt-decode'
import { StudyContractTypeEnriched } from '../../utility/types/studentTypes'
import { Http } from '@mui/icons-material'

export const getAllContracts = createAsyncThunk(
  'getAllContracts',
  async (token: string) => {
    try {
      const decoded = jwt_decode(token) as UserDetails

      const response = await SECURE_API.get(
        `/student/contracts/all?studentId=${decoded.uid}`
      )
      console.log('gettig all contracts')
      const responseContent: StudyContractTypeEnriched[] = response.data
      return responseContent
    } catch (error) {
      alert(error)
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
      alert(error)
    }
  }
)
