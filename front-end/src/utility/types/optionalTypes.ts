export interface TeacherOptional {
  id: string
  name: string
  specialization: string
  semester: number
  isProposed: boolean
  isApproved: boolean
}

export function getTeacherOptionalWithNewIsProposedValue(
  selectedProposedOptional: TeacherOptional,
  isProposed: boolean
) {
  return {
    id: selectedProposedOptional.id,
    name: selectedProposedOptional.name,
    specialization: selectedProposedOptional.specialization,
    semester: selectedProposedOptional.semester,
    isProposed: isProposed,
    isApproved: selectedProposedOptional.isApproved
  }
}
