export interface StudyContractType {
  id: string
  signedAt?: number
  studentId: string
  groupId?: string
  optionalCourseId?: string
  yearId?: string
}

export interface StudyContractTypeEnriched {
  id: string
  signedAt?: number
  specialisation?: string
  faculty?: string
}
