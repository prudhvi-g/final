using Online_E_Grocecry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_E_Grocecry.Core.Interface
{
   public interface IUser
    {
        List<User>displayUser();
        User Post(User user);
        User Put(User user);
        Task<User> Login(string email, int passWord);
        bool Delete(int userId);
    }
}
