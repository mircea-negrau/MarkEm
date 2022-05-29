import { Semester } from './facultyTypes'
import { Profile } from './profileTypes'

export interface Course {
  id: string
  name: string
  credits: number
  semester?: Semester
  teacher?: Profile
}

export interface CourseShort {
  id: string
  name: string
}

export interface OptionalCourse {
  id: string
  name: string
  maxNumberOfStudent: number
  credits: number
}

export interface TeacherEnrichedCourse {
  id: string
  name: string
  credits: number
  semester: number
  startDate: number
  endDate: number
  isOptional: boolean
  facultyDetails: {
    faculty: string
    specialization: string
    specializationSemesters: number
    studyDegree: string
    studyLine: string
    studyLineShort: string
  }
}

export interface StudentWithGrade {
  id: string
  lastName: string
  firstName: string
  grade: number
}

export interface GroupEnrichedWithStudents {
  id: string
  number: string
  students: StudentWithGrade[]
}

/// note that the URLs are for the API (BE)
export class CourseType {
  public static MANDATORY: CourseType = new CourseType(
    'MANDATORY',
    courseId => `/courses/course/${courseId}/gradeStudent`,
    courseId => `/courses/course/${courseId}`
  )
  public static OPTIONAL: CourseType = new CourseType(
    'OPTIONAL',
    courseId => `/optionals/optional/${courseId}/gradeStudent`,
    courseId => `/optionals/optional/${courseId}`
  )

  public readonly type: string
  public readonly gradeStudentURL: (courseId: string) => string
  public readonly getCourseURL: (courseId: string) => string

  private constructor(
    type: string,
    gradeStudentURL: (courseId: string) => string,
    getCourseURL: (courseId: string) => string
  ) {
    this.type = type
    this.gradeStudentURL = gradeStudentURL
    this.getCourseURL = getCourseURL
  }
}
