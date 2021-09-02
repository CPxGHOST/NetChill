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
        private readonly NetChillDbContext netChillDbContext;

        public UserDataAccess()
        {
            this.netChillDbContext = new NetChillDbContext();
        }


        /// <inheritdoc cref="IUserDataAccess.DoesUserExist(User)"/>
        public bool AddUser(User user)
        {
            try
            {
                this.netChillDbContext.Users.Add(user);
                this.netChillDbContext.SaveChanges();
                return true;

            }
            catch (Exception exception) {
                Console.WriteLine(exception.Message);
                return false;
            }
        }

        /// <inheritdoc cref="IUserDataAccess.DoesUserExist(User)" />
        public bool DoesUserExist(User user)
        {
            try
            {
                var userToBeFound = this.netChillDbContext.Users.Find(user);
                return userToBeFound != null;
            }
            catch (Exception exception) {
                Console.WriteLine(exception);
                return false;
            }
        }
    }
}
