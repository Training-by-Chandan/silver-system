namespace WinFormApp.Db.Services
{
    public abstract class BaseServices
    {
        protected readonly DefaultContext db = new DefaultContext();
    }
}