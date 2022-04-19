import { FunctionComponent, useEffect, useState } from 'react'
import styled from 'styled-components'
import { GetAllContracts } from '../state/thunks/global'
import { useDispatch, useSelector } from 'react-redux'
import { AppState } from '../state/store'

const MainContainer = styled.div`
  display: flex;
  flex-direction: column;
  padding: 40px 25px;
  width: 100%;
  height: 100%;
`

export const Contracts: FunctionComponent = () => {
  const dispatch = useDispatch()
  const state = useSelector((state: AppState) => state.global)
  useEffect(() => {
    dispatch(GetAllContracts())
  })
  return (
    <MainContainer>
      <p style={{ fontSize: '18px', fontWeight: '600', color: '#a5abb1' }}>
        Contracts
        <br />
        <br />
        <div
          style={{
            width: '200px',
            maxWidth: '200px',
            border: '5px solid green',
            borderColor: '#96a2b4',
            padding: '50px',
            borderRadius: '25px'
          }}
        >
          object
        </div>
      </p>
    </MainContainer>
  )
}
