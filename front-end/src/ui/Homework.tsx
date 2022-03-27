import { FunctionComponent } from 'react'
import styled from 'styled-components'

const MainContainer = styled.div`
  display: flex;
  flex-direction: column;
  padding: 40px 25px;
  width: 100%;
  height: 100%;
`

export const Homework: FunctionComponent = () => {
  return (
    <MainContainer>
      <p style={{ fontSize: '18px', fontWeight: '600', color: '#a5abb1' }}>
        Homework
      </p>
    </MainContainer>
  )
}
