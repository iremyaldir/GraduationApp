using GraduationApp.Application.UnitOfWork;
using GraduationApp.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduationApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
     public class UserController : ControllerBase
     {
            private readonly IUnitOfWork unitOfWork;

            public UserController(IUnitOfWork unitOfWork)
            {
                this.unitOfWork = unitOfWork;
            }

            [HttpGet]
            public async Task<IActionResult> GetAll()
            {
                var _data = await this.unitOfWork.UserRepository.GetAllAsync();
                return Ok(_data);
            }

            [HttpGet("GetById/{id}")]
            public async Task<IActionResult> GetById(int id)
            {
                var _data = await this.unitOfWork.UserRepository.GetAsync(id);
                return Ok(_data);
            }

            [HttpPost("Create")]
            public async Task<IActionResult> Create(User user)
            {
                var _data = await this.unitOfWork.UserRepository.AddEntity(user);
                await this.unitOfWork.CompleteAsync();
                return Ok(_data);
            }

            [HttpPut("Update")]
            public async Task<IActionResult> Update(User user)
            {
                var _data = await this.unitOfWork.UserRepository.UpdateEntity(user);
                await this.unitOfWork.CompleteAsync();
                return Ok(_data);
            }

            [HttpDelete("Remove")]
            public async Task<IActionResult> Remove(int id)
            {
                var _data = await this.unitOfWork.UserRepository.DeleteEntity(id);
                await this.unitOfWork.CompleteAsync();
                return Ok(_data);
            }
     }
}
