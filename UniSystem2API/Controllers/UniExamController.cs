using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniSystem2API.BLL.Abstract;
using UniSystem2API.DTOS.ExamDtos;

namespace UniSystem2API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniExamController : ControllerBase
    {
        private IUniSystemExamService _examService;
        public UniExamController(IUniSystemExamService examService)
        {
            _examService = examService;
        }



        [HttpGet]
        [Route("exams")]
        public IActionResult GetExams()
        {
            return Ok(_examService.GetAllExams());
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult PostExam([FromBody] ExamToAddDto dto)
        {
            _examService.AddExam(dto);
            return Ok();
        }

        [HttpPut]
        [Route("[action]")]
        public IActionResult UpdateExam([FromRoute] int id, [FromBody] ExamToUpdateDto dto)
        {
            _examService.UpdateExam(id, dto);
            return Ok();
        }

        [HttpDelete]
        public void DeleteExam(int id)
        {
            _examService.DeleteExam(id);
        }

        [HttpGet]
        [Route("exam/{id}")]
        public IActionResult GetExamById(int id)
        {
            return Ok(_examService.GetExamById(id));
        }

        [HttpGet]
        [Route("CourseAvarageScore/{courseId}")]
        public double CalculateAverageScoreForCourse(int courseId)
        {
            return _examService.CalculateAverageScoreForCourse(courseId);
        }




    }
}
