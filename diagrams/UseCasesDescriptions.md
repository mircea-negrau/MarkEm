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
```
#### Alterantive process: ```None```

--- 

### Student use cases
#### Name: `...`  
#### Actors: `...`  
#### Preconditions: `...`  
#### Postconditions: `...`  
#### Standard process:  ```...```
#### Alterantive process: ```...```
