using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniSystem2API.BLL.Abstract;
using UniSystem2API.DTOS.InstructorDtos;

namespace UniSystem2API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniInstructorController : ControllerBase
    {
        private IUniSystemInstructorService _instructorService;
        public UniInstructorController(IUniSystemInstructorService instructorService)
        {
            _instructorService = instructorService;
        }


        [HttpGet]
        [Route("instructors")]
        public IActionResult GetStudents()
        {
            return Ok(_instructorService.GetAllInstructors());
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult PostInstructors([FromBody] InstructorToAddDto dto)
        {
            _instructorService.AddInstructor(dto);
            return Ok();
        }

        [HttpPut]
        [Route("[action]")]
        public IActionResult UpdateInstructor([FromRoute] int id, [FromBody] InstructorToUpdateDto dto)
        {
            _instructorService.UpdateInstructor(id, dto);
            return Ok();
        }

        [HttpDelete]
        public void DeleteInstructor(int id)
        {
            _instructorService.DeleteInstructor(id);
        }

        [HttpGet]
        [Route("instructor/{id}")]
        public IActionResult GetInstructorById(int id)
        {
            return Ok(_instructorService.GetInstructorById(id));
        }


    }
}
