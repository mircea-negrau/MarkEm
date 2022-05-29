export interface StudentCourseGrades {
  courseName: string
  grades: Grade[]
}

export interface Grade {
  id: string
  grade: number
  courseName: string
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
