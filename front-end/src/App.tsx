import React, { FunctionComponent } from 'react'
import { Routes } from 'react-router-dom'
import { Route, BrowserRouter } from 'react-router-dom'
import { LoginPage } from './pages/LoginPage'
import { MainPage } from './pages/MainPage'

const App: FunctionComponent = () => {
  return (
    <div className="App">
      <BrowserRouter>
        <Routes>
          <Route path={'/'} element={<MainPage />} />
          <Route path={'/login'} element={<LoginPage />} />
        </Routes>
      </BrowserRouter>
    </div>
  )
}

export default App
