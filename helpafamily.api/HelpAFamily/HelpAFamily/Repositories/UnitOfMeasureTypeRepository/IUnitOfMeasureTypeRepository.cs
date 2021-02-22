using HelpAFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Repositories.UnitOfMeasureTypeRepository
{
    interface IUnitOfMeasureTypeRepository
    {
        List<UnitOfMeasureType> GetAll();
        UnitOfMeasureType Get(int Id);
        UnitOfMeasureType Create(UnitOfMeasureType UnitOfMeasureType);
        UnitOfMeasureType Update(UnitOfMeasureType UnitOfMeasureType);
        UnitOfMeasureType Delete(UnitOfMeasureType UnitOfMeasureType);
        
    }

}
