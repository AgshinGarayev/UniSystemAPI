using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniSystem2API.BLL.Abstract;
using UniSystem2API.DTOS.ExamResultDtos;

namespace UniSystem2API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniExamResultController : ControllerBase
    {
        private IUniSystemExamResultService _examResultService;

        public UniExamResultController(IUniSystemExamResultService examResultService)
        {
            _examResultService = examResultService;
        }


        [HttpGet]
        [Route("ExamResults")]
        public IActionResult GetResults()
        {
            return Ok(_examResultService.GetAllExamResults());
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult PostResult([FromBody] ExamResultToAddDto dto)
        {
            _examResultService.AddExamResult(dto);
            return Ok();
        }

        [HttpPut]
        [Route("[action]")]
        public IActionResult UpdateResult([FromRoute] int id, [FromBody] ExamResultToUpdateDto dto)
        {
            _examResultService.UpdateExamResult(id, dto);
            return Ok();
        }

        [HttpDelete]
        public void DeleteResult(int id)
        {
            _examResultService.DeleteExamResult(id);
        }

        [HttpGet]
        [Route("result/{id}")]
        public IActionResult GetResultById(int id)
        {
            return Ok(_examResultService.GetExamResultById(id));
        }

        [HttpGet]
        [Route("{studentId}/examResults")]
        public IActionResult GetExamResultsForStudent(int studentId)
        {
            try
            {


                var examResultsForStudent = _examResultService.GetExamResultsForStudent(studentId);

                if (examResultsForStudent != null && examResultsForStudent.Any())
                {
                    return Ok(examResultsForStudent);
                }
                else
                {
                    return NotFound("No exam results found for this student.");
                }
            }
            catch (Exception ex)
            {

                return StatusCode(500, "An error occurred while processing the request.");
            }
        }

    }
}
