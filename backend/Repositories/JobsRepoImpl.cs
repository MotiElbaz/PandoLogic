using backend.Data;
using backend.DTOs;
using backend.Models;
using System.Collections.Generic;
using System.Linq;

namespace backend.Repositories
{
    public class JobsRepoImpl : IJobsRepo
    {

        private readonly JobsContext jobsContext;

        public JobsRepoImpl(JobsContext jobsContext)
        {
            this.jobsContext = jobsContext;
        }

        public IEnumerable<JobDTO> GetAllJobsByJobTitleID(int JobTitleID)
        {
            return jobsContext.Jobs
                .Join(jobsContext.JobsTitles, job => job.JobTitleId, jobTitle => jobTitle.JobTitleId, (job, jobTitle) => new { job, jobTitle })
                .Where(j => j.job.JobTitleId == JobTitleID)
                .Select(j => new JobDTO() { JobId = j.job.JobId, JobTitleName = j.jobTitle.JobTitleName, City = j.job.City, State = j.job.State }).ToList();
        }

        public IEnumerable<JobTitle> GetAllJobTitles()
        {
            return jobsContext.JobsTitles.ToList();
        }
    }
}
