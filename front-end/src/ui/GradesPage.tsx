import {
  CollectionsBookmarkRounded,
  CompareSharp,
  CountertopsOutlined
} from '@mui/icons-material'
import { Button } from '@mui/material'
import { FunctionComponent, useEffect, useState } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { Link, useParams } from 'react-router-dom'
import styled from 'styled-components'
import { AppState } from '../state/store'
import { getCoursesNamesByContract } from '../state/thunks/courses'
import { getAllGrades } from '../state/thunks/grades'
import {
  getOptionalCoursesByContract,
  setOptionalCoursesPreferences
} from '../state/thunks/optionalCourses'

const MainContainer = styled.div`
  display: inline-block;
  flex-direction: column;
  padding: 40px 25px;
  width: 100%;
  height: 100%;
`
const Grade = styled.div`
  color: #96a2b4;
  display: flex;
  flex-direction: column;
  padding: 40px;
  width: 100px;
  background-color: #151a25;
  border-radius: 20px;
  height: 15px;
  width: 400px;
  margin-right: 25px;
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

const EntryP = styled.p`
  font-size: 24px;
`

export const GradesPage: FunctionComponent = () => {
  const token = useSelector((state: AppState) => state.global.accessToken)
  const grades = useSelector((state: AppState) => state.grades.grades)
  const dispatch = useDispatch()

  useEffect(() => {
    dispatch(getAllGrades(token))
  }, [dispatch, token])

  return (
    <MainContainer>
      <div
        style={{
          width: '100%',
          height: '100vh',
          float: 'left',
          display: 'inline-block'
        }}
      >
        {grades.map(grade => (
          <div key={grade.id}>
            <Grade>
              {' '}
              <EntryP>
                Course name : {grade.courseName}
                &emsp;&emsp; Grade : {grade.grade}
              </EntryP>
            </Grade>
            <br /> <br />
          </div>
        ))}
      </div>
    </MainContainer>
  )
}