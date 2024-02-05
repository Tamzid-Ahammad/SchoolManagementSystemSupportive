using Microsoft.AspNetCore.Mvc;
using SchoolApp.Core.IServices;
using SchoolApp.Core.ViewModels;

namespace SchoolApiService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController(IDepartmentService departmentService) : ControllerBase
    {
        [HttpGet("get")]
        public async Task<IEnumerable<DepartmentResource>> Get() =>
            await departmentService.Get();


        [HttpPost("create")]
        public async Task Create([FromBody] SaveDepartmentResource model)
        {
            // Here you can check some validation before create.
            // You can use fluentValidation for model validation
            await departmentService.Create(model); 
            // The create function returns new created record
            // You can use the return value if you want
        }

        [HttpPut("update/{id}")]
        public async Task Update(int id, [FromBody] UpdateDepartmentResource model)
        {
            var department = await departmentService.Get(id) ?? throw new InvalidOperationException("Department not found");
            await departmentService.Update(department, model);
        }

        [HttpDelete("delete/{id}")]
        public async Task Delete(int id)
        {
            var department = await departmentService.Get(id) ?? throw new InvalidOperationException("Department not found");
            await departmentService.Delete(department);
        }
    }
}
