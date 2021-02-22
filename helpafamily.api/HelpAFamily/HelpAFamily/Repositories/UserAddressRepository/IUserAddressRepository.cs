using HelpAFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Repositories.UserAddressRepository
{
    interface IUserAddressRepository
    {
        List<UserAddress> GetAll();
        UserAddress Get(int Id);
        UserAddress Create(UserAddress UserAddress);
        UserAddress Update(UserAddress UserAddress);
        UserAddress Delete(UserAddress UserAddress);
    }
}
