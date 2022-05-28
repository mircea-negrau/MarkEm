import { FunctionComponent, useState } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { number } from 'yup'
import { setStudentGrade } from '../../state/thunks/courses'
import { AppState } from '../../state/store'
import { GradeType } from '../../utility/types/gradeTypes'

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
      defaultValue={props.grade} // TODO: fix this (see issue #!118
      onChange={event => {
        console.log(
          `changed selected grade to`,
          event.target.selectedOptions[0].value
        )
        dispatch(
          setStudentGrade({
            courseId: props.courseId,
            studentId: props.studentId,
            grade: Number(event.target.selectedOptions[0].value),
            gradeType: state.course.isOptional
              ? GradeType.OPTIONAL
              : GradeType.MANDATORY
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
