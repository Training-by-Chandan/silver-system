namespace Silver.WebApps.ViewModels
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
    }

    public class AdminAnalyticsViewModel
    {
        public int StudentCount { get; set; }
        public int TeacherCount { get; set; }
    }
}