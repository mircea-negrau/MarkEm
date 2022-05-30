import { FunctionComponent, useEffect } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { AppState } from '../../state/store'
import {
  getChiefCourseResults,
  getChiefTeacherResults
} from '../../state/thunks/chief'
import { FetchStatus } from '../../utility/fetchStatus'

export const ResultsPage: FunctionComponent = () => {
  const global = useSelector((state: AppState) => state.global)
  const state = useSelector((state: AppState) => state.chiefResults)
  const dispatch = useDispatch()

  useEffect(() => {
    const a = async () => {
      dispatch(getChiefCourseResults(global.userId))
    }
    const b = async () => {
      dispatch(getChiefTeacherResults(global.userId))
    }

    if (
      state.teacherPerformancesStatus !== FetchStatus.success ||
      state.coursePerformancesStatus !== FetchStatus.success
    ) {
      Promise.resolve(a()).then(() => b())
    }
  }, [
    dispatch,
    global.userId,
    state.coursePerformancesStatus,
    state.teacherPerformancesStatus
  ])

  return (
    <div style={{ display: 'flex', paddingTop: '75px' }}>
      <div style={{ paddingRight: '50px' }}>
        {state.teacherPerformances
          .filter(x => x.teacherPerformance)
          .map((performance, index) => (
            <div key={`performance-teacher-${performance.teacherId}`}>
              <p>
                {index + 1}. {performance.teacherFirstName}{' '}
                {performance.teacherLastName}{' '}
                {performance.teacherPerformance
                  ? performance.teacherPerformance.toPrecision(3)
                  : 'NaN'}
              </p>
            </div>
          ))}
      </div>
      <div>
        {state.coursePerformances
          .filter(x => x.coursePerformance)
          .map((performance, index) => (
            <div key={`performance-course-${performance.courseId}`}>
              <p>
                {index + 1}. {performance.courseName}{' '}
                {performance.coursePerformance
                  ? performance.coursePerformance.toPrecision(3)
                  : 'NaN'}
              </p>
            </div>
          ))}
      </div>
    </div>
  )
}
