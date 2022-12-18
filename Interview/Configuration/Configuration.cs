using AutoMapper;
using Data.DTO;
using Data.Models;
using System.Diagnostics.Metrics;

namespace Interview.Configuration
{
    public class Configuration:Profile
    {
        public Configuration()
        {
            CreateMap<Interviewee, IntervieweeDTO>().ReverseMap();
            CreateMap<IEnumerable<Interviewee>, IEnumerable<Interviewee>>().ReverseMap();
            CreateMap<Interviewer, AddInterviewerDTO>().ReverseMap();
            CreateMap<IEnumerable<Interviewer>, IEnumerable<Interviewer>>().ReverseMap();

        }
    }
}
