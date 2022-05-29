import { FunctionComponent, useState } from 'react'

// TODO - finish whole the page
export const OptionalsPage: FunctionComponent = () => {
  const [courseName, setCourseName] = useState('')
  const [courseCredits, setCourseCredits] = useState(0)

  const [courseNameError, setCourseNameError] = useState('')
  const [courseCreditsError, setCourseCreditsError] = useState('')
  // TODO: get all specialisations
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

    // TODO: await Promise.resolve(dispatch(<call to BE>)).then(() => alert('Added optional')).catch(() => alert('Failed to add optional'))
  }

  return (
    <>
      <div title={'switching panel'}>
        <div title={'available optionals panel'}>
          Available
          {/*TODO: call BE getTeacherOptionals()*/}
          <table style={{ width: '100px' }} />
        </div>
        <div>{'-->'}</div>
        <div>{'<--'}</div>
        <div title={'proposed optionals panel'}>
          Proposed
          {/* TODO: call BE getTeacherProposedOptionals() vs add a proposed field to the optionals*/}
          {/*  UPDATE a single endpoint and add a proposed field to the optionals*/}
          <table style={{ width: '100px' }} />
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
