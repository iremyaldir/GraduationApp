using GraduationApp.Application.UnitOfWork;
using GraduationApp.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduationApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncementController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public AnnouncementController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var _data = await this.unitOfWork.AnnouncementRepository.GetAllAsync();
            return Ok(_data);
        }
        
        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var _data = await this.unitOfWork.AnnouncementRepository.GetAsync(id);
            return Ok(_data);
        }
        
        [HttpPost("Create")]
        public async Task<IActionResult> Create(Announcement announcement)
        {
            var _data = await this.unitOfWork.AnnouncementRepository.AddEntity(announcement);
            await this.unitOfWork.CompleteAsync();
            return Ok(_data);
        }
        
        [HttpPut("Update")]
        public async Task<IActionResult> Update(Announcement announcement)
        {
            var _data = await this.unitOfWork.AnnouncementRepository.UpdateEntity(announcement);
            await this.unitOfWork.CompleteAsync();
            return Ok(_data);
        }
        
        [HttpDelete("Remove")]
        public async Task<IActionResult> Remove(int id)
        {
            var _data = await this.unitOfWork.AnnouncementRepository.DeleteEntity(id);
            await this.unitOfWork.CompleteAsync();
            return Ok(_data);
        }

    }
}
