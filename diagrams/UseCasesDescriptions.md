# Use Case Diagram Specifications  

## Template  
#### Name: `...`  
#### Actors: `...`  
#### Preconditions: `...`  
#### Postconditions: `...`  
#### Standard process:  ```...```
#### Alterantive process: ```...```

<br>

## Specifications

### User use cases

#### Name: `log in`
#### Actors: `User`
#### Preconditions: `There isn't any user currently logged in into the system. The user presses the log in button.`
#### Postconditions: `The user is logged in, given that the submitted credentials are correct.`
#### Standard process:
``` 
1. The user enters the username and password.
2. The credentials are validated.
3. On positive validation, the user is logged in. Otherwise, the process returns to step 2.
``` 
#### Alterantive process: ```None```

---  

#### Name: `log out`
#### Actors: `User`
#### Preconditions: `The user is currently logged in. The user presses the log out button.`
#### Postconditions: `The user is logged out.`
#### Standard process:
```
1. The user presses the confirmation button.
```
#### Alterantive process: ```None```

---    

#### Name: `view profile`
#### Actors: `User`
#### Preconditions: `The user is logged in. User presses the view profile button.`
#### Postconditions: `The user's profile is shown.`
#### Standard process:
```
1. The user's profile is shown.
```
#### Alterantive process: ```None```

---    

#### Name: `modify profile`
#### Actors: `User`
#### Preconditions: `The user is logged in. The user presses the modify profile button`
#### Postconditions: `The user profile is updated`
#### Standard process:
```
1. The user modify their profile information. (https://www.quora.com/How-should-we-conjugate-verbs-with-the-singular-they?share=1)
2. The information introduced is validated. If the validation fails, the process goes back to step 1.
3. The user presses the save button.
4. The systems shows confirmation.
```
#### Alterantive process: ```None```



### Student use cases
#### Name: `enrol`  
#### Actors: `Student`  
#### Preconditions: `The student is logged in. The student presses the enrol button.`  
#### Postconditions: `The enrolment is submitted and sent for verification`  
#### Standard process:
```
1. The student fills the enrolment document.
2. The information introduced is validated. If the validation fails, the process goes back to step 1.
3. Press the submit button.
4. The systems shows confirmation.
```
#### Alterantive process: ```None```

---

#### Name: `view curriculum`  
#### Actors: `Student`  
#### Preconditions: `The student is logged in. The view curriculum button is pressed.`  
#### Postconditions: `The curriculum for the student's current year of study is shown.`  
#### Standard process:
```
1. The curriculum for the student's current year of study is shown.
```
#### Alterantive process: ```None```

---

#### Name: `view optional courses`  
#### Actors: `Student`  
#### Preconditions: `The student is logged in. The student presses the view optional courses button. The list of optionals is approved by the chief of department.`  
#### Postconditions: `The list of optional courses is shown to the student.`  
#### Standard process:
```
1. The list of optional courses is shown to the student.
```
#### Alterantive process:
```1. The system notifies that the list of optionals is not ready yet.```

---

#### Name: `specify preference order`  
#### Actors: `Student`  
#### Preconditions: `The user is logged in. The student presses the view optional courses button.`  
#### Postconditions: `The student's preference order is updated.`  
#### Standard process:
```
1. Modify the preference order list.
2. Press the update preference order button .
3. The systems shows confirmation.
```
#### Alterantive process: ```None```

---

#### Name: `sign contract`  
#### Actors: `Student`  
#### Preconditions: `The student presses the sign contract button. The chief of department has approved the list of optionals. The has specified their preference order.`  
#### Postconditions: `The signed contract is sent for final verification to the department's secretariat.`  
#### Standard process: 
```
1. The contract is shown to the student for review.
2. Sign the contract.
3. Press the submit button.
4. The systems shows confirmation.
```
#### Alterantive process:
```
The system alerts the user that they didn't specified their preference order.
```

---

