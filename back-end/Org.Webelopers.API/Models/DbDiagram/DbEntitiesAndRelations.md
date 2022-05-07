Nr of relations: `grep "^ " Org.Webelopers.API/Models/DbEntities/DbEntitiesAndRelations.md  | wc -l`

1. AccountRole
   1. AccountRole 1:n Account
2. Account
3. Admin
   1. Admin 1:1 Account
6. Student
    1. Student 1:1 Account
    2. Student 1:n Grade
    3. Student 1:n OptionalCourseGrade
    4. Student 1:n StudentContract
5. Teacher
   1. Teacher 1:1 Account
   2. Teacher 1:n Course
   3. Teacher 1:n OptionalCourse
4. TeacherDegree
    1. TeacherDegree 1:n Teacher
8. Faculty
   2. Faculty 1:1 Teacher (ChiefOfDepartment)
   3. Faculty 1:n Specialization
9. StudyDegree
   1. StudyDegree 1:n Specialization
10. StudyLine
    1. StudyLine 1:n Specialization
11. Specialization
    1. Specialization 1:n StudyYear
12. StudyYear
    1. StudyYear 1:1 Student (Leader)
    2. StudyYear 1:n StudySemester
    3. StudyYear 1:n StudentContract
    4. StudyYear 1:n Group
13. StudySemester
    1. StudySemester 1:n Course
    2. StudySemester 1:n OptionalCourse
    3. StudySemester 1:n StudentContractSemester
14. Course
    1. Course 1:n Grade
    2. Course 1:n SemesterContractCourse
15. Grade
16. OptionalCourse
    1. OptionalCourse 1:n OptionalCourseGrade
    2. OptionalCourse 1:n OptionalCoursePreference
17. OptionalCourseGrade
18. OptionalCoursePreference
7. StudentContract
    1. StudentContract 1:n StudentContractSemester
19. StudentContractSemester
    1. StudentContractSemester 1:n OptionalCoursePreference
    2. StudentContractSemester 1:n SemesterContractCourse
20. SemesterContractCourse
21. Group
    1. Group 1:1 Teacher (Tutor)
    2. Group 1:1 Student (Leader)
    3. Group 1:n StudentContract
    4. Group 1:n SemesterContractCourse
