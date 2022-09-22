using Silver.WebApps.Repository;
using Silver.WebApps.ViewModels;

namespace Silver.WebApps.Services
{
    public interface IStudentService
    {
        List<StudentViewModel> Getall();

        int GetCount();
    }

    public class StudentService : IStudentService
    {
        private readonly IStudentRepository studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public int GetCount()
        {
            return studentRepository.GetAll().Count();
        }

        public List<StudentViewModel> Getall()
        {
            var data = studentRepository.GetAll();

            var ret = data.Select(p => new StudentViewModel()
            {
                Id = p.Id,
                Name = p.Name,
                Email = p.Email
            }).ToList();

            return ret;
        }
    }
}