using HelpAFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Repositories.AddressRepository
{
    interface IAddressRepository
    {
        List<Address> GetAll();
        Address Get(int Id);
        Address Create(Address Address);
        Address Update(Address Address);
        Address Delete(Address Address);
    }
}
