export interface view {
  id: string
  name: string
  credits: number
  teacherLastName: string
  teacherFirstName: string
  semester: number
  isApproved: boolean
  capacity: number
  studyDegree: string
  studyLine: string
  studyLineShort: string
  specialization: string
}

export interface optionalsChiefView {
  optionals: view[]
}
