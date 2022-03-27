import { FunctionComponent } from 'react'
import styled from 'styled-components'

const Avatar = styled.div<{ image: string }>`
  width: 71px;
  height: 71px;
  background-image: ${({ image }) => `url(${image})`};
  background-repeat: no-repeat;
  background-position: center center;
  background-size: cover;
  border-radius: 15%;
  border: 2px solid white;
`

export const UserAvatar: FunctionComponent<{
  profilePicture: string
}> = props => <Avatar image={props.profilePicture} />
