import axios from 'axios'
import localforage from 'localforage'

export const API = axios.create({ baseURL: process.env.REACT_APP_API_URL })

export const SECURE_API = axios.create({
  baseURL: process.env.REACT_APP_API_URL
})

SECURE_API.interceptors.request.use(async config => {
  const token = await localforage.getItem<string>('AMS_access_token')
  const headers = config.headers
  if (headers != null) {
    headers.Authorization = token ? `Bearer ${token}` : ''
  }
  return config
})
