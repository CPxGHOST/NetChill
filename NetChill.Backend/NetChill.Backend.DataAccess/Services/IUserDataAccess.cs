using NetChill.Backend.Domain;
using System;
using System.Collections.Generic;

namespace NetChill.Backend.DataAccess.Services
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        User GetUser(Guid id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        User GetUser(string email);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        void UpdateUser(User user);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerable<User> GetAllUsers();
    }
}
