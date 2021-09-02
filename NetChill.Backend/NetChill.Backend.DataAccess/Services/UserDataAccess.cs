using NetChill.Backend.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetChill.Backend.DataAccess.Services
{
    public class UserDataAccess : IUserDataAccess
    {
        private readonly NetChillDbContext _context;

        public UserDataAccess()
        {
            this._context = new NetChillDbContext();
        }

        public bool AddUser(User user)
        {
            try
            {
                this._context.Users.Add(user);
                this._context.SaveChanges();
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
                var userToBeFound = this._context.Users.Find(user);
                return userToBeFound != null;
            }
            catch (Exception exception) {
                Console.WriteLine(exception);
                return false;
            }
        }

        public User GetUserById(Guid id)
        {
            return _context.Users.FirstOrDefault(u => u.Id.Equals(id));
        }

        public void UpdateUser(User user)
        {
            var entry = _context.Entry(user);
            entry.State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
