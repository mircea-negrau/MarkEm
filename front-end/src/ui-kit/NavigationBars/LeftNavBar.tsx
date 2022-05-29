import { FunctionComponent } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { AppState } from '../../state/store'
import styled from 'styled-components'
import { UserAvatar } from '../Avatars/UserAvatar'
import DashboardIcon from '@mui/icons-material/Dashboard'
import PowerSettingsNewIcon from '@mui/icons-material/PowerSettingsNew'
import { logout } from '../../state/thunks/global'
import AssignmentIcon from '@mui/icons-material/Assignment'
import SettingsIcon from '@mui/icons-material/Settings'
import MenuBookIcon from '@mui/icons-material/MenuBook'
import { useLocation } from 'react-router-dom'
import { UserType } from '../../utility/types/userTypes'

interface LeftNavBarProps {
  isActive: boolean
}

const MainContainer = styled.div<{ isActive: boolean }>`
  width: ${props => (props.isActive ? '260px' : '0px')};
  display: flex;
  position: fixed;
  margin-top: 61px;
  flex-direction: column;
  border-right: 1px solid #323538;
  height: 100vh;
  background-color: #1a202e;
  padding-top: 25px;
  box-shadow: 0 8px 10px 0 rgb(183 192 206 / 20%);
  transition: width 0.1s;
  overflow: hidden;
  z-index: 1;
`

const UserContainer = styled.div`
  display: flex;
  flex-direction: column;
  text-align: center;
  align-items: center;
  width: 100%;
`

const MenuContainer = styled.div``

const MenuHeader = styled.p`
  margin-top: 45px;
  margin-left: 28px;
  margin-bottom: 5px;
  color: #9babf1;
  font-size: 14px;
  text-transform: uppercase;
  letter-spacing: 0.5px;
  font-weight: 600;
`

const MenuItem = styled.div<{ isActive?: boolean }>`
  display: flex;
  height: 28px;
  background-color: ${props =>
    props.isActive ? 'rgba(0, 0, 0, 0.4)' : 'transparent'};
  color: #cfd8e3;
  position: relative;
  font-size: 16px;
  font-weight: 600;
  overflow: hidden;
  line-height: 2rem;
  padding: 9px 9px 9px 9px;
  margin: 8px 11px 0px 11px;
  border-radius: 0.5rem;
  align-items: center;
  cursor: pointer;
  :hover {
    background-color: ${props => (props.isActive ? '' : '#151a25')};
    transition: all 0.5s;
    transition-property: all;
    transition-duration: 0.3s;
    transition-timing-function: ease;
    transition-delay: 0s;
  }
`

const MenuItemText = styled.p`
  padding-left: 13px;
  margin-bottom: 5px;
`

export const LeftNavBar: FunctionComponent<LeftNavBarProps> = props => {
  const state = useSelector((state: AppState) => state.global)
  const dispatch = useDispatch()
  const location = useLocation()
  return (
    <MainContainer isActive={props.isActive}>
      <UserContainer>
        <UserAvatar
          profilePicture={
            state.profile.picture
              ? `data:image/png;base64,${state.profile.picture}`
              : ''
          }
          username={state.username}
          firstName={state.firstName}
          lastName={state.lastName}
        />

        <p
          onClick={() => {
            window.location.replace(`/profile/${state.username}`)
          }}
          style={{
            color: '#e6e6e6',
            marginTop: '10px',
            fontWeight: '600',
            cursor: 'pointer'
          }}
        >
          {state.firstName + ' ' + state.lastName}
        </p>
        <p
          onClick={() => {
            window.location.replace(`/profile/${state.username}`)
          }}
          style={{
            color: '#e6e6e6',
            marginTop: '3px',
            fontSize: '12px',
            cursor: 'pointer'
          }}
        >
          {state.userRole}
        </p>
      </UserContainer>

      <MenuContainer>
        <MenuHeader>Main</MenuHeader>
        <MenuItem
          isActive={location.pathname == '/'}
          onClick={() => {
            window.location.replace('/')
          }}
        >
          <DashboardIcon style={{ color: '#cfd8e3' }} />
          <MenuItemText>Dashboard</MenuItemText>
        </MenuItem>
        {state.userRole == UserType.Student && (
          <>
            <MenuItem
              isActive={location.pathname == '/contracts'}
              onClick={() => {
                window.location.replace('/contracts')
              }}
            >
              <AssignmentIcon style={{ color: '#cfd8e3' }} />
              <MenuItemText>Contracts</MenuItemText>
            </MenuItem>
            <MenuItem
              isActive={location.pathname == '/grades'}
              onClick={() => {
                window.location.replace('/grades')
              }}
            >
              <MenuBookIcon style={{ color: '#cfd8e3' }} />
              <MenuItemText>Grades</MenuItemText>
            </MenuItem>
          </>
        )}
        {state.userRole == UserType.Teacher && (
          <>
            <MenuItem
              isActive={location.pathname == '/teacher/courses'}
              onClick={() => {
                window.location.replace('/teacher/courses')
              }}
            >
              <MenuBookIcon style={{ color: '#cfd8e3' }} />
              <MenuItemText>Courses</MenuItemText>
            </MenuItem>
          </>
        )}

        {state.userRole == UserType.Admin && (
          <>
            <MenuItem
              isActive={location.pathname == '/admin/performance'}
              onClick={() => {
                window.location.replace('/admin/performance')
              }}
            >
              <MenuBookIcon style={{ color: '#cfd8e3' }} />
              <MenuItemText>Performance</MenuItemText>
            </MenuItem>
          </>
        )}
        <MenuItem
          isActive={location.pathname == '/settings'}
          onClick={() => {
            window.location.replace('/settings')
          }}
        >
          <SettingsIcon style={{ color: '#cfd8e3' }} />
          <MenuItemText>Settings</MenuItemText>
        </MenuItem>
        <MenuItem
          onClick={() => {
            dispatch(logout())
          }}
        >
          <PowerSettingsNewIcon style={{ color: '#1c6686' }} />
          <MenuItemText>Logout</MenuItemText>
        </MenuItem>
      </MenuContainer>
    </MainContainer>
  )
}
