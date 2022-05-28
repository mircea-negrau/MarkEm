import { FunctionComponent, useEffect } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { AppState } from '../../state/store'
import { useParams } from 'react-router-dom'
import styled from 'styled-components'
import { Dashboard } from '../Dashboard'
import { FetchStatus } from '../../utility/fetchStatus'
import { getCoursesByTeacher } from '../../state/thunks/courses'
import { TeacherEnrichedCourses } from '../../utility/types/courseTypes'

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

function CourseDetails(props: { course: TeacherEnrichedCourses }) {
  return (
    <CourseDetailsDiv>
      <EntryP>
        <ValueNameSpan>Course name: </ValueNameSpan>
        {props.course.name}
      </EntryP>
      <EntryP>
        <ValueNameSpan>Course credits: </ValueNameSpan>
        {props.course.credits}
      </EntryP>
      <EntryP>
        <ValueNameSpan>Course semester: </ValueNameSpan>
        {props.course.semester}
      </EntryP>
      <EntryP>
        <ValueNameSpan>Course date: </ValueNameSpan>
        {new Date(props.course.startDate * 1000).getFullYear()}-
        {new Date(props.course.endDate * 1000).getFullYear()}
      </EntryP>
      <EntryP>
        <ValueNameSpan>Course study line: </ValueNameSpan>
        {props.course.facultyDetails.studyLine}
      </EntryP>
      <EntryP>
        <ValueNameSpan>Course study specialization: </ValueNameSpan>
        {props.course.facultyDetails.specialization}
      </EntryP>
      <EntryP>
        <ValueNameSpan>Course study degree: </ValueNameSpan>
        {props.course.facultyDetails.studyDegree}
      </EntryP>
    </CourseDetailsDiv>
  )
}

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

  // TODO #1: get the groups
  // TODO #2: map groups numbers to select options
  // TODO #3: on select change: re

  return (
    <MainContainerDiv>
      <CourseDetails course={course} />
      <div id="groupsDiv">
        <span>Group</span>
        <select
          onChange={event =>
            console.log(
              'changed to event:',
              event,
              'target:',
              event.target,
              'event.target.selectedIndex: ',
              event.target.selectedIndex
            )
          }
        >
          <option key={'option1Key'} value={'option1Value'}>
            option1
          </option>
          <option key={'option2Key'} value={'option2Value'}>
            option2
          </option>
        </select>
        <div id="groupDiv">TODO</div>
      </div>
    </MainContainerDiv>
  )
}
