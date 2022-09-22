using Silver.WebApps.Repository;
using Silver.WebApps.ViewModels;

namespace Silver.WebApps.Services
{
    public interface IAdminService
    {
        AdminAnalyticsViewModel GetAnalytics();
    }

    public class AdminService : IAdminService
    {
        private readonly IStudentService studentService;

        public AdminService(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        public AdminAnalyticsViewModel GetAnalytics()
        {
            var data = new AdminAnalyticsViewModel();
            data.StudentCount = studentService.GetCount();
            // data.TeacherCount=
            return data;
        }
    }
}