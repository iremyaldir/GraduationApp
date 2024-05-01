using GraduationApp.Application.UnitOfWork;
using GraduationApp.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduationApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public RoleController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var _data = await this.unitOfWork.RoleRepository.GetAllAsync();
            return Ok(_data);
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var _data = await this.unitOfWork.RoleRepository.GetAsync(id);
            return Ok(_data);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(Role role)
        {
            var _data = await this.unitOfWork.RoleRepository.AddEntity(role);
            await this.unitOfWork.CompleteAsync();
            return Ok(_data);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(Role role)
        {
            var _data = await this.unitOfWork.RoleRepository.UpdateEntity(role);
            await this.unitOfWork.CompleteAsync();
            return Ok(_data);
        }

        [HttpDelete("Remove")]
        public async Task<IActionResult> Remove(int id)
        {
            var _data = await this.unitOfWork.RoleRepository.DeleteEntity(id);
            await this.unitOfWork.CompleteAsync();
            return Ok(_data);
        }
    }
}
