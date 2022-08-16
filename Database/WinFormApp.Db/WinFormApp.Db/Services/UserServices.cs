using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp.Db.Services
{
    public class UserServices
    {
        private readonly DefaultContext db = new DefaultContext();

        public (bool, string) Login(string username, string password)
        {
            try
            {
                //check if the user exists
                var existingUser = db.UserInfos.FirstOrDefault(x => x.Username == username);
                if (existingUser == null)
                    return (false, "User not found");

                //check the password
                if (existingUser.Password != password)
                    return (false, "Password not matched");

                return (true, "Login successful");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}