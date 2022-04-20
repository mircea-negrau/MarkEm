import { FunctionComponent, useEffect, useState } from 'react'
import styled from 'styled-components'
import { getAllContracts } from '../state/thunks/contracts'
import { useDispatch, useSelector } from 'react-redux'
import { AppState } from '../state/store'
import { contractActions } from '../state/slices/contracts'
import { StudyContractType } from '../utility/types/studentTypes'

const MainContainer = styled.div`
  display: flex;
  flex-direction: column;
  padding: 40px 25px;
  width: 100%;
  height: 100%;
`
export default function Contract({ contract }) {
  return (
    <div
      style={{
        width: '300px',
        border: '5px solid green',
        borderColor: '#96a2b4',
        padding: '50px',
        borderRadius: '25px'
      }}
    >
      {contract.id}
    </div>
  )
}

export const Contracts: FunctionComponent = () => {
  const token = useSelector((state: AppState) => state.global.accessToken)
  const contracts = useSelector((state: AppState) => state.contract.contracts)
  //  const [state, setState] = useState([])
  const dispatch = useDispatch()

  useEffect(() => {
    dispatch(getAllContracts(token))
  }, [dispatch, token])

  return (
    <MainContainer>
      Contracts
      <br />
      <br />
      {contracts.map(contract => (
        <p key={contract.id}>
          {<Contract contract={contract} />}
          <br />
          <br />
        </p>
      ))}
    </MainContainer>
  )
}
