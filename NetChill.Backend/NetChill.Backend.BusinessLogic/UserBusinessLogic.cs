﻿using NetChill.Backend.DataAccess.Services;
using NetChill.Backend.Domain;
using System;
using System.Collections.Generic;

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

        public User GetUser(Guid id)
        {
            return _userDataAccess.GetUser(id);
        }

        public User GetUser(string email)
        {
            return _userDataAccess.GetUser(email);
        }

        public void UpdateUser(User user)
        {
            _userDataAccess.UpdateUser(user);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userDataAccess.GetAllUsers();
        }
    }
}
