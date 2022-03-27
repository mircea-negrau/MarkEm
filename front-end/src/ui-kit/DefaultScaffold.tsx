import { FunctionComponent } from 'react'
import styled from 'styled-components'
import { TopNavBar } from './NavigationBars/TopNavBar'
import { LeftNavBar } from './NavigationBars/LeftNavBar'

const Scaffold = styled.div`
  display: flex;
  padding-top: 61px;
  padding-left: 261px;
  width: calc(100% - 261px);
  min-height: calc(100vh - 61px);
`

export const DefaultScaffold: FunctionComponent = props => {
  return (
    <>
      <TopNavBar />
      <LeftNavBar />
      <Scaffold>{props.children}</Scaffold>
    </>
  )
}
