import { CountertopsOutlined } from '@mui/icons-material'
import { Button } from '@mui/material'
import { FunctionComponent, useEffect, useState } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { Link, useParams } from 'react-router-dom'
import styled from 'styled-components'
import { AppState } from '../state/store'
import { getCoursesNamesByContract } from '../state/thunks/courses'
import { getOptionalCoursesByContract } from '../state/thunks/optionalCourses'

const MainContainer = styled.div`
  display: inline-block;
  flex-direction: column;
  padding: 40px 25px;
  width: 100%;
  height: 100%;
`
const Course = styled(Link)`
  color: #96a2b4;
  display: flex;
  flex-direction: column;
  padding: 20px;
  width: 100px;
  background-color: #151a25;
  border-radius: 20px;
  height: 15px;
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

export const EditContractPage: FunctionComponent = () => {
  const { contractId } = useParams()
  const dispatch = useDispatch()
  const courses = useSelector((state: AppState) => state.courses.coursesNames)
  const optionalCourses = useSelector(
    (state: AppState) => state.optionalCourses.courses
  )
  const [optionalList, setOptionalList] = useState(optionalCourses)
  const [selectedCourse, setSelectedCourse] = useState('')

  useEffect(() => {
    if (contractId != undefined) dispatch(getCoursesNamesByContract(contractId))
  }, [contractId, dispatch])

  useEffect(() => {
    if (contractId != undefined) {
      dispatch(getOptionalCoursesByContract(contractId))
    }
  }, [contractId, dispatch])
  useEffect(() => {
    setOptionalList(optionalCourses)
  }, [dispatch, optionalCourses])
  return (
    <MainContainer>
      <div
        style={{
          width: '49%',
          height: '100vh',
          float: 'left',
          display: 'inline-block'
        }}
      >
        Your contract courses :
        {courses.map(course => (
          <p key={course.id}>
            <Course to={`/student/course/${course.id}`}>{course.name}</Course>{' '}
            <br /> <br />
          </p>
        ))}
      </div>

      <div
        style={{
          width: '50%',
          height: '100vh',
          float: 'right'
        }}
      >
        <Button
          variant="outlined"
          style={{ float: 'right', right: -150, top: 0, marginLeft: 5 }}
          type="submit"
          onClick={() => {
            console.log('click')
          }}
        >
          ↓
        </Button>

        <Button
          variant="outlined"
          style={{ float: 'right', right: -150, top: 0, marginLeft: 5 }}
          onClick={() => {
            console.log('click')
          }}
        >
          ↥
        </Button>

        {optionalCourses.map(course => (
          <p key={course.id}>
            {selectedCourse != course.id && (
              <div
                style={{
                  width: '300px',
                  border: '5px solid green',
                  borderColor: '#96a2b4',
                  padding: '50px',
                  borderRadius: '25px'
                }}
                onClick={() => {
                  console.log('div with id ' + course.id + ' was clicked')
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
                  padding: '50px',
                  borderRadius: '25px',
                  background: '#D6DEEA'
                }}
                onClick={() => {
                  console.log('div with id ' + course.id + ' was clicked')
                  setSelectedCourse(course.id)
                }}
              >
                Name : {course.name} <br />
                Credits : {course.credits} <br />
                Capacity : {course.maxNumberOfStudent} <br />
              </div>
            )}
            <br /> <br />
          </p>
        ))}
      </div>
    </MainContainer>
  )
}
