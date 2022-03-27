import React, { FunctionComponent } from 'react'
import { GlobalStyle } from './ui-kit/styles/global-styles'
import { BrowserRouter, Routes, Route } from 'react-router-dom'
import { LoginPage } from './ui/LoginPage'
import { AuthComponent } from './ui/Authentication/AuthComponent'
import { Dashboard } from './ui/Dashboard'
import { TimeTable } from './ui/TimeTable'
import { Contracts } from './ui/Contracts'
import { Homework } from './ui/Homework'
import { Settings } from './ui/Settings'

const App: FunctionComponent = () => {
  return (
    <>
      <GlobalStyle />
      <BrowserRouter>
        <Routes>
          <Route
            index
            element={
              <AuthComponent>
                <Dashboard />
              </AuthComponent>
            }
          />
          <Route
            path={'/time-table'}
            element={
              <AuthComponent>
                <TimeTable />
              </AuthComponent>
            }
          />
          <Route
            path={'/contracts'}
            element={
              <AuthComponent>
                <Contracts />
              </AuthComponent>
            }
          />
          <Route
            path={'/homework'}
            element={
              <AuthComponent>
                <Homework />
              </AuthComponent>
            }
          />
          <Route
            path={'/settings'}
            element={
              <AuthComponent>
                <Settings />
              </AuthComponent>
            }
          />
          <Route path={'/login'} element={<LoginPage />} />
        </Routes>
      </BrowserRouter>
    </>
  )
}

export default App
