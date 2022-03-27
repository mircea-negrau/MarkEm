import { FunctionComponent } from 'react'
import { useSelector } from 'react-redux'
import styled from 'styled-components'
import { AppState } from '../state/store'
import WelcomeImage from '../assets/welcome.png'

const MainContainer = styled.div`
  display: flex;
  flex-direction: column;
  padding: 40px 25px;
  width: 100%;
  height: 100%;
`

const MainContent = styled.div`
  display: flex;
  flex-direction: column;
  padding-top: 45px;
  width: 100%;
  height: 100%;
`

const Card = styled.div`
  display: flex;
  width: 100%;
  height: 303px;
  background-color: #1a202e;
  border-radius: 10px;
  box-shadow: 0 0.46875rem 2.1875rem rgb(90 97 105 / 10%),
    0 0.9375rem 1.40625rem rgb(90 97 105 / 10%),
    0 0.25rem 0.53125rem rgb(90 97 105 / 12%),
    0 0.125rem 0.1875rem rgb(90 97 105 / 10%);
`

export const Dashboard: FunctionComponent = () => {
  const state = useSelector((state: AppState) => state.global)

  return (
    <MainContainer>
      <p style={{ fontSize: '18px', fontWeight: '600', color: '#a5abb1' }}>
        Dashboard
      </p>
      <MainContent>
        <Card style={{ alignItems: 'center' }}>
          <img src={WelcomeImage} width="506px" style={{ minWidth: '506px' }} />
          <div
            style={{
              display: 'flex',
              flexDirection: 'column',
              paddingLeft: '30px',
              paddingRight: '50px'
            }}
          >
            <p
              style={{
                fontSize: '20px',
                fontWeight: '700'
              }}
            >
              Welcome back
            </p>
            <p
              style={{ color: '#0d6efd', fontSize: '30px', fontWeight: '700' }}
            >
              {state.firstName + ' ' + state.lastName}!
            </p>
            <p
              style={{
                fontSize: '18px',
                wordWrap: 'break-word',
                marginTop: '10px',
                lineHeight: '24px'
              }}
            >
              Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam
              convallis ante tristique nulla feugiat, eu ultricies purus
              scelerisque. Aliquam erat volutpat. Donec enim urna, mollis a
              venenatis malesuada, tempus at libero. Proin quis justo nec mauris
              rhoncus posuere eget sed lectus. Sed sed nibh eget sem euismod
              bibendum.
            </p>
          </div>
        </Card>
      </MainContent>
    </MainContainer>
  )
}
