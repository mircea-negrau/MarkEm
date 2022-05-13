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

import { RegisterPage } from './ui/RegisterPage'
import { ProfilePage } from './ui/ProfilePage'
import { ErrorPage } from './ui/ErrorPage'
import { CoursesPage } from './ui/CoursesPage'
import { CoursePage } from './ui/CoursePage'
import { EditContractPage } from './ui/EditContractPage'
import { GradesPage } from './ui/GradesPage'
import { PerformancePage } from './ui/PerformancePage'

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
            path={'contracts/:contractId'}
            element={
              <AuthComponent>
                <EditContractPage />
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
          <Route
            path={'/profile/:username'}
            element={
              <AuthComponent>
                <ProfilePage />
              </AuthComponent>
            }
          />
          <Route
            path={'/teacher/courses'}
            element={
              <AuthComponent>
                <CoursesPage />
              </AuthComponent>
            }
          />
          <Route
            path={'/teacher/course/:courseId'}
            element={
              <AuthComponent>
                <CoursePage />
              </AuthComponent>
            }
          />
          <Route
            path={'/student/course/:courseId'}
            element={
              <AuthComponent>
                <CoursePage />
              </AuthComponent>
            }
          />

          <Route
            path={'/grades'}
            element={
              <AuthComponent>
                <GradesPage />
              </AuthComponent>
            }
          />

          <Route
            path={'/admin/performance'}
            element={
              <AuthComponent>
                <PerformancePage />
              </AuthComponent>
            }
          />
          <Route path={'/error'} element={<ErrorPage />} />
          <Route path={'/login'} element={<LoginPage />} />

          <Route path={'/register'} element={<RegisterPage />} />
        </Routes>
      </BrowserRouter>
    </>
  )
}

export default App
