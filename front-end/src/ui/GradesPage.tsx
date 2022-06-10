import { FunctionComponent, useEffect, useState } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import styled from 'styled-components'
import { AppState } from '../state/store'
import { getAllGrades } from '../state/thunks/grades'
import { FetchStatus } from '../utility/fetchStatus'
import { timestampToDate } from '../utility/timeParse'
import {
  StudentContractGrades,
  StudentContractSemesterGrades
} from '../utility/types/gradeTypes'

const MainContainer = styled.div`
  display: flex;
  padding: 40px 25px;
  width: 100%;
  height: 100%;
`

const Contract = styled.div<{ isActive?: boolean }>`
  display: flex;
  align-items: center;
  width: 175px;
  height: 50px;
  font-size: 24px;
  justify-content: center;
  border: 1px solid white;
  background-color: ${props => (props.isActive ? 'white' : 'transparent')};
  color: ${props => (props.isActive ? 'black' : 'white')};
  cursor: pointer;
  :hover {
    background-color: ${props => (props.isActive ? 'transparent' : 'white')};
    color: ${props => (props.isActive ? 'white' : 'black')};
  }
`

const Semester = styled.div<{ isActive?: boolean }>`
  display: flex;
  flex-direction: column;
  align-items: center;
  width: 375px;
  height: 100px;
  font-size: 24px;
  justify-content: center;
  border: 1px solid white;
  background-color: ${props => (props.isActive ? 'white' : 'transparent')};
  color: ${props => (props.isActive ? 'black' : 'white')};
  cursor: pointer;
  :hover {
    background-color: ${props => (props.isActive ? 'transparent' : 'white')};
    color: ${props => (props.isActive ? 'white' : 'black')};
  }
`

const Course = styled.div`
  display: flex;
  flex-direction: column;
  background-color: lightgrey;
  color: black;
  padding: 15px;
  margin-bottom: 15px;
`

export const GradesPage: FunctionComponent = () => {
  const token = useSelector((state: AppState) => state.global.accessToken)
  const state = useSelector((state: AppState) => state.grades)

  const [activeContract, setActiveContract] =
    useState<StudentContractGrades | null>()
  const [activeSemester, setActiveSemester] =
    useState<StudentContractSemesterGrades | null>()

  const dispatch = useDispatch()

  useEffect(() => {
    if (state.enrichedContractsGradeStatus !== FetchStatus.success)
      dispatch(getAllGrades(token))
  }, [dispatch, state.enrichedContractsGradeStatus, token])

  useEffect(() => {
    if (
      state.enrichedContractsGradeStatus === FetchStatus.success &&
      activeContract == null
    ) {
      setActiveContract(state.enrichedContracts[0])
      setActiveSemester(state.enrichedContracts[0].semesters[0])
    }
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [dispatch, state.enrichedContractsGradeStatus])

  useEffect(() => {
    setActiveSemester(activeContract?.semesters[0])
  }, [activeContract])

  console.log(activeContract?.semesters[0]?.value ?? 0)

  return (
    <MainContainer>
      <div>
        {state.enrichedContracts &&
          state.enrichedContracts.map(contract => (
            <Contract
              key={`contract-${contract.id}`}
              onClick={() => setActiveContract(contract)}
              isActive={activeContract === contract}
            >
              {contract.faculty}
            </Contract>
          ))}
      </div>
      <div>
        {activeContract?.semesters.map(semester => (
          <div key={`semester-${semester.id}`}>
            <Semester
              isActive={semester === activeSemester}
              onClick={() => setActiveSemester(semester)}
            >
              <p>Semester {semester.value}</p>
              <p>
                (
                {timestampToDate(semester.yearStartDate).toLocaleDateString(
                  'default',
                  { month: 'long', year: 'numeric' }
                )}
                {' - '}
                {timestampToDate(semester.yearEndDate).toLocaleDateString(
                  'default',
                  { month: 'long', year: 'numeric' }
                )}
                )
              </p>
            </Semester>
          </div>
        ))}
      </div>
      <div style={{ paddingLeft: '50px' }}>
        {activeSemester &&
          activeSemester.courses.map((course, index) => {
            return (
              <Course key={`course-${index}`}>
                <p>Name: {course.name}</p>
                <p>Grade: {course.grade.grade}</p>
                <p>Teacher: {course.teacherName}</p>
              </Course>
            )
          })}
      </div>
    </MainContainer>
  )
}
