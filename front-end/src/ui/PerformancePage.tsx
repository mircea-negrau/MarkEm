import { FunctionComponent, useEffect, useState } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import styled from 'styled-components'
import { AppState } from '../state/store'
import {
  getGroups,
  getPerformanceByGroup,
  getPerformanceBySemester,
  getPerformanceByYearWithCriteria,
  getSemesters,
  getStudyYears
} from '../state/thunks/performance'
const MainContainer = styled.div`
  display: inline-block;
  flex-direction: column;
  padding: 40px 25px;
  width: 100%;
  height: 100%;
`

const StudentGrade = styled.div`
  color: #96a2b4;
  display: flex;
  flex-direction: column;
  padding: 20px;
  width: 300px;
  background-color: #151a25;
  border-radius: 20px;
  height: 30px;
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

export const PerformancePage: FunctionComponent = () => {
  const performanceOptions = ['Group', 'Year with criteria', 'Semester']
  const criteriaOptions = ['1', '2', '3', '4', '5', '6', '7', '8', '9', '10']
  const [performanceOption, setPerformanceOption] = useState(
    performanceOptions[0]
  )
  const [criteriaOption, setCriteriaOption] = useState(criteriaOptions[0])
  const [selectedItem, setSelectedItem] = useState('')
  const [itemType, setItemType] = useState('group')
  const state = useSelector((state: AppState) => state.performance)
  const dispatch = useDispatch()

  useEffect(() => {
    console.log(performanceOption)

    if (performanceOption == 'Group') {
      console.log(performanceOption)
      dispatch(getGroups())
      console.log(state.studyYears)
    } else if (performanceOption == 'Year with criteria') {
      console.log(performanceOption)
      dispatch(getStudyYears())
    } else if (performanceOption == 'Semester') {
      console.log(performanceOption)
      dispatch(getSemesters())
    }
  }, [dispatch, performanceOption])

  useEffect(() => {
    if (selectedItem != '') {
      console.log(selectedItem)
      if (itemType == 'group') {
        dispatch(getPerformanceByGroup(selectedItem))
      }
      if (itemType == 'studyYear') {
        const lowerBound: number = +criteriaOption
        dispatch(
          getPerformanceByYearWithCriteria({
            yearId: selectedItem,
            minimumAverage: lowerBound
          })
        )
      }
      if (itemType == 'semester') {
        dispatch(getPerformanceBySemester(selectedItem))
      }
    }
  }, [criteriaOption, dispatch, itemType, selectedItem])

  const Dropdown = ({ options }) => {
    return (
      <select
        value={performanceOption}
        onChange={e => [setPerformanceOption(e.target.value)]}
        style={{
          background: '#0f1218',
          color: '#96a2b4',
          height: '40px',
          fontSize: '20px',
          width: '50%',
          paddingLeft: '7px',
          marginTop: '7px',
          borderRadius: '5px'
        }}
      >
        {options.map(o => (
          <option key={o} value={o}>
            {o}
          </option>
        ))}
      </select>
    )
  }
  return (
    <MainContainer>
      <p style={{ fontSize: '18px', fontWeight: '600', color: '#a5abb1' }}>
        Performance
      </p>
      <div
        style={{
          width: '49%',
          height: '100vh',
          float: 'left'
        }}
      >
        <Dropdown options={performanceOptions} />
        <br />
        <br />

        {performanceOption == 'Group' && (
          <>
            {' '}
            {state.groups.map(group => (
              <div key={group.groupId}>
                {selectedItem != group.groupId && (
                  <div
                    style={{
                      width: '150px',
                      border: '5px solid green',
                      borderColor: '#96a2b4',
                      padding: '10px',
                      borderRadius: '25px'
                    }}
                    onClick={() => {
                      setItemType('group')
                      setSelectedItem(group.groupId)
                    }}
                  >
                    {group.groupId}
                  </div>
                )}
                {selectedItem == group.groupId && (
                  <div
                    style={{
                      width: '150px',
                      border: '5px solid green',
                      borderColor: '#96a2b4',
                      padding: '15px',
                      borderRadius: '25px',
                      background: '#D6DEEA'
                    }}
                    onClick={() => {
                      setItemType('group')
                      setSelectedItem(group.groupId)
                    }}
                  >
                    {group.groupId}
                  </div>
                )}
                <br /> <br />
              </div>
            ))}
          </>
        )}
        {performanceOption == 'Year with criteria' && (
          <>
            {' '}
            <div style={{ width: '50%', height: '40px' }}>
              <p>Select a lower bound :</p>
              <select
                value={criteriaOption}
                onChange={e => [setCriteriaOption(e.target.value)]}
                style={{
                  background: '#0f1218',
                  color: '#96a2b4',
                  height: '40px',
                  fontSize: '20px',
                  width: '50%',
                  paddingLeft: '7px',
                  marginTop: '7px',
                  borderRadius: '5px'
                }}
              >
                {criteriaOptions.map(o => (
                  <option key={o} value={o}>
                    {o}
                  </option>
                ))}
              </select>
            </div>
            <br /> <br />
            {state.studyYears.map(studyYear => (
              <div key={studyYear.id}>
                {selectedItem != studyYear.id && (
                  <div
                    style={{
                      width: '150px',
                      border: '5px solid green',
                      borderColor: '#96a2b4',
                      padding: '10px',
                      borderRadius: '25px'
                    }}
                    onClick={() => {
                      setItemType('studyYear')
                      setSelectedItem(studyYear.id)
                    }}
                  >
                    {studyYear.id}
                  </div>
                )}
                {selectedItem == studyYear.id && (
                  <div
                    style={{
                      width: '150px',
                      border: '5px solid green',
                      borderColor: '#96a2b4',
                      padding: '15px',
                      borderRadius: '25px',
                      background: '#D6DEEA'
                    }}
                    onClick={() => {
                      setItemType('studyYear')
                      setSelectedItem(studyYear.id)
                    }}
                  >
                    {studyYear.id}
                  </div>
                )}
                <br /> <br />
              </div>
            ))}
          </>
        )}
        {performanceOption == 'Semester' && (
          <>
            {' '}
            {state.semesters.map(semester => (
              <div key={semester.id}>
                {selectedItem != semester.id && (
                  <div
                    style={{
                      width: '150px',
                      border: '5px solid green',
                      borderColor: '#96a2b4',
                      padding: '10px',
                      borderRadius: '25px'
                    }}
                    onClick={() => {
                      setItemType('semester')
                      setSelectedItem(semester.id)
                    }}
                  >
                    {semester.id}
                  </div>
                )}
                {selectedItem == semester.id && (
                  <div
                    style={{
                      width: '150px',
                      border: '5px solid green',
                      borderColor: '#96a2b4',
                      padding: '15px',
                      borderRadius: '25px',
                      background: '#D6DEEA'
                    }}
                    onClick={() => {
                      setItemType('semester')
                      setSelectedItem(semester.id)
                    }}
                  >
                    {semester.id}
                  </div>
                )}
                <br /> <br />
              </div>
            ))}
          </>
        )}
      </div>

      <div
        style={{
          width: '49%',
          height: '100vh',
          float: 'right'
        }}
      >
        {state.students.map(student => (
          <div key={student.studentId}>
            <StudentGrade>
              Student Email : {student.studentEmail} Average :
              {student.averageGrade}
            </StudentGrade>
            <br />
            <br />
          </div>
        ))}
      </div>
    </MainContainer>
  )
}
