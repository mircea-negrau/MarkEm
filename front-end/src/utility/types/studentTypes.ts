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

export interface Faculty {
  id: string
  name: string
}

export interface Degree {
  id: string
  name: string
}

export interface Specialisation {
  id: string
  name: string
}

export interface FacultyDetails {
  faculties: Faculty[]
  degrees: Degree[]
}
