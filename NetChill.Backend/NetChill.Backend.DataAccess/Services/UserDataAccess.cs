using NetChill.Backend.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetChill.Backend.DataAccess.Services
{
    public class UserDataAccess : IUserDataAccess
    {
        private readonly NetChillDbContext userData;

        public UserDataAccess()
        {
            this.userData = new NetChillDbContext();
        }

        public bool AddUser(User user)
        {
            try
            {
                this.userData.Users.Add(user);
                this.userData.SaveChanges();
                return true;

            }
            catch (Exception exception) {
                Console.WriteLine(exception.Message);
                return false;
            }
        }

        public bool DoesUserExist(User user)
        {
            try
            {
                var userToBeFound = this.userData.Users.Find(user);
                return userToBeFound != null;
            }
            catch (Exception exception) {
                Console.WriteLine(exception);
                return false;
            }
        }
    }
}
