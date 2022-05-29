import { Button } from '@mui/material'
import { FunctionComponent, useEffect, useState } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { useParams } from 'react-router-dom'
import styled from 'styled-components'
import { AppState } from '../state/store'
import { getSemesterContracts } from '../state/thunks/contracts'
import { getCoursesNamesByContract } from '../state/thunks/courses'
import {
  getOptionalCoursesBySemesterContract,
  setOptionalCoursesPreferences
} from '../state/thunks/optionalCourses'
import { FetchStatus } from '../utility/fetchStatus'
import { capitalizeFirstLetter } from '../utility/stringParse'
import { SemesterContract } from '../utility/types/contractTypes'

const MainContainer = styled.div`
  display: flex;
  justify-content: space-between;
  padding: 40px 0px;
  width: calc(100%);
  height: calc(100% - 50px);
`

const LeftContainer = styled.div`
  display: flex;
  flex-direction: column;
  max-width: 40%;
  height: auto;
`

const CentralContainer = styled.div`
  width: 40%;
  height: auto;
`

const RightContainer = styled.div`
  display: flex;
  flex-direction: column;
  max-width: 20%;
  height: auto;
`

const SemesterWrapper = styled.div<{ isActive?: boolean }>`
  width: 150px;
  border: 1px solid #96a2b4;
  padding: 15px;
  margin-bottom: 15px;
  border-radius: 5px;
  cursor: pointer;
  ${props => (props.isActive ? 'background: #d6deea;' : '')}
  ${props => (props.isActive ? 'color: black;' : '')}
`

const Course = styled.div`
  color: #96a2b4;
  float: left;
  padding: 20px;
  width: 150px;
  background-color: #151a25;
  border-radius: 20px;
  height: auto;
  margin: 5px;
  word-break: break-word;
  cursor: pointer;
  box-shadow: 0 0.46875rem 2.1875rem rgb(90 97 105 / 10%),
    0 0.9375rem 1.40625rem rgb(90 97 105 / 10%),
    0 0.25rem 0.53125rem rgb(90 97 105 / 12%),
    0 0.125rem 0.1875rem rgb(90 97 105 / 10%);
  :hover {
    background-color: #1a202e;
  }
`

