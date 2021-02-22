using HelpAFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Repositories.UnitOfMeasureTypeRepository
{
    public class UnitOfMeasureTypeRepository : IUnitOfMeasureTypeRepository
    {
        public DataContext _context { get; set; }
        public UnitOfMeasureTypeRepository(DataContext context)
        {
            _context = context;
        }



        public UnitOfMeasureType Create(UnitOfMeasureType UnitOfMeasureType)
        {
            var result = _context.Add<UnitOfMeasureType>(UnitOfMeasureType);
            _context.SaveChanges();
            return result.Entity;
        }

        public UnitOfMeasureType Delete(UnitOfMeasureType UnitOfMeasureType)
        {
            var result = _context.Remove(UnitOfMeasureType);
            _context.SaveChanges();
            return result.Entity;
        }

        public UnitOfMeasureType Get(int Id)
        {
            return _context.UnitOfMeasureTypes.SingleOrDefault(x => x.Id == Id);
        }

        public List<UnitOfMeasureType> GetAll()
        {
            return _context.UnitOfMeasureTypes.ToList();
        }

        public UnitOfMeasureType Update(UnitOfMeasureType UnitOfMeasureType)
        {
            _context.Entry(UnitOfMeasureType).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return UnitOfMeasureType;
        }
    }

}
