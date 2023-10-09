using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniSystem2API.BLL.Abstract;
using UniSystem2API.DTOS.TuitionDtos;

namespace UniSystem2API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniTuitionController : ControllerBase
    {
        private IUniSystemTuitionService _tuitionService;
        public UniTuitionController(IUniSystemTuitionService tuitionService)
        {
            _tuitionService = tuitionService;
        }


        [HttpGet]
        [Route("tuitions")]
        public IActionResult GetStudents()
        {
            return Ok(_tuitionService.GetAllTuitions());
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult PostTuitions([FromBody] TuitionToAddDto dto)
        {
            _tuitionService.AddTuition(dto);
            return Ok();
        }

        [HttpPut]
        [Route("[action]")]
        public IActionResult UpdateTuition([FromRoute] int id, [FromBody] TuitionToUpdateDto dto)
        {
            _tuitionService.UpdateTuition(id, dto);
            return Ok();
        }

        [HttpDelete]
        public void DeleteTuition(int id)
        {
            _tuitionService.DeleteTuition(id);
        }

        [HttpGet]
        [Route("tuition/{id}")]
        public IActionResult GetTuitionById(int id)
        {
            return Ok(_tuitionService.GetTuitionById(id));
        }






    }
}
