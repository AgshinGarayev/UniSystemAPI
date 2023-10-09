using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniSystem2API.BLL.Abstract;
using UniSystem2API.DTOS.EnrollmentDtos;
using UniSystem2API.Entities;

namespace UniSystem2API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniEnrollmentController : ControllerBase
    {
        private readonly IUniSystemEnrollmentService _enrollmentService;
        private readonly IUniSystemStudentService _studentService;
        private readonly IUniSystemCourseService _courseService;

        public UniEnrollmentController(IUniSystemEnrollmentService enrollmentService, IUniSystemStudentService studentService, IUniSystemCourseService courseService)
        {
            _enrollmentService = enrollmentService;

            _studentService = studentService;
            _courseService = courseService;

        }

        [HttpGet]
        [Route("enrollments")]
        public IActionResult GetEnrollments()
        {

            return Ok(_enrollmentService.GetAllEnrollments());

        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult EnrollStudent([FromBody] Enrollment enrollmentRequest)
        {
            try
            {
                var student = _studentService.GetStudentById(enrollmentRequest.StudentId);
                if (student == null)
                {
                    return BadRequest("Student not found.");
                }


                var course = _courseService.GetCourseById(enrollmentRequest.CourseId);
                if (course == null)
                {
                    return BadRequest("Course not found.");
                }

                _enrollmentService.EnrollStudentInCourse(enrollmentRequest.StudentId, enrollmentRequest.CourseId);

                return Ok("Student enrolled successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while processing the request.");
            }
        }

        [HttpDelete]
        [Route("students/{studentId}/courses/{courseId}")]
        public IActionResult RemoveStudentFromCourse(int studentId, int courseId)
        {
            _enrollmentService.RemoveStudentFromCourse(studentId, courseId);

            return Ok($"Student with ID {studentId} removed from course with ID {courseId}.");
        }

        [HttpPut]
        [Route("[action]/{id}")]
        public IActionResult UpdateEnrollment([FromRoute] int id, [FromBody] EnrollmentToUpdateDto dto)
        {
            _enrollmentService.UpdateEnrollment(id, dto);
            return Ok();
        }


        [HttpGet]
        [Route("enrollmentofstudent/{id}")]
        public IActionResult GetEnrollmentByStudentId(int studentId)
        {
            var enrollment = _enrollmentService.GetEnrollmentsByStudentId(studentId);
            return Ok();
        }

        [HttpGet]
        [Route("enrollmentofcourse/{id}")]
        public IActionResult GetEnrollmentByCourseId(int courseId)
        {
            var enrollment = _enrollmentService.GetEnrollmentsByCourseId(courseId);
            return Ok();
        }


    }

}
