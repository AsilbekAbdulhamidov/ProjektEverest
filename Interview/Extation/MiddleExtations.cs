using Interview;
using Interview;
using Interview.Repostory;

namespace Interview.Extation
{
    public static class MiddleExtations
    {//
        public static void AddService(this IServiceCollection services)
        {
            services.AddTransient<IInterviewerServices, InterviewerService>();
            services.AddTransient<IIntervieweeService, IntervieweeService>();
        }
        public static void AddRepostory(this IServiceCollection services)
        {
            services.AddTransient<IInterviewerRepo, InterviewerRepo>();
            services.AddTransient<IIntervieweeRepostory, IntervieweeRepostory>();
        }
    }
}
