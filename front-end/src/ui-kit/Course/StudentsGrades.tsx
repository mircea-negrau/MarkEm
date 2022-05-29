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
import { FetchStatus } from '../../utility/fetchStatus'

const MandatoryCourseStudentsAndGrades: FunctionComponent = () => {
  const state = useSelector((state: AppState) => state.course)
  const { courseId } = useParams()

  const dispatch = useDispatch()

  const [selectedGroup, setSelectedGroup] =
    useState<GroupEnrichedWithStudents | null>(null)

  useEffect(() => {
    // if (state.groupsStatus != FetchStatus.success && courseId) {
    if (courseId) {
      dispatch(getCourseGroups(courseId))
    }
  }, [dispatch, courseId, state.groupsStatus])

  useEffect(() => {
    if (state.groupsStatus === FetchStatus.success && selectedGroup == null) {
      setSelectedGroup(state.groups[0])
    }
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [state.groupsStatus])

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

  const [isReady, setIsReady] = useState(false)

  useEffect(() => {
    if (state.courseStatus === FetchStatus.success) {
      setIsReady(true)
    }
  }, [state.courseStatus])

  return (
    (isReady && (
      <div style={{ padding: '20px' }}>
        {(state.course.isOptional && <OptionalCourseStudentsAndGrades />) || (
          <MandatoryCourseStudentsAndGrades />
        )}
      </div>
    )) || <p>Loading...</p>
  )
}
