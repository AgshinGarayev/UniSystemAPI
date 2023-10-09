using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniSystem2API.BLL.Abstract;
using UniSystem2API.DTOS.DepartmentDtos;

namespace UniSystem2API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniDepartmentController : ControllerBase
    {
        private IUniSystemDepartmentService _departmentService;

        public UniDepartmentController(IUniSystemDepartmentService departmentService)
        {
            _departmentService = departmentService;

        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult PostDepartment([FromBody] DepartmentToAddDto dto)
        {
            _departmentService.AddDepartment(dto);
            return Ok();
        }

        [HttpPut]
        [Route("[action]/{id}")]
        public IActionResult UpdateDepartment([FromRoute] int id, [FromBody] DepartmentToUpdateDto dto)
        {
            _departmentService.UpdateDepartment(id, dto);
            return Ok();
        }
        [HttpGet]
        [Route("departments")]
        public IActionResult GetDepartments()
        {
            return Ok(_departmentService.GetAllDepartments());

        }

        [HttpDelete("{id}")]
        public void DeleteDepartment(int id)
        {
            _departmentService.DeleteDepartment(id);
        }


        [HttpGet("{id}")]
        public IActionResult GetDepartmentById(int id)
        {
            var department = _departmentService.GetDepartmentById(id);
            return Ok(department);



        }
    }
}
