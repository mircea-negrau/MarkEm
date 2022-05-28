USE [WebelopersDB]; GO

-- find the number of courses for each teacher
SELECT A.Id, A.Email, COUNT(*)
FROM Accounts A
         INNER JOIN Courses C ON A.Id = C.TeacherId
GROUP BY A.Id, A.Email
ORDER BY A.Email


-- find all courses of a teacher
SELECT *
FROM Courses C
WHERE C.TeacherId = '924BCE2B-2FEF-4AB4-960E-FF9488551714'
