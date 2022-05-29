import { FunctionComponent, useEffect } from 'react'
import { useParams } from 'react-router-dom'
import { useDispatch, useSelector } from 'react-redux'
import { AppState } from '../../state/store'
import { CourseType } from '../../utility/types/courseTypes'
import { getCourseById } from '../../state/thunks/courses'
import { CourseDetails } from '../../ui-kit/Course/CourseDetails'
import { StudentsGrades } from '../../ui-kit/Course/StudentsGrades'

export const CoursePage: FunctionComponent<{
  courseType: CourseType
}> = props => {
  const { courseId } = useParams()
  const state = useSelector((state: AppState) => state.course)
  const courseType = props.courseType
  const dispatch = useDispatch()

  useEffect(() => {
    // if (state.courseStatus != FetchStatus.success && courseId) {
    if (courseId) {
      dispatch(getCourseById({ courseId: courseId, courseType: courseType }))
    }
  }, [courseId, courseType, dispatch, state.courseStatus])

  return (
    state.course && (
      <div style={{ padding: '20px' }}>
        <CourseDetails />
        <StudentsGrades />
      </div>
    )
  )
}
