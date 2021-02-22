using HelpAFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Repositories.RoleTypeRepository
{
    public class RoleTypeRepository : IRoleTypeRepository
    {
        public DataContext _context { get; set; }
        public RoleTypeRepository(DataContext context)
        {
            _context = context;
        }


        public RoleType Create(RoleType RoleType)
        {
            var result = _context.Add<RoleType>(RoleType);
            _context.SaveChanges();
            return result.Entity;
        }

        public RoleType Delete(RoleType RoleType)
        {
            var result = _context.Remove(RoleType);
            _context.SaveChanges();
            return result.Entity;
        }

        public RoleType Get(int Id)
        {
            return _context.RoleTypes.SingleOrDefault(x => x.Id == Id);

        }

        public List<RoleType> GetAll()
        {
            return _context.RoleTypes.ToList();
        }

        public RoleType Update(RoleType RoleType)
        {
            _context.Entry(RoleType).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return RoleType;
        }
    }
}
