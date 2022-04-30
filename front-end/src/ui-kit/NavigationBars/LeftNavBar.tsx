import { FunctionComponent } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { AppState } from '../../state/store'
import ProfilePicture from '../../assets/dummy-profile-picture.jpg'
import styled from 'styled-components'
import { UserAvatar } from '../Avatars/UserAvatar'
import DashboardIcon from '@mui/icons-material/Dashboard'
import PowerSettingsNewIcon from '@mui/icons-material/PowerSettingsNew'
import { logout } from '../../state/thunks/global'
import AssignmentIcon from '@mui/icons-material/Assignment'
import SettingsIcon from '@mui/icons-material/Settings'
import MenuBookIcon from '@mui/icons-material/MenuBook'
import CalendarTodayIcon from '@mui/icons-material/CalendarToday'
import { useLocation } from 'react-router-dom'

const MainContainer = styled.div`
  display: flex;
  position: fixed;
  margin-top: 61px;
  flex-direction: column;
  min-width: 260px;
  border-right: 1px solid #323538;
  height: 100vh;
  background-color: #1a202e;
  padding-top: 25px;
  box-shadow: 0 8px 10px 0 rgb(183 192 206 / 20%);
  transition: all 0.5s;
  transition-property: all;
  transition-duration: 0.5s;
  transition-timing-function: ease;
  transition-delay: 0s;
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

export const LeftNavBar: FunctionComponent = () => {
  const state = useSelector((state: AppState) => state.global)
  const dispatch = useDispatch()
  const location = useLocation()

  return (
    <MainContainer>
      <UserContainer>
        <UserAvatar profilePicture={ProfilePicture} username={state.username} />

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
        {state.userRole == 'Student' && (
          <>
            <MenuItem
              isActive={location.pathname == '/time-table'}
              onClick={() => {
                window.location.replace('/time-table')
              }}
            >
              <CalendarTodayIcon style={{ color: '#cfd8e3' }} />
              <MenuItemText>Time Table</MenuItemText>
            </MenuItem>
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
              isActive={location.pathname == '/homework'}
              onClick={() => {
                window.location.replace('/homework')
              }}
            >
              <MenuBookIcon style={{ color: '#cfd8e3' }} />
              <MenuItemText>Homework</MenuItemText>
            </MenuItem>
          </>
        )}
        {state.userRole == 'Teacher' && (
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
