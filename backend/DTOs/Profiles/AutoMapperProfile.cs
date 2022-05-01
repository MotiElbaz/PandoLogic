using AutoMapper;
using backend.Models;

namespace backend.DTOs.Profiles
{
    public class AutoMapperProfile : Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<Job, JobDTO>();
            CreateMap<JobTitle, JobTitleDTO>();
        }

    }
}
