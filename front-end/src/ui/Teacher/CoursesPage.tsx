import { FunctionComponent, useEffect } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { Link } from 'react-router-dom'
import styled from 'styled-components'
import { AppState } from '../../state/store'
import { getCoursesByTeacher } from '../../state/thunks/courses'
import { FetchStatus } from '../../utility/fetchStatus'
import { unixSecondsToYear } from '../../utility/various'
import { TeacherEnrichedCourse } from '../../utility/types/courseTypes'

const MainContainer = styled.div`
  display: flex;
  padding: 60px;
`

const Container = styled(Link)`
  color: #96a2b4;
  display: flex;
  flex-direction: column;
  padding: 20px;
  background-color: #151a25;
  border-radius: 20px;
  height: 200px;
  margin-right: 25px;
  word-break: break-word;
  cursor: pointer;
  box-shadow: 0 0.46875rem 2.1875rem rgb(90 97 105 / 10%),
    0 0.9375rem 1.40625rem rgb(90 97 105 / 10%),
    0 0.25rem 0.53125rem rgb(90 97 105 / 12%),
    0 0.125rem 0.1875rem rgb(90 97 105 / 10%);
  :hover {
    background-color: #1a202e;
  }
`

const Name = styled.p`
  font-weight: bold;
  font-size: 24px;
  width: 325px;
  padding-bottom: 15px;
`

const Specialization = styled.p`
  font-size: 22px;
  width: 325px;
  padding-bottom: 10px;
`

export const CoursesPage: FunctionComponent = () => {
  const state = useSelector((state: AppState) => state.courses)
  const global = useSelector((state: AppState) => state.global)
  const dispatch = useDispatch()

  useEffect(() => {
    if (global.accessToken && state.coursesStatus != FetchStatus.success) {
      dispatch(getCoursesByTeacher(global.accessToken))
    }
  }, [dispatch, global.accessToken, state.coursesStatus])

  const getUrlFromCourse = (course: TeacherEnrichedCourse): string => {
    return course.isOptional
      ? `/teacher/courses/optional/${course.id}`
      : `/teacher/courses/mandatory/${course.id}`
  }

  return (
    <MainContainer>
      {state.courses && (
        <>
          {state.courses.map((course, index) => {
            return (
              <Container
                key={`course-${index}`}
                to={getUrlFromCourse(course)}
                state={state}
              >
                <Name>
                  {course.name}
                  &nbsp;({course.facultyDetails.studyLineShort})
                </Name>
                <Specialization>
                  {course.facultyDetails.specialization}&nbsp;(
                  {course.semester}/
                  {course.facultyDetails.specializationSemesters})
                </Specialization>
                <div
                  style={{
                    display: 'flex',
                    flexDirection: 'column',
                    height: '100%',
                    justifyContent: 'end',
                    alignItems: 'end',
                    paddingBottom: '15px',
                    paddingRight: '15px'
                  }}
                >
                  {course.facultyDetails.studyDegree}
                  <p style={{ fontWeight: 'bold' }}>
                    {unixSecondsToYear(course.startDate)}
                    {' - '}
                    {unixSecondsToYear(course.endDate)}
                  </p>
                </div>
              </Container>
            )
          })}
        </>
      )}
    </MainContainer>
  )
}
