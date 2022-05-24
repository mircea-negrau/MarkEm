export interface StudentCourseGrades {
  courseName: string
  grades: Grade[]
}

export interface Grade {
  id: string
  grade: number
  courseName: string
}
