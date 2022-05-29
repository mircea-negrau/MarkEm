import { FunctionComponent, useEffect, useState } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { AppState } from '../../../state/store'
import { useParams } from 'react-router-dom'
import styled from 'styled-components'
import { FetchStatus } from '../../../utility/fetchStatus'
import {
  getCourseById,
  getCourseGroups,
  getOptionalStudents
} from '../../../state/thunks/courses'
import {
  GroupEnrichedWithStudents,
  TeacherEnrichedCourses
} from '../../../utility/types/courseTypes'
import { GroupStudentsTable } from '../../../ui-kit/Course/GroupStudentsTable'

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
// TODO:
//  1. ask Mircea for the FunctionComponent variant of this
//  2. move it to a different file
//  3. replace <EntryP> with a function component that takes 2 arguments
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

// TODO: move to a different file
const CourseGroupsWithStudentsAndGradesComponent: FunctionComponent = () => {
  const { courseId } = useParams()
  const state = useSelector((state: AppState) => state.course)

  const dispatch = useDispatch()

  const [selectedGroup, setSelectedGroup] = useState<
    GroupEnrichedWithStudents | undefined
  >(undefined)

  useEffect(() => {
    if (state.groupsStatus != FetchStatus.success && courseId) {
      dispatch(getCourseGroups(courseId))
    }
  }, [courseId, dispatch, state.groupsStatus])

  return (
    <>
      <span>Group</span>
      {state.groups && (
        <select
          onChange={event =>
            setSelectedGroup(state.groups[event.target.selectedIndex])
          }
        >
          {state.groups.length &&
            state.groups.map((group, index) => {
              return <option key={`group-${index}`}>{group.number}</option>
            })}
        </select>
      )}
      {selectedGroup && (
        <GroupStudentsTable students={selectedGroup.students} />
      )}
    </>
  )
}

// TODO: move to a different file
const OptionalStudentsWithGradesComponent: FunctionComponent = () => {
  const { courseId } = useParams()
  const state = useSelector((state: AppState) => state.course)

  const dispatch = useDispatch()

  useEffect(() => {
    if (state.studentsStatus != FetchStatus.success && courseId) {
      dispatch(getOptionalStudents(courseId))
    }
  }, [courseId, dispatch, state.studentsStatus])

  return <GroupStudentsTable students={state.optionalStudents} /> // TODO try it out
}

export const CoursePage: FunctionComponent = () => {
  const { courseId } = useParams()
  const state = useSelector((state: AppState) => state.course)
  const global = useSelector((state: AppState) => state.global)

  const dispatch = useDispatch()

  if (global.userRole != `Teacher` || courseId == undefined) {
    window.location.replace('/')
  }

  // TODO:
  //   get course type
  //    => depending on whether is optional or not call the apropriate getCourse

  useEffect(() => {
    if (state.courseStatus != FetchStatus.success && courseId) {
      // TODO: handle case for optional course, add similar method for optional course on BE
      // TODO: maybe send the GradeType (which is actually course type) from the CoursesPage
      // optional course for test0 account: http://localhost:3000/teacher/courses/7e90da60-2295-4170-b18d-7d87f71ed340
      dispatch(getCourseById(courseId))
    }
  }, [courseId, dispatch, state.courseStatus])

  if (state.course) {
    console.log(state.course, 'isOptional:', state.course.isOptional)
  }

  return (
    state.course && (
      <MainContainerDiv>
        <CourseDetails course={state.course} />
        {(state.course.isOptional && (
          <OptionalStudentsWithGradesComponent />
        )) || <CourseGroupsWithStudentsAndGradesComponent />}
      </MainContainerDiv>
    )
  )
}
