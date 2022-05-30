export interface view {
  id: string
  name: string
  credits: number
  teacherLastName: string
  teacherFirstName: string
  semester: number
  isApproved: boolean
  capacity: number
  studyDegree: string
  studyLine: string
  studyLineShort: string
  specialization: string
}

export interface optionalsChiefView {
  optionals: view[]
}

export interface chiefTeacherWithCoursesInfo {
  teacherName: string
  teacherId: string
  chiefTeacherCoursesInfo: chiefTeacherCourseInfo[]
}

export interface chiefTeacherCourseInfo {
  specialization: string
  year: number
  semester: number
  name: string
  credits: number
}

export interface chiefTeachersWithCoursesInfo {
  chiefTeachersWithCoursesInfoList: chiefTeacherWithCoursesInfo[]
}
