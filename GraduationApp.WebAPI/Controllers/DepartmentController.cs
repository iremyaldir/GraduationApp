using GraduationApp.Application.UnitOfWork;
using GraduationApp.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduationApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public DepartmentController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var _data = await this.unitOfWork.DepartmentRepository.GetAllAsync();
            return Ok(_data);
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var _data = await this.unitOfWork.DepartmentRepository.GetAsync(id);
            return Ok(_data);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(Department department)
        {
            var _data = await this.unitOfWork.DepartmentRepository.AddEntity(department);
            await this.unitOfWork.CompleteAsync();
            return Ok(_data);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(Department department)
        {
            var _data = await this.unitOfWork.DepartmentRepository.UpdateEntity(department);
            await this.unitOfWork.CompleteAsync();
            return Ok(_data);
        }

        [HttpDelete("Remove")]
        public async Task<IActionResult> Remove(int id)
        {
            var _data = await this.unitOfWork.DepartmentRepository.DeleteEntity(id);
            await this.unitOfWork.CompleteAsync();
            return Ok(_data);
        }
    }
}
