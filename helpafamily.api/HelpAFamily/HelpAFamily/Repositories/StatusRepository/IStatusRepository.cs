using HelpAFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Repositories.StatusRepository
{
    interface IStatusRepository
    {
        List<Status> GetAll();
        Status Get(int Id);
        Status Create(Status Status);
        Status Update(Status Status);
        Status Delete(Status Status);
    }

}
