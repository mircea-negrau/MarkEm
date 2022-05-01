import { Profile } from './profileTypes'

export interface Semester {
  id: string
  semester: number
  studyYear?: StudyYear
}

export interface StudyYear {
  id: string
  startDate: number
  endDate: number
  specialisation?: FacultySpecialisation
  studentLeader?: Profile
}

export interface FacultySpecialisation {
  id: string
  name: string
  semesters: number
  faculty?: Faculty
  studyDegree?: StudyDegree
  studyLine?: StudyLine
}

export interface Faculty {
  id: string
  name: string
  chiefOfDepartment?: Profile
}

export interface StudyDegree {
  id: string
  name: string
}

export interface StudyLine {
  id: string
  name: string
  shortName: string
}
