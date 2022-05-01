import { Semester } from './facultyTypes'
import { Profile } from './profileTypes'

export interface Course {
  id: string
  name: string
  credits: number
  semester?: Semester
  teacher?: Profile
}

export interface TeacherMandatoryEnrichedCourses {
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
