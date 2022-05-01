using backend.DTOs;
using backend.Models;
using System.Collections.Generic;

namespace backend.Repositories
{
    public interface IJobsRepo
    {

        IEnumerable<JobTitle> GetAllJobTitles();

        IEnumerable<JobDTO> GetAllJobsByJobTitleID(int JobTitleID);

    }
}
