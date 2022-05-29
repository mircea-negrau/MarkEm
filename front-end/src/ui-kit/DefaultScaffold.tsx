import { FunctionComponent, useState } from 'react'
import styled from 'styled-components'
import { TopNavBar } from './NavigationBars/TopNavBar'
import { LeftNavBar } from './NavigationBars/LeftNavBar'

const Scaffold = styled.div`
  display: flex;
  padding-top: 61px;
  min-height: calc(100vh - 61px);
  margin-left: 5%;
  padding-right: 5%;
`

const Layout = styled.div`
  position: absolute;
  width: 100vw;
  min-height: 100vh;
  background-color: black;
  opacity: 0.5;
`

export const DefaultScaffold: FunctionComponent = props => {
  const [showLeftNavBar, setShowLeftNavBar] = useState(false)
  return (
    <>
      <TopNavBar
        dockerAction={() => {
          setShowLeftNavBar(showLeftNavBar => !showLeftNavBar)
        }}
      />
      <LeftNavBar isActive={showLeftNavBar} />
      {showLeftNavBar && (
        <Layout
          onClick={() => {
            setShowLeftNavBar(false)
          }}
        />
      )}
      <Scaffold>{props.children}</Scaffold>
    </>
  )
}
