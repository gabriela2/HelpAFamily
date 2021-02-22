using HelpAFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Repositories.UserRepository
{
    interface IUserRepository
    {
        List<User> GetAll();
        User Get(int Id);
        User Create(User User);
        User Update(User User);
        User Delete(User User);
    }
}
