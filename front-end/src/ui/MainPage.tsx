import { FunctionComponent } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { AppState } from '../state/store'
import { logout } from '../state/thunks/global'

export const MainPage: FunctionComponent = () => {
  const dispatch = useDispatch()

  const state = useSelector((state: AppState) => state.global)

  return (
    <div>
      {state.userRole == 'Teacher' && (
        <>
          <p>
            Hello {state.userRole.toLowerCase()} {state.username}
          </p>
          <button
            onClick={() => {
              dispatch(logout())
            }}
          >
            Logout
          </button>
        </>
      )}
      {state.userRole == 'Student' && (
        <>
          <p>
            You are not a teacher, {state.username}! <br />
            Nothing to show you here!
          </p>
        </>
      )}
    </div>
  )
}
