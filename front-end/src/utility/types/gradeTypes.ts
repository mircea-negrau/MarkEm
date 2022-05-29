import { CourseType } from './courseTypes'

export interface StudentContractGrades {
  id: string
  signedAt?: number
  specialisation: string
  faculty: string
  semesters: StudentContractSemesterGrades[]
}

export interface StudentContractSemesterGrades {
  id: string
  value: number
  yearStartDate: number
  yearEndDate: number
  specializationName: string
  courses: StudentCourseGrades[]
}

export interface StudentCourseGrades {
  id: string
  name: string
  teacherName: string
  grade: StudentGrade
}

export interface StudentGrade {
  id: string
  grade: number
  courseName: string
}

export interface Grade {
  gradeId: string
  grade: number
  credits: number
}

export interface SetGradeData {
  courseId: string
  studentId: string
  grade: number
  courseType: CourseType
}
