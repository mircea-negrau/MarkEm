import { FunctionComponent, useEffect, useState } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { AppState } from '../../state/store'
import {
  getTeacherOptionalWithNewIsProposedValue,
  TeacherOptional
} from '../../utility/types/optionalTypes'
import {
  getTeacherOptionals,
  proposeOptionals
} from '../../state/thunks/teacherOptionals'
import { FetchStatus } from '../../utility/fetchStatus'
import styled from 'styled-components'
import { GUID_EMPTY } from '../../utility/constants'

const SelectableDiv = styled.div<{ isActive?: boolean }>`
  cursor: pointer;
  ${props => (props.isActive ? 'background: #d6deea;' : '')}
  ${props => (props.isActive ? 'color: black;' : '')}
`

// TODO - finish whole the page
export const OptionalsPage: FunctionComponent = () => {
  const state = useSelector((state: AppState) => state.teacherOptionals)
  const dispatch = useDispatch()

  const [teacherOptionals, setTeacherOptionals] = useState<TeacherOptional[]>(
    []
  )

  const [courseName, setCourseName] = useState('')
  const [courseCredits, setCourseCredits] = useState(0)
  const [courseNameError, setCourseNameError] = useState('')
  const [courseCreditsError, setCourseCreditsError] = useState('')

  const [selectedAvailableOptional, setSelectedAvailableOptional] =
    useState<TeacherOptional | null>()
  const [selectedProposedOptional, setSelectedProposedOptional] =
    useState<TeacherOptional | null>()

  useEffect(() => {
    if (state.optionalsStatus === FetchStatus.success) {
      setTeacherOptionals(state.optionals)
    } else {
      dispatch(getTeacherOptionals())
    }
  }, [dispatch, state.optionalsStatus, state.optionals])

  // TODO: semester choosing: how?
  //  variant 1: Specialisation

  const handleAddOptional = async () => {
    let isInputInvalid = false
    if (courseName.length == 0) {
      setCourseNameError('Course name must not be empty!')
      isInputInvalid = true
    }
    if (courseCredits < 1 || courseCredits > 10) {
      setCourseCreditsError('Course credits must be between 1 and 10')
      isInputInvalid = true
    }
    if (isInputInvalid) {
      return
    }

    alert('Not implemented')
    // TODO: await Promise.resolve(dispatch(<call to BE>)).then(() => alert('Added optional')).catch(() => alert('Failed to add optional'))
  }

  function getNumberOfProposedOptionals() {
    return teacherOptionals.filter(optional => optional.isProposed).length
  }

  return (
    <>
      <div title={'switching panel'} style={{ display: 'flex' }}>
        <div title={'available optionals panel'}>
          <h3>Available</h3>
          <div style={{ width: '100px', border: '2px', borderColor: 'black' }}>
            {teacherOptionals &&
              teacherOptionals
                .filter(optional => !optional.isProposed)
                .map((optional, index) => {
                  return (
                    <SelectableDiv
                      isActive={selectedAvailableOptional == optional}
                      key={`available-optional-${index}`}
                      onClick={() =>
                        selectedAvailableOptional == optional
                          ? setSelectedAvailableOptional(null)
                          : setSelectedAvailableOptional(optional)
                      }
                    >
                      {optional.name}
                    </SelectableDiv>
                  )
                })}
          </div>
        </div>
        <button
          disabled={
            teacherOptionals.filter(optional => optional.isProposed).length == 2
          }
          style={{ cursor: 'pointer' }}
          onClick={() => {
            console.log(
              `moving optional ${selectedAvailableOptional?.id} from available to proposed`
            )
            if (selectedAvailableOptional) {
              const newOptionals = teacherOptionals.filter(
                optional => optional !== selectedAvailableOptional
              )
              newOptionals.push(
                getTeacherOptionalWithNewIsProposedValue(
                  selectedAvailableOptional,
                  true
                )
              )
              setTeacherOptionals(newOptionals)
              setSelectedAvailableOptional(null)
            }
          }}
        >
          {'-->'}
        </button>
        <br />
        <button
          style={{ display: 'default' }}
          onClick={() => {
            console.log(`clicked save button`)
            const proposed = teacherOptionals.filter(
              optional => optional.isProposed
            )
            const first = proposed.length >= 1 ? proposed[0].id : GUID_EMPTY
            const second = proposed.length == 2 ? proposed[0].id : GUID_EMPTY
            dispatch(proposeOptionals({ first: first, second: second }))
          }}
        >
          Save
        </button>
        <br />
        <button
          disabled={getNumberOfProposedOptionals() == 0}
          style={{ cursor: 'pointer' }}
          onClick={() => {
            console.log(
              `moving optional ${selectedProposedOptional?.id} from proposed to available`
            )
            if (selectedProposedOptional) {
              const newOptionals = teacherOptionals.filter(
                optional => optional !== selectedProposedOptional
              )
              newOptionals.push(
                getTeacherOptionalWithNewIsProposedValue(
                  selectedProposedOptional,
                  false
                )
              )
              setTeacherOptionals(newOptionals)
              setSelectedProposedOptional(null)
            }
          }}
        >
          {'<--'}
        </button>
        <div title={'proposed optionals panel'}>
          <h3>Proposed</h3>
          <div style={{ width: '100px', border: '2px', borderColor: 'black' }}>
            {teacherOptionals &&
              teacherOptionals
                .filter(optional => optional.isProposed)
                .map((optional, index) => {
                  return (
                    <SelectableDiv
                      isActive={selectedProposedOptional == optional}
                      key={`proposed-optional-${index}`}
                      onClick={() =>
                        selectedProposedOptional == optional
                          ? setSelectedProposedOptional(null)
                          : setSelectedProposedOptional(optional)
                      }
                    >
                      {optional.name}
                    </SelectableDiv>
                  )
                })}
          </div>
        </div>
      </div>
      <div title={'add panel'}>
        <p>
          Course name
          <input
            style={{ marginLeft: '30px' }}
            onChange={event => setCourseName(event.target.value)}
          />{' '}
          <span style={{ paddingLeft: '20px', color: 'red' }}>
            {courseNameError}
          </span>
        </p>
        <p>
          Course credits
          <input
            style={{ marginLeft: '30px' }}
            type="number"
            min="1"
            max="10"
            onChange={event => setCourseCredits(Number(event.target.value))}
          />
          <span style={{ paddingLeft: '20px', color: 'red' }}>
            {courseCreditsError}
          </span>
        </p>
        <button
          onClick={() => {
            handleAddOptional()
          }}
        >
          Add optional
        </button>
      </div>
    </>
  )
}
