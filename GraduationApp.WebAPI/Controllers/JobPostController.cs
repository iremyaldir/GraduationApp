using GraduationApp.Application.UnitOfWork;
using GraduationApp.Domain.Entities;
using GraduationApp.Persistence.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduationApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobPostController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public JobPostController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }


        [HttpGet]

        public async Task<IActionResult> GetAll()
        {
            var _data = await this.unitOfWork.JobPostRepository.GetAllAsync();
            return Ok(_data);
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var _data = await this.unitOfWork.JobPostRepository.GetAsync(id);
            return Ok(_data);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(JobPost jobPost)
        {
            var _data = await this.unitOfWork.JobPostRepository.AddEntity(jobPost);
            await this.unitOfWork.CompleteAsync();
            return Ok(_data);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(JobPost jobPost)
        {
            var _data = await this.unitOfWork.JobPostRepository.UpdateEntity(jobPost);
            await this.unitOfWork.CompleteAsync();
            return Ok(_data);
        }

        [HttpDelete("Remove")]
        public async Task<IActionResult> Remove(int id)
        {
            var _data = await this.unitOfWork.JobPostRepository.DeleteEntity(id);
            await this.unitOfWork.CompleteAsync();
            return Ok(_data);
        }
    }
}
