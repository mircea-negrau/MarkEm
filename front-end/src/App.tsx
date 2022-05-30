import React, { FunctionComponent } from 'react'
import { GlobalStyle } from './ui-kit/styles/global-styles'
import { BrowserRouter, Route, Routes } from 'react-router-dom'
import { LoginPage } from './ui/Auth/LoginPage'
import { AuthComponent, AuthTeacher } from './ui/Auth/AuthComponent'
import { Dashboard } from './ui/Everyone/Dashboard'
import { Contracts } from './ui/ContractsPage'
import { Settings } from './ui/Everyone/Settings'

import { RegisterPage } from './ui/Auth/RegisterPage'
import { ProfilePage } from './ui/Everyone/ProfilePage'
import { ErrorPage } from './ui/ErrorPage'
import { CoursesPage } from './ui/Teacher/CoursesPage'
import { EditContractPage } from './ui/EditContractPage'
import { GradesPage } from './ui/GradesPage'
import { PerformancePage } from './ui/PerformancePage'
import { CoursePage } from './ui/Teacher/CoursePage'
import { ResultsPage } from './ui/ChiefOfDepartment/ResultsPage'
import { CourseType } from './utility/types/courseTypes'
import { OptionalsPage } from './ui/Teacher/OptionalsPage'
import { ChiefOfDepartmentOptionalsPage } from './ui/ChiefOfDepartment/OptionalsPage'

const App: FunctionComponent = () => {
  return (
    <>
      <GlobalStyle />
      <BrowserRouter>
        <Routes>
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
              <AuthTeacher>
                <CoursesPage />
              </AuthTeacher>
            }
          />
          <Route
            path={'/teacher/courses/mandatory/:courseId'}
            element={
              <AuthTeacher>
                <CoursePage courseType={CourseType.MANDATORY} />
              </AuthTeacher>
            }
          />
          <Route
            path={'/teacher/courses/optional/:courseId'}
            element={
              <AuthTeacher>
                <CoursePage courseType={CourseType.OPTIONAL} />
              </AuthTeacher>
            }
          />
          <Route
            path={'/teacher/optionals'}
            element={
              <AuthTeacher>
                <OptionalsPage />
              </AuthTeacher>
            }
          />
          <Route
            path={'/student/course/:courseId'}
            element={
              <AuthComponent>
                <p>aici era inainte un CoursePage FunctionComponent</p>
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
          <Route
            path={'/chief/results'}
            element={
              <AuthTeacher>
                <ResultsPage />
              </AuthTeacher>
            }
          />
          <Route
            path={'/'}
            element={
              <AuthComponent>
                <Dashboard />
              </AuthComponent>
            }
          />
        </Routes>
      </BrowserRouter>
    </>
  )
}

export default App
