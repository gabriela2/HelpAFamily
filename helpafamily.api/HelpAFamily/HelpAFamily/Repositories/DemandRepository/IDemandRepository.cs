using HelpAFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Repositories.DemandRepository
{
    interface IDemandRepository
    {
        List<Demand> GetAll();
        Demand Get(int Id);
        Demand Create(Demand Demand);
        Demand Update(Demand Demand);
        Demand Delete(Demand Demand);
    }
}
