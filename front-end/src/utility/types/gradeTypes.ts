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

export class GradeType {
  public static MANDATORY: GradeType = new GradeType(
    'MANDATORY',
    courseId => `/courses/course/${courseId}/gradeStudent`
  )
  public static OPTIONAL: GradeType = new GradeType(
    'OPTIONAL',
    courseId => `/courses/course/${courseId}/gradeStudent`
  )

  public readonly type: string
  private readonly urlMapper: (courseId: string) => string

  private constructor(type: string, urlMapper: (courseId: string) => string) {
    this.type = type
    this.urlMapper = urlMapper
  }

  public getURL(courseId: string) {
    return this.urlMapper(courseId)
  }
}

export interface SetGradeData {
  courseId: string
  studentId: string
  grade: number
  gradeType: GradeType
}
