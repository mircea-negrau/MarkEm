import { FunctionComponent } from 'react'
import { StudentWithGrade } from '../../utility/types/courseTypes'
import { useSelector } from 'react-redux'
import { AppState } from '../../state/store'
import { GradeSelect } from './GradeSelect'

interface StudentsWithGradeProps {
  students: StudentWithGrade[]
}

export const GroupStudentsTable: FunctionComponent<
  StudentsWithGradeProps
> = props => {
  const state = useSelector((state: AppState) => state.course)
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
                <GradeSelect
                  courseId={state.course.id}
                  grade={student.grade}
                  studentId={student.id}
                />
              </td>
            </tr>
          )
        })}
      </tbody>
    </table>
  )
}
