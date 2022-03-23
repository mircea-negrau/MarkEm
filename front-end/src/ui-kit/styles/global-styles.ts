import { createGlobalStyle } from 'styled-components'

export const GlobalStyle = createGlobalStyle`
  body {
    background: #18181E;
    background-repeat: no-repeat;
    background-attachment: fixed;
    color: #ffffff
  }

  a,
  a:hover,
  a:visited,
  a:active {
    text-decoration: none;
    color: #F7C366;
  }

  html,
  body {
    height: 100%;
  }
  p {
    margin: 0;
    padding: 0;
  }
`
