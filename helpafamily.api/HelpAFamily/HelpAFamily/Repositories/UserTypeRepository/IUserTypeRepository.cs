using HelpAFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Repositories.UserTypeRepository
{
    interface IUserTypeRepository
    {
        List<UserType> GetAll();
        UserType Get (int Id);
        UserType Create (UserType UserType);
        UserType Update (UserType UserType);
        UserType Delete (UserType UserType);

    }
}
