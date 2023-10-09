using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniSystem2API.BLL.Abstract;
using UniSystem2API.DTOS.CourseDTOs;

namespace UniSystem2API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniCourseController : ControllerBase
    {
        private IUniSystemCourseService _courseService;

        public UniCourseController(IUniSystemCourseService courseService)
        {
            _courseService = courseService;
        
        }



        [HttpGet]
        [Route("courses")]
        public IActionResult GetCourses()
        {
            return Ok(_courseService.GetAllCourses());

        }



        [HttpGet("{id}")]
        public IActionResult GetCoursesById(int id)
        {
            var user = _courseService.GetCourseById(id);
             return Ok(user);

        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult PostCourse([FromBody] CourseToAddDto dto)
        {
            _courseService.AddCourse(dto);
            return Ok();
        }

        [HttpPut]
        [Route("[action]/{id}")]
        public IActionResult UpdateCourse([FromRoute] int id , [FromBody] CourseToUpdateDto dto)
        {
            _courseService.UpdateCourse(id, dto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public void DeleteCourse(int id)
        {
            _courseService.DeleteCourse(id);
        }

        [HttpGet]
        [Route("{courseId}/averageScore")]
        public IActionResult CalculateCourseAverageScore(int courseId)
        {
            try
            {


                double averageScore = _courseService.CalculateCourseAverageScore(courseId);

                if (averageScore >= 0)
                {
                    return Ok($"Average score for course with ID {courseId}: {averageScore}");
                }
                else
                {
                    return NotFound("No exam results found for this course.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Code is not working, go study");
            }
        }
       
        
        [HttpGet]
        [Route("{courseId}/exams")]
        public IActionResult GetExamsForCourse(int courseId)
        {
            try
            {

                var examsForCourse = _courseService.GetExamsForCourse(courseId);

                if (examsForCourse != null && examsForCourse.Any())
                {
                    return Ok(examsForCourse);
                }
                else
                {
                    return NotFound("There is no exam for that");
                }
            }
            catch (Exception ex)
            {

                return StatusCode(500, "Fix the code");
            }
        }
    }
}
