export interface StudyContract {
  id: string
  signedAt?: number
  studentId: string
  groupId?: string
  optionalCourseId?: string
  yearId?: string
}

export interface StudyContractEnriched {
  id: string
  signedAt?: number
  specialisation?: string
  faculty?: string
}

export interface SemesterContract {
  id: string
  contractId: string
  semester: number
  optionaCourseId: string
  optionalCourseName: string
}
