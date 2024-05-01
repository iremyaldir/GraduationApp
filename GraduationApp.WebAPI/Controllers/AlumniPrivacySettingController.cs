using GraduationApp.Application.UnitOfWork;
using GraduationApp.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduationApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumniPrivacySettingController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public AlumniPrivacySettingController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var _data = await this.unitOfWork.AlumniPrivacySettingRepository.GetAllAsync();
            return Ok(_data);
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var _data = await this.unitOfWork.AlumniPrivacySettingRepository.GetAsync(id);
            return Ok(_data);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(AlumniPrivacySetting alumniPrivacySetting)
        {
            var _data = await this.unitOfWork.AlumniPrivacySettingRepository.AddEntity(alumniPrivacySetting);
            await this.unitOfWork.CompleteAsync();
            return Ok(_data);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(AlumniPrivacySetting alumniPrivacySetting)
        {
            var _data = await this.unitOfWork.AlumniPrivacySettingRepository.UpdateEntity(alumniPrivacySetting);
            await this.unitOfWork.CompleteAsync();
            return Ok(_data);
        }

        [HttpDelete("Remove")]
        public async Task<IActionResult> Remove(int id)
        {
            var _data = await this.unitOfWork.AlumniPrivacySettingRepository.DeleteEntity(id);
            await this.unitOfWork.CompleteAsync();
            return Ok(_data);
        }
    }
}
