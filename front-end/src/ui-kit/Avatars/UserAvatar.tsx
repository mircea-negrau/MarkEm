import { FunctionComponent } from 'react'
import { useNavigate } from 'react-router-dom'
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
  cursor: pointer;
`

const AvatarPlaceholder = styled.div`
  width: 71px;
  height: 71px;
  border-radius: 15%;
  border: 2px solid white;
  cursor: pointer;
  background-color: darkcyan;
  color: black;
  font-size: 28px;
  display: flex;
  font-weight: 600;
  justify-content: center;
  align-items: center;
  user-select: none;
`

export const UserAvatar: FunctionComponent<{
  profilePicture: string
  username: string
  firstName: string
  lastName: string
}> = props => {
  const navigate = useNavigate()
  return (
    <>
      {(props.profilePicture && (
        <Avatar
          onClick={() => {
            if (props.username) navigate(`/profile/${props.username}`)
          }}
          image={props.profilePicture}
        />
      )) || (
        <AvatarPlaceholder
          onClick={() => {
            if (props.username) navigate(`/profile/${props.username}`)
          }}
        >
          <p>
            {props.firstName.slice(0, 1)}
            {props.lastName.slice(0, 1)}
          </p>
        </AvatarPlaceholder>
      )}
    </>
  )
}
