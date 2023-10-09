using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniSystem2API.BLL.Abstract;
using UniSystem2API.DTOS.StudentDtos;

namespace UniSystem2API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniStudentController : ControllerBase
    {
        private IUniSystemStudentService _studentService;

        public UniStudentController(IUniSystemStudentService studentService)
        {
            _studentService = studentService;
            
        }


        [HttpGet]
        [Route("students")]
        public IActionResult GetStudents()
        {
            return Ok(_studentService.GetAllStudents());
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult PostStudent([FromBody] StudentToAddDto dto)
        {
            _studentService.AddStudent(dto);
            return Ok();
        }

        [HttpPut]
        [Route("[action]")]
        public IActionResult UpdateStudent([FromRoute]int id, [FromBody] StudentToUpdateDto dto)
        {
            _studentService.UpdateStudent(id, dto);
            return Ok();
        }

        [HttpDelete]
        public void DeleteStudent(int id)
        {
            _studentService.DeleteStudent(id);
        }

        [HttpGet]
        [Route("student/{id}")]
        public IActionResult GetStudentById(int id)
        {
            return Ok(_studentService.GetStudentById(id));
        }


        [HttpGet]
        [Route("students/unpaid")]
        public IActionResult GetStudentsUnpaid()
        {
            return Ok(_studentService.GetStudentsWithUnpaidTuition());

        }

    }
}
