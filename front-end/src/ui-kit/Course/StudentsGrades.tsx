import { FunctionComponent, useEffect, useState } from 'react'
import { GroupEnrichedWithStudents } from '../../utility/types/courseTypes'
import { useParams } from 'react-router-dom'
import { useDispatch, useSelector } from 'react-redux'
import { AppState } from '../../state/store'
import {
  getCourseGroups,
  getOptionalStudents
} from '../../state/thunks/courses'
import { GroupStudentsTable } from './GroupStudentsTable'

const MandatoryCourseStudentsAndGrades: FunctionComponent = () => {
  const { courseId } = useParams()
  const state = useSelector((state: AppState) => state.course)

  const dispatch = useDispatch()

  const [selectedGroup, setSelectedGroup] = useState<
    GroupEnrichedWithStudents | undefined
  >(undefined)

  useEffect(() => {
    // if (state.groupsStatus != FetchStatus.success && courseId) {
    if (courseId) {
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

const OptionalCourseStudentsAndGrades: FunctionComponent = () => {
  const { courseId } = useParams()
  const state = useSelector((state: AppState) => state.course)

  const dispatch = useDispatch()

  useEffect(() => {
    // if (state.studentsStatus != FetchStatus.success && courseId) {
    if (courseId) {
      dispatch(getOptionalStudents(courseId))
    }
  }, [courseId, dispatch, state.studentsStatus])

  return <GroupStudentsTable students={state.optionalStudents} />
}

export const StudentsGrades: FunctionComponent = () => {
  const state = useSelector((state: AppState) => state.course)
  const course = state.course

  // const studentAndGrades: FunctionComponent = course.isOptional
  //   ? MandatoryCourseStudentsAndGrades
  //   : OptionalCourseStudentsAndGrades

  return (
    course && (
      <div style={{ padding: '20px' }}>
        {/*{studentAndGrades}*/}
        {/*TODO: problem on next line, the call to groups is inside MandatoryCourseStudentsAndGrades, but for optionals that shouldn't be rendered*/}
        {course.isOptional || <MandatoryCourseStudentsAndGrades />}{' '}
        {course.isOptional && <OptionalCourseStudentsAndGrades />}
        {/*{(course.isOptional && <OptionalCourseStudentsAndGrades />) || (*/}
        {/*  <MandatoryCourseStudentsAndGrades />*/}
        {/*)}*/}
      </div>
    )
  )
}
