using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSystem2API.DAL.Abstract;
using UniSystem2API.Entities;

namespace UniSystem2API.DAL.Concrete
{
    public class UniSystemCourseRepository : IUniSystemCourseRepository
    {
        private readonly UniDbContext _uniDbContext;

        public UniSystemCourseRepository(UniDbContext dbContext)
        {
            _uniDbContext =dbContext;
        }

        public void AddCourse(Course course)
        {
            _uniDbContext.Courses.Add(course);
            _uniDbContext.SaveChanges();
        }

        public double CalculateCourseAverageScore(int courseId)
        {
            var examResultsForCourse = _uniDbContext.ExamResults
            .Where(result => result.Exam.CourseId == courseId)
            .ToList();

            if (examResultsForCourse.Any())
            {
                double totalScore = examResultsForCourse.Sum(result => result.Score);
                double averageScore = totalScore / examResultsForCourse.Count;
                return averageScore;
            }
            else
            {
                Console.WriteLine("No exam result has been found");
            }


            return 0;
        }

        public void DeleteCourse(int id)
        {
            var deletedCourse = _uniDbContext.Courses.Find(id);
            _uniDbContext.Remove(deletedCourse);
            _uniDbContext.SaveChanges();
        }

        public List<Course> GetAllCourses()
        {
            return _uniDbContext.Courses.ToList();
        }

        public Course GetCourseById(int id)
        {
             return _uniDbContext.Courses.Find(id);
        }

        public IEnumerable<Exam> GetExamsForCourse(int courseId)
        {
            var examsForCourse = _uniDbContext.Exams
               .Where(exam => exam.CourseId == courseId)
               .ToList();

            return examsForCourse;
        }

        public void UpdateCourse(Course course)
        {
            _uniDbContext.Update(course);
            _uniDbContext.SaveChanges();
        }
    }
}
