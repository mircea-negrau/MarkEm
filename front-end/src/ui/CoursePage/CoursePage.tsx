import { FunctionComponent, useEffect } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { AppState } from '../../state/store'
import { useParams } from 'react-router-dom'
import styled from 'styled-components'
import { Dashboard } from '../Dashboard'
import { FetchStatus } from '../../utility/fetchStatus'
import { getCoursesByTeacher } from '../../state/thunks/courses'

const MainContainerDiv = styled.div`
  padding: 20px;
`

const EntryP = styled.p`
  font-size: 24px;
`

const ValueNameSpan = styled.span`
  padding: 5px;
  font-weight: bold;
`

const CourseDetailsDiv = styled.div`
  padding: 5px;
`

export const CoursePage: FunctionComponent = () => {
  const { courseId } = useParams()
  const state = useSelector((state: AppState) => state.courses)
  const global = useSelector((state: AppState) => state.global)

  const dispatch = useDispatch()

  useEffect(() => {
    if (global.accessToken && state.coursesStatus != FetchStatus.success) {
      dispatch(getCoursesByTeacher(global.accessToken))
    }
  }, [dispatch, global.accessToken, state.coursesStatus])

  if (global.userRole != `Teacher`) {
    alert(`Only teachers authorized!`)
    window.location.pathname = '/' // https://stackoverflow.com/questions/3846935/how-can-i-change-the-current-url
    return <Dashboard />
  }

  const course = state.courses.find(value => value.id == courseId)
  console.log('Course by id is', course)

  if (course == null) {
    alert(`Course with id ${courseId} not found`)
    window.location.pathname = '/teacher/courses'
    return <div>John Cena</div>
    // return <CoursesPage />
    // return <CoursesPage to={'/'}></CoursesPage>
  }

  // const CourseDetails = () => (
  //   <CourseDetailsDiv>
  //     <Formik
  //       initialValues={{
  //         name: course.name,
  //         credits: course.credits,
  //         semester: course.semester
  //       }}
  //       onSubmit={values => {
  //         console.log(`Submitted ${values}`)
  //       }}
  //       render={() => {
  //         return <form>
  //           <label>Course name: </label>
  //           <input>
  //         </form>
  //       }}
  //     >
  //       {({ values }) => <form onSubmit={} />}
  //     </Formik>
  //   </CourseDetailsDiv>
  // )

  return (
    <MainContainerDiv>
      <CourseDetailsDiv>
        <EntryP>
          <ValueNameSpan>Course name: </ValueNameSpan>
          {course.name}
        </EntryP>
        <EntryP>
          <ValueNameSpan>Course credits: </ValueNameSpan>
          {course.credits}
        </EntryP>
        <EntryP>
          <ValueNameSpan>Course semester: </ValueNameSpan>
          {course.semester}
        </EntryP>
        <EntryP>
          <ValueNameSpan>Course date: </ValueNameSpan>
          {new Date(course.startDate * 1000).getFullYear()}-
          {new Date(course.endDate * 1000).getFullYear()}
        </EntryP>
        <EntryP>
          <ValueNameSpan>Course study line: </ValueNameSpan>
          {course.facultyDetails.studyLine}
        </EntryP>
        <EntryP>
          <ValueNameSpan>Course study specialization: </ValueNameSpan>
          {course.facultyDetails.specialization}
        </EntryP>
        <EntryP>
          <ValueNameSpan>Course study degree: </ValueNameSpan>
          {course.facultyDetails.studyDegree}
        </EntryP>
      </CourseDetailsDiv>
    </MainContainerDiv>
  )
}
