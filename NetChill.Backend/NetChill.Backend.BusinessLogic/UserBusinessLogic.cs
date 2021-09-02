using NetChill.Backend.DataAccess.Services;
using NetChill.Backend.Domain;
using System;

namespace NetChill.Backend.BusinessLogic
{
    public class UserBusinessLogic
    {
        private readonly IUserDataAccess _userDataAccess;
        public UserBusinessLogic()
        {
            this._userDataAccess = new UserDataAccess();
        }

        public bool DoesUserExist(User user)
        {
            return _userDataAccess.DoesUserExist(user);
        }

        public void AddUser(User user)
        {
            _userDataAccess.AddUser(user);
        }

        public User GetUserById(Guid id)
        {
            return _userDataAccess.GetUserById(id);
        }

        public void UpdateUser(User user)
        {
            _userDataAccess.UpdateUser(user);
        }
    }
}
 