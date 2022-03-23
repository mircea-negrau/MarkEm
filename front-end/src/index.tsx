import ReactDOM from 'react-dom'
import './index.css'
import App from './App'
import { Provider } from 'react-redux'
import { store } from './state/store'
import { Theme } from './ui-kit/theme'
import { ThemeProvider } from 'styled-components'

ReactDOM.render(
  <Provider store={store}>
    <ThemeProvider theme={Theme}>
      <App />
    </ThemeProvider>
  </Provider>,
  document.getElementById('root')
)
