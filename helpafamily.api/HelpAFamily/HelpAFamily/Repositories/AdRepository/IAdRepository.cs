using HelpAFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Repositories.AdRepository
{
    interface IAdRepository
    {
        List<Ad> GetAll();
        Ad Get(int Id);
        Ad Create(Ad Ad);
        Ad Update(Ad Ad);
        Ad Delete(Ad Ad);
    }
}
