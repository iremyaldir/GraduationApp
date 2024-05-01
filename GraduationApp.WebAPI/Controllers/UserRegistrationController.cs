using GraduationApp.Application.UnitOfWork;
using GraduationApp.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduationApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRegistrationController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public UserRegistrationController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var _data = await this.unitOfWork.UserRegistrationRepository.GetAllAsync();
            return Ok(_data);
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var _data = await this.unitOfWork.UserRegistrationRepository.GetAsync(id);
            return Ok(_data);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(UserRegistration userRegistration)
        {
            var _data = await this.unitOfWork.UserRegistrationRepository.AddEntity(userRegistration);
            await this.unitOfWork.CompleteAsync();
            return Ok(_data);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(UserRegistration userRegistration)
        {
            var _data = await this.unitOfWork.UserRegistrationRepository.UpdateEntity(userRegistration);
            await this.unitOfWork.CompleteAsync();
            return Ok(_data);
        }

        [HttpDelete("Remove")]
        public async Task<IActionResult> Remove(int id)
        {
            var _data = await this.unitOfWork.UserRegistrationRepository.DeleteEntity(id);
            await this.unitOfWork.CompleteAsync();
            return Ok(_data);
        }
    }
}
