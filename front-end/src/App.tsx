import React, { FunctionComponent } from 'react'
import { Provider } from 'react-redux'
import { ThemeProvider } from 'styled-components'
import { store } from './state/store'
import { Theme } from './ui-kit/theme'
import { GlobalStyle } from './ui-kit/styles/global-styles'
import { BrowserRouter, Routes, Route } from 'react-router-dom'
import { MainPage } from './pages/MainPage'
import { LoginPage } from './pages/LoginPage'
import { RequireAuth as Authentication } from './ui/Authentication/AuthComponent'

const App: FunctionComponent = () => {
  return (
    <Provider store={store}>
      <ThemeProvider theme={Theme}>
        <GlobalStyle />
        <BrowserRouter>
          <Routes>
            <Route
              path={'/'}
              element={
                <Authentication>
                  <MainPage />
                </Authentication>
              }
            />
            <Route path={'/login'} element={<LoginPage />} />
          </Routes>
        </BrowserRouter>
      </ThemeProvider>
    </Provider>
  )
}

export default App
