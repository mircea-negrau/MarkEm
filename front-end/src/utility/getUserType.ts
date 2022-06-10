import { UserType } from './types/userTypes'

export const getUserType = (userType: string): UserType => {
  switch (userType) {
    case 'Student':
      return UserType.Student
    case 'Teacher':
      return UserType.Teacher
    case 'Admin':
      return UserType.Admin
    default:
      return UserType.Guest
  }
}
