import { TeacherEnrichedCourse } from '../../utility/types/courseTypes'
import { FunctionComponent } from 'react'
import { useSelector } from 'react-redux'
import { AppState } from '../../state/store'
import { unixSecondsToYear } from '../../utility/various'

const CourseDetailsEntry: FunctionComponent<{
  name: string
}> = props => {
  return (
    <p style={{ fontSize: '24px' }}>
      <span style={{ padding: '5px', fontWeight: 'bold' }}>{props.name}</span>
      {props.children}
    </p>
  )
}

export const CourseDetails: FunctionComponent = () => {
  const state = useSelector((state: AppState) => state.course)
  const course: TeacherEnrichedCourse = state.course

  return (
    course && (
      <div style={{ padding: '5px' }}>
        <CourseDetailsEntry name={'Course name: '}>
          {course.name}
        </CourseDetailsEntry>
        <CourseDetailsEntry name={'Course credits: '}>
          {course.credits}
        </CourseDetailsEntry>
        <CourseDetailsEntry name={'Course semester: '}>
          {course.semester}
        </CourseDetailsEntry>
        <CourseDetailsEntry name={'Course date: '}>
          {unixSecondsToYear(course.startDate)}-
          {unixSecondsToYear(course.endDate)}
        </CourseDetailsEntry>
        <CourseDetailsEntry name={'Course study line: '}>
          {course.facultyDetails.studyLine}
        </CourseDetailsEntry>
        <CourseDetailsEntry name={'Course study specialization: '}>
          {course.facultyDetails.specialization}
        </CourseDetailsEntry>
        <CourseDetailsEntry name={'Course study degree: '}>
          {course.facultyDetails.studyDegree}
        </CourseDetailsEntry>
      </div>
    )
  )
}
