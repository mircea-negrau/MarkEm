import { CourseType } from './courseTypes'

export interface StudentCourseGrades {
  courseName: string
  grades: Grade[]
}

export interface Grade {
  id: string
  grade: number
  courseName: string
}

export interface SetGradeData {
  courseId: string
  studentId: string
  grade: number
  courseType: CourseType
}
