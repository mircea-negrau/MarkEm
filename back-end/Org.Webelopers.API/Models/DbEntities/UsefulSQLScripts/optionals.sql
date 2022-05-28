USE [WebelopersDB]; GO


-- find the number of optionals for each teacher
SELECT A.Id, A.Email, COUNT(*)
FROM Accounts A
         INNER JOIN OptionalCourses OC ON A.Id = OC.TeacherId
GROUP BY A.Id, A.Email
ORDER BY A.Email


-- find all optionals for a teacher
SELECT *
FROM OptionalCourses OC
WHERE OC.TeacherId = '924BCE2B-2FEF-4AB4-960E-FF9488551714'


-- find all the optionals for a chief (for a faculty)
SELECT OC.*
FROM OptionalCourses OC
         INNER JOIN StudySemesters SS on SS.Id = OC.SemesterId
         INNER JOIN StudyYears SY on SY.Id = SS.StudyYearId
         INNER JOIN Specialisations S on S.Id = SY.SpecializationId
         INNER JOIN Faculties F on F.Id = S.FacultyId
WHERE F.ChiefOfDepartmentId = '924BCE2B-2FEF-4AB4-960E-FF9488551714'



-- find the nr of optionals in each year
SELECT SY.ID, COUNT(*)
FROM StudyYears SY
         INNER JOIN StudySemesters SS on SY.Id = SS.StudyYearId
         INNER JOIN OptionalCourses OC on SS.Id = OC.SemesterId
GROUP BY SY.ID


-- find the nr of optionals in each semester
SELECT SS.Id, COUNT(*)
FROM StudySemesters SS
         INNER JOIN OptionalCourses OC on SS.Id = OC.SemesterId
GROUP BY SS.Id
