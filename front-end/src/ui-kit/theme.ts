export const Theme = {
  colors: {
    background: '#18181E',
    secondaryBackground: '#272836',
    darkJungleColor: '#191F24',
    secondaryGray: '#8C8C8F',
    grayText: '#BDBDC0',
    majorelleBlue: '#5552E7',
    persianGreen: '#06ac99',
    darkGunmetal: '#192429',
    raisinBlack: '#272836',
    quickSilver: '#99b0a8',
    persianPink: '#FF7BBA',
    oldLavender: '#646476',
    neutral800: '#253355',
    neutral900: '#162246',
    lightGreen: '#98DF80',
    spaceCadet: '#333547',
    ghostWhite: '#F9F9F9',
    blackRock: '#2C2D3C',
    offWhite: '#f7f7f7',
    darkGray: '#424253',
    purple: '#7E7CF0',
    yellow: '#F7C366',
    white: '#FFFFFF',
    black: '#000000',
    green: '#00AC99',
    gray: '#808080',
    blue: '#0090C6',
    red: '#EA575C',
    yellowText: '#B5A999'
  },
  breakpoints: {
    small: '(max-width: 600px)',
    smallInverse: '(min-width: 600px)',
    medium: '(max-width: 1080px)'
  }
}

export type Theme = typeof Theme
