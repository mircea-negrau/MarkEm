import React, { FunctionComponent } from 'react'
import { GlobalStyle } from './ui-kit/styles/global-styles'
import { BrowserRouter, Routes, Route } from 'react-router-dom'
import { LoginPage } from './ui/LoginPage'
import { AuthComponent } from './ui/Authentication/AuthComponent'
import { MainPage } from './ui/MainPage'

const App: FunctionComponent = () => {
  return (
    <>
      <GlobalStyle />
      <BrowserRouter>
        <Routes>
          <Route
            path={'/'}
            element={
              <AuthComponent>
                <MainPage />
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
