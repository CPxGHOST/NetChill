using NetChill.Server.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetChill.Server.DataAccess.Services
{
    public interface IUserDataAccess
    {
        /// <summary>
        /// Checks if the given users exists or not
        /// </summary>
        /// <param name="user">The user to be checked</param>
        /// <returns>True if user exists else false</returns>
        bool DoesUserExist(User user);

        /// <summary>
        /// Adds a user to the database
        /// </summary>
        /// <param name="user">The user to be added</param>
        /// <returns>True if we are successfully able to add the user else false</returns>
        bool AddUser(User user);
        User GetUserById(Guid id);
        void UpdateUser(User user);
    }
}
