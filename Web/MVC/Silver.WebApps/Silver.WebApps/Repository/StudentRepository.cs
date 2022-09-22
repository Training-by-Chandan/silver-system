using Silver.WebApps.Data;
using Silver.WebApps.Models;

namespace Silver.WebApps.Repository
{
    public interface IStudentRepository
    {
        (bool, string) Create(Student model);

        (bool, string) Delete(Student model);

        (bool, string) Edit(Student model);

        IQueryable<Student> GetAll();

        Student? GetById(int Id);
    }

    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext db;

        public StudentRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IQueryable<Student> GetAll()
        {
            return db.Students;
        }

        public Student? GetById(int Id)
        {
            return db.Students.Find(Id);
        }

        public (bool, string) Create(Student model)
        {
            try
            {
                db.Students.Add(model);
                db.SaveChanges();

                return (true, "Added Successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool, string) Edit(Student model)
        {
            try
            {
                db.Students.Update(model);
                db.SaveChanges();

                return (true, "Updated Successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool, string) Delete(Student model)
        {
            try
            {
                db.Students.Remove(model);
                db.SaveChanges();

                return (true, "Deleted Successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}