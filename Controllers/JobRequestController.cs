using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demo.Data;
using demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace demo.Controllers
{
    [Route("jobapi/[controller]")]
    [ApiController]
    public class JobRequestController : ControllerBase
    {
        private readonly DataContext _context;
        public JobRequestController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult> GetAllJob()
        {
            var Jobs = await _context.JobRequest.ToListAsync();
            return Ok(Jobs);
        }
         [HttpPost]
        public async Task<ActionResult<List<JobRequest>>> AddJobs(JobRequest Jobs)
        {
            _context.JobRequest.Add(Jobs);
            await _context.SaveChangesAsync();
                
            return Ok(await _context.JobRequest.ToListAsync());
        }
        [HttpPut]
        public async Task<ActionResult<List<JobRequest>>> UpdateJob(JobRequest updateJob)
        {
            var dbJob = await _context.JobRequest.FindAsync(updateJob.JobId);
            if (dbJob is null)
                return NotFound("Job not found");
            dbJob.JobId = updateJob.JobId;
            dbJob.ReqTime = updateJob.ReqTime;
            dbJob.EndTime = updateJob.EndTime;
            dbJob.UserId = updateJob.UserId;
            dbJob.DeptName = updateJob.DeptName;
            dbJob.StartPoint1 = updateJob.StartPoint1;
            dbJob.StartPoint2 = updateJob.StartPoint2;
            dbJob.StartPoint3 = updateJob.StartPoint3;
            dbJob.StartPoint4 = updateJob.StartPoint4;
            dbJob.EndPoint1 = updateJob.EndPoint1;
            dbJob.EndPoint2 = updateJob.EndPoint2;
            dbJob.EndPoint3 = updateJob.EndPoint3;
            dbJob.EndPoint4 = updateJob.EndPoint4;
            dbJob.JobStatusName = updateJob.JobStatusName;
            dbJob.MaterialType = updateJob.MaterialType;
            dbJob.UrgentType = updateJob.UrgentType;
            dbJob.PatientType = updateJob.PatientType;
            dbJob.PoterFname = updateJob.PoterFname;
            dbJob.Remark = updateJob.Remark;
            dbJob.QN = updateJob.QN;
            dbJob.QNName = updateJob.QNName;
            dbJob.QNAge = updateJob.QNAge;
            dbJob.QNSex = updateJob.QNSex;

            await _context.SaveChangesAsync();
                
            return Ok(await _context.JobRequest.ToListAsync());
        }
        [HttpDelete]
        public async Task<ActionResult<List<JobRequest>>> DeleteJobs(int id)
        {
            var dbJob = await _context.JobRequest.FindAsync(id);
            if (dbJob is null)
                return NotFound("hero not found");
            
            _context.JobRequest.Remove(dbJob);
            await _context.SaveChangesAsync();
                
            return Ok(await _context.JobRequest.ToListAsync());
        }
        
    }
}