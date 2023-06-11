using Domain.Entity;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]

public class JobController:ControllerBase
{
    private readonly JobService _jobService;

    public JobController(JobService jobService)
    {
        _jobService = jobService;
    }

    [HttpGet("GetJobs")]
    public async Task<List<Job>> GetJobAsync()
    {
        return await _jobService.GetJobAsync();
    }
    
    //GetByIdController
    [HttpGet("GetbyId")]
    public async Task<Job> GetJobAsync(int id)
    {
        return await _jobService.GetJobAsync(id);
    }
    //AddJobController
    [HttpPost("AddJob")]
    public async Task<Job> AddJobAsync(Job job)
    {
        return await _jobService.AddJobAsync(job);
    }

    [HttpPut("UpdateJob")]
    public async Task<Job> UpdateJobAsync(Job job)
    {
        return await _jobService.UpdateJobAsync(job);
    }
    //DeleteJobController
    [HttpDelete("DeleteJob")]
    public async Task<bool> DeleteJob(int id)
    {
        return await _jobService.DeleteJob (id);
    }
}