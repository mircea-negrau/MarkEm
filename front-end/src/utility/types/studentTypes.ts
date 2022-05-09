export interface Faculty {
  id: string
  name: string
}

export interface Degree {
  id: string
  name: string
}

export interface Specialisation {
  id: string
  name: string
}

export interface FacultyDetails {
  faculties: Faculty[]
  degrees: Degree[]
}
