import { StringSchema } from 'yup'

export interface Group {
  groupId: string
  number?: string
}

export interface StudentAverageGrade {
  studentId: string
  averageGrade?: number
  studentEmail?: string
}

export interface StudyYearReduced {
  id: string
  startDate?: number
  endDate?: number
  specialisationName: string
}

export interface SemesterReduced {
  id: string
  value?: number
}
