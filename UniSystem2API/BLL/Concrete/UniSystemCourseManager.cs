using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSystem2API.BLL.Abstract;
using UniSystem2API.DAL.Abstract;
using UniSystem2API.DTOS.CourseDTOs;
using UniSystem2API.Entities;

namespace UniSystem2API.BLL.Concrete
{
    public class UniSystemCourseManager : IUniSystemCourseService
    {
        private readonly IUniSystemCourseRepository _courseRepository;
        private readonly IMapper _mapper;   

        public UniSystemCourseManager(IUniSystemCourseRepository courseRepository, IMapper mapper) {
            _courseRepository = courseRepository;
            _mapper = mapper;
        
        }

        public void AddCourse(CourseToAddDto dto)
        {
            var entity = _mapper.Map<Course>(dto);
            _courseRepository.AddCourse(entity);
        }

        public double CalculateCourseAverageScore(int courseId)
        {
            return _courseRepository.CalculateCourseAverageScore(courseId);
        }

        public void DeleteCourse(int id)
        {
            _courseRepository.DeleteCourse(id);
        }

        public List<CourseToListDto> GetAllCourses()
        {
            var entities = _courseRepository.GetAllCourses();
            return _mapper.Map<List<CourseToListDto>>(entities);
        }

        public Course GetCourseById(int id)
        {
            var entity = _courseRepository.GetCourseById(id);
            _mapper.Map<CourseToListDto>(entity);
            return entity;
        }

        public IEnumerable<Exam> GetExamsForCourse(int courseId)
        {
            return _courseRepository.GetExamsForCourse(courseId);
        }

        public void UpdateCourse(int id, CourseToUpdateDto dto)
        {
            Course course = _mapper.Map<Course>(dto);
            course.CourseId = id;
            _courseRepository.UpdateCourse(course);
        }
    }
}
