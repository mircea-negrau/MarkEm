import { FunctionComponent, useEffect, useState } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { AppState } from '../../state/store'
import { useParams } from 'react-router-dom'
import styled from 'styled-components'
import { FetchStatus } from '../../utility/fetchStatus'
import { getCourseById, getCourseGroups } from '../../state/thunks/courses'
import {
  GroupEnrichedWithStudents,
  TeacherEnrichedCourses
} from '../../utility/types/courseTypes'

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
  const state = useSelector((state: AppState) => state.course)
  const global = useSelector((state: AppState) => state.global)

  const dispatch = useDispatch()

  if (global.userRole != `Teacher` || courseId == undefined) {
    window.location.replace('/') // https://stackoverflow.com/questions/3846935/how-can-i-change-the-current-url
  }

  const [selectedGroup, setSelectedGroup] = useState<
    GroupEnrichedWithStudents | undefined
  >(undefined)

  useEffect(() => {
    if (state.courseStatus != FetchStatus.success && courseId) {
      dispatch(getCourseById(courseId))
    }
  }, [courseId, dispatch, state.courseStatus])

  useEffect(() => {
    if (state.groupsStatus != FetchStatus.success && courseId) {
      dispatch(getCourseGroups(courseId))
    }
  }, [courseId, dispatch, state.groupsStatus])

  return (
    <MainContainerDiv>
      <CourseDetails course={state.course} />
      <div id="groupsDiv">
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
        <div id="groupDiv">{selectedGroup?.number}</div>
      </div>
    </MainContainerDiv>
  )
}
