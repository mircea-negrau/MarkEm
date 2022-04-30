import { FunctionComponent, useState } from 'react'
import styled from 'styled-components'
import { TopNavBar } from './NavigationBars/TopNavBar'
import { LeftNavBar } from './NavigationBars/LeftNavBar'

const Scaffold = styled.div`
  display: flex;
  padding-top: 61px;
  min-height: calc(100vh - 61px);
`

export const DefaultScaffold: FunctionComponent = props => {
  const [showLeftNavBar, setShowLeftNavBar] = useState(false)
  return (
    <>
      <TopNavBar
        dockerAction={() => {
          setShowLeftNavBar(!showLeftNavBar)
        }}
      />
      {showLeftNavBar && <LeftNavBar />}
      <Scaffold>{props.children}</Scaffold>
    </>
  )
}