export const EditContractPage: FunctionComponent = () => {
  const { contractId } = useParams()
  const dispatch = useDispatch()
  const courses = useSelector((state: AppState) => state.courses.coursesNames)
  const contracts = useSelector((state: AppState) => state.contracts)
  const optionalCourses = useSelector(
    (state: AppState) => state.optionalCourses.courses
  )
  // const [optionalList, setOptionalList] = useState(optionalCourses)
  // const [bringElementDown, setBringElementDown] = useState(false)
  // const [bringElementUp, setBringElementUp] = useState(false)
  // const [preferences, setPreferences] = useState(false)
  // const [selectedCourse, setSelectedCourse] = useState('')
  const [selectedSemesterContract, setSelectedSemesterContract] =
    useState<SemesterContract | null>()

  useEffect(() => {
    if (contractId != undefined) {
      dispatch(getSemesterContracts(contractId))
      dispatch(getCoursesNamesByContract(contractId))
    }
  }, [contractId, dispatch])

  useEffect(() => {
    if (
      contracts.semesterContractsStatus === FetchStatus.success &&
      selectedSemesterContract == null
    ) {
      setSelectedSemesterContract(contracts.semesterContracts[0])
    }
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [contracts.semesterContracts, contracts.semesterContractsStatus])

  // useEffect(() => {
  //   if (selectedSemesterContract != undefined) {
  //     dispatch(
  //       getOptionalCoursesBySemesterContract(
  //         selectedSemesterContract.contractId
  //       )
  //     )
  //   }
  // }, [selectedSemesterContract, dispatch])
  // useEffect(() => {
  //   setOptionalList(optionalCourses)
  // }, [dispatch, optionalCourses])

  // useEffect(() => {
  //   if (bringElementDown == true) {
  //     const index = optionalList.findIndex(
  //       optional => optional.id === selectedCourse
  //     )
  //     if (index < optionalList.length - 1) {
  //       const newList = [
  //         ...optionalList.slice(0, index),
  //         optionalList[index + 1],
  //         optionalList[index],
  //         ...optionalList.slice(index + 2)
  //       ]
  //       setOptionalList(newList)
  //       setBringElementDown(false)
  //     }
  //   }
  // }, [bringElementDown])

  // useEffect(() => {
  //   if (preferences == true) {
  //     if (contractId != undefined && selectedSemesterContract != undefined) {
  //       dispatch(
  //         setOptionalCoursesPreferences({
  //           contractId: selectedSemesterContract?.contractId,
  //           optionalCoursesList: optionalList
  //         })
  //       )
  //       setPreferences(false)
  //     }
  //   }
  // }, [preferences, dispatch])

  // useEffect(() => {
  //   if (bringElementUp == true) {
  //     const index = optionalList.findIndex(
  //       optional => optional.id === selectedCourse
  //     )
  //     if (index > 0) {
  //       const newList = [
  //         ...optionalList.slice(0, index - 1),
  //         optionalList[index],
  //         optionalList[index - 1],
  //         ...optionalList.slice(index + 1)
  //       ]
  //       setOptionalList(newList)
  //       setBringElementUp(false)
  //     }
  //   }
  // }, [bringElementUp])

  return (
    <MainContainer>
      <LeftContainer>
        {contracts.semesterContracts.map(semester => {
          const isActive = selectedSemesterContract == semester
          return (
            <div key={`semester-${semester.semester}`}>
              <SemesterWrapper
                isActive={isActive}
                onClick={() => {
                  setSelectedSemesterContract(semester)
                }}
              >
                Semester {semester.semester}
              </SemesterWrapper>
            </div>
          )
        })}
      </LeftContainer>
      <CentralContainer>
        <p style={{ paddingBottom: '12px' }}>Mandatory courses:</p>
        {courses
          .filter(
            course => course.semester == selectedSemesterContract?.semester
          )
          .map(course => (
            <div key={course.id}>
              <Course>
                <p style={{ fontWeight: 'bold' }}>{course.name}</p>
                <hr />
                <p>Credits: {course.credits}</p>
                <p>Teacher: {capitalizeFirstLetter(course.teacherLastName)}</p>
              </Course>
            </div>
          ))}
      </CentralContainer>

      <RightContainer>
        <Button
          variant="outlined"
          style={{ float: 'right', top: 0, marginLeft: 5 }}
          onClick={() => {
            // setPreferences(true)
          }}
        >
          Set preferences
        </Button>
        <Button
          variant="outlined"
          style={{ float: 'right', top: 0, marginLeft: 5 }}
          type="submit"
          onClick={() => {
            // setBringElementDown(true)
          }}
        >
          ↓
        </Button>

        <Button
          variant="outlined"
          style={{ float: 'right', top: 0, marginLeft: 5 }}
          onClick={() => {
            // setBringElementUp(true)
          }}
        >
          ↥
        </Button>

        {/* {optionalList.map(course => (
          <div key={course.id}>
            {selectedCourse != course.id && (
              <div
                style={{
                  width: '300px',
                  border: '5px solid green',
                  borderColor: '#96a2b4',
                  padding: '10px',
                  borderRadius: '25px'
                }}
                onClick={() => {
                  setSelectedCourse(course.id)
                }}
              >
                Name : {course.name} <br />
                Credits : {course.credits} <br />
                Capacity : {course.maxNumberOfStudent} <br />
              </div>
            )}
            {selectedCourse == course.id && (
              <div
                style={{
                  width: '300px',
                  border: '5px solid green',
                  borderColor: '#96a2b4',
                  padding: '15px',
                  borderRadius: '25px',
                  background: '#D6DEEA'
                }}
                onClick={() => {
                  setSelectedCourse(course.id)
                }}
              >
                Name : {course.name} <br />
                Credits : {course.credits} <br />
                Capacity : {course.maxNumberOfStudent} <br />
              </div>
            )}
            <br /> <br />
          </div>
        ))} */}
      </RightContainer>
    </MainContainer>
  )
}
