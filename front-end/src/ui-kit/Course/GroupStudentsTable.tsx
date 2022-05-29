import { FunctionComponent } from 'react'
import { CourseType, StudentWithGrade } from '../../utility/types/courseTypes'
import { useDispatch, useSelector } from 'react-redux'
import { AppState } from '../../state/store'
import { GradeSelect } from './GradeSelect'
import { setStudentGrade } from '../../state/thunks/courses'

export const GroupStudentsTable: FunctionComponent<{
  students: StudentWithGrade[]
}> = props => {
  const state = useSelector((state: AppState) => state.course)
  const dispatch = useDispatch()
  return (
    <table>
      <thead>
        <tr>
          <th>Nr</th>
          <th>Last Name</th>
          <th>First Name</th>
          <th>Grade</th>
        </tr>
      </thead>
      <tbody>
        {props.students.map((student, index) => {
          return (
            <tr key={`student-${index}`}>
              <td>{index + 1}</td>
              <td>{student.lastName}</td>
              <td>{student.firstName}</td>
              <td>
                <select
                  value={student.grade}
                  onChange={async event => {
                    Promise.resolve(
                      dispatch(
                        setStudentGrade({
                          courseId: state.course.id,
                          studentId: student.id,
                          grade: parseInt(event.target.value),
                          courseType: state.course.isOptional
                            ? CourseType.OPTIONAL
                            : CourseType.MANDATORY
                        })
                      )
                    ).then(() => {
                      window.location.reload()
                    })
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
                {/* <GradeSelect
                  courseId={state.course.id}
                  grade={student.grade}
                  studentId={student.id}
                /> */}
              </td>
            </tr>
          )
        })}
      </tbody>
    </table>
  )
}
