import { FunctionComponent } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { setStudentGrade } from '../../state/thunks/courses'
import { AppState } from '../../state/store'
import { CourseType } from '../../utility/types/courseTypes'

interface GradeProps {
  courseId: string
  studentId: string
  grade: number
}

export const GradeSelect: FunctionComponent<GradeProps> = props => {
  const state = useSelector((state: AppState) => state.course)
  const dispatch = useDispatch()
  return (
    <select
      defaultValue={props.grade}
      onChange={event => {
        dispatch(
          setStudentGrade({
            courseId: props.courseId,
            studentId: props.studentId,
            grade: parseInt(event.target.value),
            courseType: state.course.isOptional
              ? CourseType.OPTIONAL
              : CourseType.MANDATORY
          })
        )
      }}
    >
      {Array.from(Array(12).keys()).map((value, index) => {
        const grade = index - 1
        return (
          <option key={`option-${grade}`} value={grade}>
            {grade == -1 ? 'None' : grade}
          </option>
        )
      })}
    </select>
  )
}
