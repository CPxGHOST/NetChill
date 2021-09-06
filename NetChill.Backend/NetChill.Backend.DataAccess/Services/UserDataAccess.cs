using NetChill.Backend.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace NetChill.Backend.DataAccess.Services
{
    public class UserDataAccess : IUserDataAccess
    {

        private readonly NetChillDbContext _context;

        public UserDataAccess()
        {
            this._context = new NetChillDbContext();
        }


        /// <inheritdoc cref="IUserDataAccess.AddUser(User)"/>
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

        /// <inheritdoc cref="IUserDataAccess.DoesUserExist(User)" />
        public bool DoesUserExist(User user)
        {
            try
            {
                var userToBeFound = this._context.Users.Find(user);
                return userToBeFound != null;
            }
            catch (Exception exception) 
            {
                Console.WriteLine(exception);
                return false;
            }
        }

        /// <inheritdoc cref="IUserDataAccess.GetUserById(Guid)"/>
        public User GetUserById(Guid id)
        {
            try
            {
                return _context.Users.FirstOrDefault(u => u.Id.Equals(id));
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception);
                return null;
            }

        }

        /// <inheritdoc cref="IUserDataAccess.GetUserByEmail(string)"/>
        public User GetUserByEmail(string email)
        {
            return _context.Users.FirstOrDefault(u => u.Email.Equals(email));
        }

        /// <inheritdoc cref="IUserDataAccess.UpdateUser(User)"/>
        public void UpdateUser(User user)
        {
            try
            {
                var entry = _context.Entry(user);
                entry.State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        public IEnumerable<User> GetAllUsers()
        {
            try
            {
                return this._context.Users.OrderBy(user => user.Id);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return null;
            }
        }
    }
}
