using NetChill.Backend.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetChill.Backend.DataAccess.Services
{
    public interface IUserDataAccess
    {
        bool DoesUserExist(User user);
        bool AddUser(User user);
        User GetUserById(Guid id);
        void UpdateUser(User user);
    }
}
