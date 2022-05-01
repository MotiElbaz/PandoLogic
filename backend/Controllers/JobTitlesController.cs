using AutoMapper;
using backend.DTOs;
using backend.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobTitlesController : ControllerBase
    {

        private readonly IJobsRepo jobsRepository;

        private readonly IMapper mapper;

        public JobTitlesController(IJobsRepo jobsRepository, IMapper mapper)
        {
            this.jobsRepository = jobsRepository;
            this.mapper = mapper;
        }

        // GET: api/JobTitles
        [HttpGet]
        public ActionResult<IEnumerable<JobTitleDTO>> GetAllJobTitles()
        {
            var JobsTitles = jobsRepository.GetAllJobTitles();
            return Ok(mapper.Map<IEnumerable<JobTitleDTO>>(JobsTitles));
        }

        // GET api/JobTitles/5/jobs
        [HttpGet("{JobTitleID}/jobs")]
        public ActionResult<IEnumerable<JobDTO>> GetAllJobsByJobTitleID(int JobTitleID)
        {
            var AllJobs = jobsRepository.GetAllJobsByJobTitleID(JobTitleID);
            if (AllJobs.Count() <= 0)
            {
                return NotFound();
            }
            return Ok(AllJobs);
        }

    }
}
