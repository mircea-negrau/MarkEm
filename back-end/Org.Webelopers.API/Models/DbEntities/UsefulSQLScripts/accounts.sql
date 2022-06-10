USE [WebelopersDB]; GO

-- find account by id
SELECT A.Username, A.Email, A.Role
FROM Accounts A
WHERE A.ID = '56586EB3-C298-4D82-A44A-C1522F3B9EF9'


-- find account by role
SELECT A.Username, A.Email, A.Role
FROM Accounts A
WHERE A.Role = 'Admin'


-- find teacher account info (similar for other account type)
SELECT A.*
FROM Accounts A
INNER JOIN Teachers T on A.Id = T.AccountId


-- find all chiefs with their account info
SELECT F.Id AS FacultyId, F.Name AS FacultyName, F.ChiefOfDepartmentId, A.Email, A.Username, A.LastName, A.FirstName, A.PasswordHash
FROM Faculties F
INNER JOIN Teachers T on T.AccountId = F.ChiefOfDepartmentId
INNER JOIN Accounts A on A.Id = T.AccountId