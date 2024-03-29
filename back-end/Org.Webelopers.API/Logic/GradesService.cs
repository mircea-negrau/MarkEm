﻿using Microsoft.EntityFrameworkCore;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.DbEntities;
using Org.Webelopers.Api.Models.Persistence.Grades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Org.Webelopers.Api.Logic
{
    public class GradesService : IGradesService
    {
        private readonly DatabaseContext _context;
        public GradesService(DatabaseContext context)
        {
            _context = context;
        }

        public void AddGrade(short grade, Guid courseId, Guid studentId)
        {
            _context.Add(new MandatoryCourseGrade()
            {
                Id = Guid.NewGuid(),
                Grade = grade,
                CreatedAt = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds(),
                CourseId = courseId,
                StudentId = studentId
            });
            _context.SaveChanges();
        }

        public void UpdateGrade(Guid gradeId, short grade)
        {
            var studentGrade = _context.Grades.FirstOrDefault(x => x.Id == gradeId);

            if (studentGrade != null)
            {
                studentGrade.Grade = grade;
                _context.SaveChanges();
            }
        }

        public void DeleteGrade(Guid gradeId)
        {
            var grade = _context.Grades.FirstOrDefault(x => x.Id == gradeId);
            if (grade != null)
            {
                _context.Remove(grade);
                _context.SaveChanges();
            }
        }

        public void SetGrade(Guid studentId, Guid courseId, short value)
        {
            _context.FindEntityAndThrowIfNullReference<Student>(student => student.AccountId == studentId,
                $"student {studentId} does not exist");
            _context.FindEntityAndThrowIfNullReference<MandatoryCourse>(course => course.Id == courseId,
                $"course {courseId} does not exist");
            var grade = GetGrade(studentId, courseId);
            if (grade == default)
            {
                if (value == -1)
                {
                    return;
                }
                AddGrade(value, courseId, studentId);
            }
            else
            {
                if (value == -1)
                {
                    DeleteGrade(grade.Id);
                }
                else
                {
                    UpdateGrade(grade.Id, value);
                }
            }
        }
        private MandatoryCourseGrade GetGrade(Guid studentId, Guid courseId) =>
            _context.Grades
                .FirstOrDefault(grade => grade.StudentId == studentId && grade.CourseId == courseId);


        public List<ContractSemesterGrades> GetStudentGrades(Guid studentId)
        {
            List<ContractSemesterGrades> contractGrades = new List<ContractSemesterGrades>();
            var contracts = _context.Contracts.Where(x => x.StudentId == studentId)
                .Include(x => x.StudyYear)
                .ThenInclude(x => x.Specialization)
                .ThenInclude(x => x.Faculty).Where(x => x.StudyYear != null && x.StudyYear.Specialization != null &&
                x.StudyYear.Specialization.Faculty != null)
                .ToList();

            System.Diagnostics.Debug.WriteLine("we start");
            System.Diagnostics.Debug.WriteLine("contracts count ", contracts.Count);


            foreach (var contract in contracts)
            {

                var semesters = _context.SemesterContracts.Where(x => x.StudentContractId == contract.Id).Select(x => x.StudySemester).ToList();
                System.Diagnostics.Debug.WriteLine("semesters count ");
                System.Diagnostics.Debug.WriteLine(semesters.Count);
                List<SemesterCourseGrades> semesterGrades = new List<SemesterCourseGrades>();
                foreach (var semester in semesters)
                {

                    List<StudentCourseGrades> courseGrades = new List<StudentCourseGrades>();
                    var courses = _context.Courses.Include(x => x.Teacher)
                        .ThenInclude(x => x.Account)
                        .Where(x => x.SemesterId == semester.Id && x.Teacher != null 
                    && x.Teacher.Account != null).ToList();
                    System.Diagnostics.Debug.WriteLine("courses count ", courses.Count);
                    System.Diagnostics.Debug.WriteLine(courses.Count);


                    foreach (var course in courses)
                    {
                        List<StudentCourseGrades> grades = new List<StudentCourseGrades>();

                        var gr = _context.Grades.FirstOrDefault(grad => grad.CourseId == course.Id && grad.StudentId == studentId);
                        if(gr != null)
                        {
                            var gr2 = new GradesDetailDto()
                            {
                                GradeId = gr.Id,
                                Grade = gr.Grade,
                                CourseName = course.Name,
                                Credits = course.Credits
                            };

                            courseGrades.Add(new StudentCourseGrades()
                            {
                                Id = course.Id,
                                Name = course.Name,
                                TeacherName = course.Teacher.Account.FirstName + " " + course.Teacher.Account.LastName,
                                Grade = gr2
                            });
                            System.Diagnostics.Debug.WriteLine("at least one grade");

                        }




                    }

                    semesterGrades.Add(new SemesterCourseGrades()
                    {

                        Id = semester.Id,
                        Value = semester.Semester,
                        YearStartDate = semester.StudyYear.StartDate,
                        YearEndDate = semester.StudyYear.EndDate,
                        SpecializationName = semester.StudyYear.Specialization.Name,
                        Courses = courseGrades

                    });
                }

                contractGrades.Add(new ContractSemesterGrades()
                {

                    Id = contract.Id,
                    SignedAt = contract.SignedAt,
                    Specialisation = contract.StudyYear.Specialization.Name,
                    Faculty = contract.StudyYear.Specialization.Faculty.Name,
                    Semesters = semesterGrades
                });
            }

            return contractGrades;
        }
        public HashSet<MandatoryCourseGrade> GetCourseGrades(Guid courseId) =>
            _context.Grades
                .AsNoTracking()
                .Where(grade => grade.CourseId == courseId)
                .ToHashSet();

        public HashSet<MandatoryCourseGrade> GetTeacherGrades(Guid teacherId) =>
            _context.Grades
                .AsNoTracking()
                .Include(grade => grade.Course)
                .Where(grade => grade.Course.TeacherId == teacherId)
                .ToHashSet();
    }
}
