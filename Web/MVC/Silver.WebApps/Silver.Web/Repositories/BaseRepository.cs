using Microsoft.EntityFrameworkCore;
using Silver.Web.Data;
using Silver.Web.Models;

namespace Silver.Web.Repositories
{
    public interface IBaseRepository<T>
        where T : class
    {
        (bool, string) Create(T model);

        (bool, string) Delete(T model);

        (bool, string) Edit(T model);

        IQueryable<T> GetAll();

        T GetById(int Id);
    }

    public abstract class BaseRepository<T> : IBaseRepository<T>
        where T : class
    {
        protected readonly ApplicationDbContext db;
        protected DbSet<T> dbset;

        public BaseRepository(ApplicationDbContext db)
        {
            this.db = db;
            dbset = db.Set<T>();
        }

        public virtual IQueryable<T> GetAll()
        {
            return dbset;
        }

        public virtual T GetById(int Id)
        {
            return dbset.Find(Id);
        }

        public virtual (bool, string) Create(T model)
        {
            try
            {
                dbset.Add(model);
                db.SaveChanges();
                return (true, "Added successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public virtual (bool, string) Edit(T model)
        {
            try
            {
                dbset.Update(model);
                db.SaveChanges();
                return (true, "Updated successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public virtual (bool, string) Delete(T model)
        {
            try
            {
                dbset.Remove(model);
                db.SaveChanges();
                return (true, "Deleted successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}