#### Name: `view grades`  
#### Actors: `Student`  
#### Preconditions: `The student is logged in. The view grades button is pressed.`  
#### Postconditions: `The grades are shown to the student.`  
#### Standard process:
```
1. The grades are displayed.
2. Choose semester, which takes the student back to step 1.
```
#### Alterantive process: ```None```



## Teacher use cases
#### Name: `propose optionals`  
#### Actors: `Teacher`  
#### Preconditions: `The techer is logged in. The propose optionals button is pressed. The teacher has at least a lecturer degree.`  
#### Postconditions: `The teacher proposal is submitted.`  
#### Standard process:
```
1. Write 1 or 2 optional course names.
2. Press the submit button.
3. The systems shows confirmation.
```
#### Alterantive process: ```None```

---

#### Name: `grade student`  
#### Actors: `Teacher`  
#### Preconditions: `The techer is logged in. The grade student button is pressed.`  
#### Postconditions: `The grade/grades are modified.`  
#### Standard process:
```
1. Enter/modify grade.
2. The systems shows confirmation.
```
#### Alterantive process: ```None```



## Chief of department use cases
#### Name: `view optionals list`  
#### Actors: `Chief of department`  
#### Preconditions: `The chief of department is logged in. The chief of department presses the view optionals list button.`  
#### Postconditions: `The proposed optionals list is shown.`  
#### Standard process:
```
1. The proposed optionals list is shown.
```
#### Alterantive process: ```None```

---

#### Name: `approve optionals list`  
#### Actors: `Chief of department`  
#### Preconditions: `The chief of department is logged in. The chief of department presses the aprove optionals list button. All the teachers having at least a lecturer degree proposed a list of at most 2 optional courses.`  
#### Postconditions: `The optionals list is approved and the process of assigning optional courses takes place.`  
#### Standard process:
```
1. The optionals list is approved.
2. The chief of department selects a maximum number of students to attend each course.
3. The decision is uploaded on the appropriate page of the faculty site.
4. The process of assigning optional courses to students takes place.
5. The systems shows confirmation.
```
#### Alterantive process: ```None```

---

#### Name: `specify optionals capacity`  
#### Actors: `Chief of department`  
#### Preconditions: `The chief of department is logged in. The optionals list is approved.`  
#### Postconditions: `The assignation of optional courses to students starts.`  
#### Standard process: 
```
1. Specify the capacity for each optional course.
2. The systems shows confirmation.
```
#### Alterantive process: ```None```

---

#### Name: `view results`  
#### Actors: `Chief of department`  
#### Preconditions: `The chief of department is logged in. The chief of department presses the view results button.`   
#### Postconditions: `The demanded teacher/discpline is shown.`  
#### Standard process:
```
1. Select the kind of results (teacher's results or discipline's results).
2. Select the type of results (best results/worst results).
3. The syste shows the demanded teacher/discipline.
```
#### Alterantive process: ```None```

---

#### Name: `view teacher's disciplines`  
#### Actors: `Chief of department`  
#### Preconditions: `The chief of department is logged in. The chief of department presses the view teacher's disciplines button.`  
#### Postconditions: `The disciplines given by a teacher in a semester or in an academic year are shown.`  
#### Standard process:
```
1. Select the teacher.
2. Select the semester/year.
3. The demanded disciplines are shown.
```
#### Alterantive process: ```None```



## Faculty staff use cases
#### Name: `generate document`  
#### Actors: `Faculty staff`  
#### Preconditions: `The faculty staff is logged in.`  
#### Postconditions: `The generate document menu is shown. The choosen document is generated.`  
#### Standard process:
```
1. The faculty staff chooses the document from the list of available documents.
2. The faculty staff preses the generate button.
3. The choosen document is generated and shown.
```
#### Alterantive process: ```None```

---

#### Name: `print document`  
#### Actors: `Faculty staff`  
#### Preconditions: `The faculty staff is logged in. The faculty staff generated a document and pressed the print button.`  
#### Postconditions: `A list with the available printers and the option to print the document is shown.`  
#### Standard process:
```
1. The faculty staff presses the print button.
2. A list with the available printers and the option to print the document is shown.
```
#### Alterantive process: ```None```



