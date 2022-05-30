import { FunctionComponent, useEffect, useState } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import styled from 'styled-components'
import { AppState } from '../../state/store'
import { getChiefCoursesByTeacher } from '../../state/thunks/chiefOfDepartment'

const OptionalContainer = styled.div`
  border: 1px solid green;
  padding: 40px;
  background: #1b1c1e;
  width: 50%;
  height: auto;
`
const RedOptionalContainer = styled.div`
  border: 1px solid red;
  padding: 40px;
  background: #1b1c1e;
  width: 50%;
  height: auto;
`

const MainContainer = styled.div`
  padding: 40px 25px;
  width: 100vw;
  height: 100vh;
`

export const TeacherDisciplinesPage: FunctionComponent = () => {
  const dispatch = useDispatch()
  const state = useSelector((state: AppState) => state.chiefOfDepartment)
  const [selectedTeacher, setSelectedTeacher] = useState('')

  useEffect(() => {
    dispatch(getChiefCoursesByTeacher())
  }, [dispatch])

  return (
    <MainContainer>
      <div style={{ width: '75%', float: 'left' }}>
        {state.teachers.chiefTeachersWithCoursesInfoList.map(teacher => (
          <div key={teacher.teacherId}>
            <RedOptionalContainer
              onClick={() => {
                setSelectedTeacher(teacher.teacherId)
              }}
            >
              <p>
                Teacher name : {teacher.teacherName} <br />
              </p>
              {teacher.chiefTeacherCoursesInfo.map(course => (
                <OptionalContainer key={course.name}>
                  <p>Course name : {course.name}</p> <br />
                  <p>Course specialization : {course.specialization}</p> <br />
                  <p>Course year : {course.year}</p> <br />
                  <p>Course semester : {course.semester}</p> <br />
                  <p>Course credits : {course.credits}</p> <br />
                </OptionalContainer>
              ))}
            </RedOptionalContainer>
            <br /> <br />
          </div>
        ))}
      </div>
      <div style={{ width: '25%', float: 'right' }} />
    </MainContainer>
  )
}
