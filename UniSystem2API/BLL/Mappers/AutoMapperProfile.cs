using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSystem2API.DTOS.CourseDTOs;
using UniSystem2API.DTOS.DepartmentDtos;
using UniSystem2API.DTOS.EnrollmentDtos;
using UniSystem2API.DTOS.ExamDtos;
using UniSystem2API.DTOS.ExamResultDtos;
using UniSystem2API.DTOS.InstructorDtos;
using UniSystem2API.DTOS.StudentDtos;
using UniSystem2API.DTOS.TuitionDtos;
using UniSystem2API.Entities;

namespace UniSystem2API.BLL.Mappers
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile() {
            //COURSE DTO MAP
            CreateMap<CourseToUpdateDto,Course>();
            CreateMap<CourseToAddDto,Course>();
            CreateMap<Course, CourseToListDto>();
            //Department DTO MAP
            CreateMap<DepartmentToUpdateDto, Department>();
            CreateMap<DepartmentToAddDto, Department>();
            CreateMap<Department, DepartmentToListDto>();
            //Enrollment DTO MAP
            CreateMap<EnrollmentToUpdateDto, Enrollment>();
            CreateMap<EnrollmentToAddDto, Enrollment>();
            CreateMap<Enrollment, EnrollmentToListDto>();
            //Exam DTO MAP
            CreateMap<ExamToUpdateDto, Exam>();
            CreateMap<ExamToAddDto, Exam>();
            CreateMap<Exam, ExamToListDto>();
            //ExamResult DTO MAP
            CreateMap<ExamResultToUpdateDto, ExamResult>();
            CreateMap<ExamResultToAddDto, ExamResult>();
            CreateMap<ExamResult, ExamResultToListDto>();
            //Instructor DTO MAP
            CreateMap<InstructorToUpdateDto, Instructor>();
            CreateMap<InstructorToAddDto, Instructor>();
            CreateMap<Instructor, InstructorToListDto>();
            //Student DTO MAP
            CreateMap<StudentToUpdateDto, Student>();
            CreateMap<StudentToAddDto, Student>();
            CreateMap<Student, StudentToListDto>();
            //Tuition DTO MAP
            CreateMap<TuitionToUpdateDto, Tuition>();
            CreateMap<TuitionToAddDto, Tuition>();
            CreateMap<Tuition, TuitionToListDto>();





        }
    }
}
