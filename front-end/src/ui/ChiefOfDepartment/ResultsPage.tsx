import { FunctionComponent, useEffect } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { AppState } from '../../state/store'
import { getChiefResults } from '../../state/thunks/chief'
import { FetchStatus } from '../../utility/fetchStatus'

export const ResultsPage: FunctionComponent = () => {
  const global = useSelector((state: AppState) => state.global)
  const state = useSelector((state: AppState) => state.chiefResults)
  const dispatch = useDispatch()

  useEffect(() => {
    if (state.performancesStatus !== FetchStatus.success) {
      dispatch(getChiefResults(global.userId))
    }
  }, [dispatch, global.userId, state.performancesStatus])

  return (
    <div>
      <p>{state.performances[0]?.firstName}</p>
    </div>
  )
}
