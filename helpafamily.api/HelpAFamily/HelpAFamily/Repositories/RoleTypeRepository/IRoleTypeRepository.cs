using HelpAFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Repositories.RoleTypeRepository
{
    interface IRoleTypeRepository
    {
        List<RoleType> GetAll();
        RoleType Get(int Id);
        RoleType Create(RoleType RoleType);
        RoleType Update(RoleType RoleType);
        RoleType Delete(RoleType RoleType);

    }

}
