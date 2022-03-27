import { FunctionComponent } from 'react'
import MenuIcon from '@mui/icons-material/Menu'
import FullscreenIcon from '@mui/icons-material/Fullscreen'
import NotificationsActiveOutlinedIcon from '@mui/icons-material/NotificationsActiveOutlined'
import ReactCountryFlag from 'react-country-flag'
import { useSelector } from 'react-redux'
import { AppState } from '../../state/store'
import ProfilePicture from '../../assets/dummy-profile-picture.jpg'

export const TopNavBar: FunctionComponent = () => {
  const state = useSelector((state: AppState) => state.global)
  return (
    <div
      style={{
        display: 'flex',
        width: '100%',
        height: '61px',
        position: 'fixed',
        background: 'linear-gradient(#1c212d, #1a202e)'
      }}
    >
      <a
        href="/"
        style={{
          display: 'flex',
          padding: '8px',
          minWidth: '244px',
          justifyContent: 'center',
          alignItems: 'center',
          borderRight: '1px solid #323538',
          cursor: 'pointer'
        }}
      >
        <p style={{ color: 'white', fontSize: '24px' }}>{"Mark'Em"}</p>
      </a>
      <div
        style={{
          display: 'flex',
          justifyContent: 'space-between',
          alignItems: 'center',
          width: '100%',
          paddingLeft: '27px'
        }}
      >
        <MenuIcon style={{ color: 'white', cursor: 'pointer' }} />
        <div
          style={{
            display: 'flex',
            flexDirection: 'row',
            alignItems: 'center'
          }}
        >
          <FullscreenIcon
            style={{
              color: 'white',
              height: '24px',
              width: '24px',
              paddingRight: '20px',
              cursor: 'pointer'
            }}
          />
          <NotificationsActiveOutlinedIcon
            style={{
              color: 'white',
              height: '24px',
              width: '24px',
              paddingRight: '20px',
              cursor: 'pointer'
            }}
          />
          <ReactCountryFlag
            countryCode="US"
            svg
            cdnUrl="https://cdnjs.cloudflare.com/ajax/libs/flag-icon-css/3.4.3/flags/1x1/"
            cdnSuffix="svg"
            title="US"
            style={{
              height: '16px',
              width: '23px',
              paddingRight: '20px',
              cursor: 'pointer'
            }}
          />
          <p
            style={{
              paddingRight: '20px',
              color: '#e6e6e6',
              cursor: 'pointer'
            }}
          >
            {state.firstName + ' ' + state.lastName}
          </p>
          <div
            style={{
              width: '32px',
              height: '32px',
              borderRadius: '24px',
              backgroundImage: `url(${ProfilePicture})`,
              backgroundRepeat: 'no-repeat',
              backgroundPosition: 'center center',
              backgroundSize: 'cover',
              marginRight: '25px',
              cursor: 'pointer'
            }}
          />
        </div>
      </div>
    </div>
  )
}
