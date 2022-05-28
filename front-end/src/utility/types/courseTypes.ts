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

export interface TeacherEnrichedCourses {
  id: string
  name: string
  credits: number
  semester: number
  startDate: number
  endDate: number
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

export interface Group {
  id: string
  number: string
  students: StudentWithGrade[]
}
