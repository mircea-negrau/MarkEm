export interface Profile {
  id: string
  role: string
  username: string
  firstName: string
  lastName: string
  picture?: Uint8Array
  about?: string
}
