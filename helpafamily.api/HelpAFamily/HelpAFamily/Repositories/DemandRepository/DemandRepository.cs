using HelpAFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Repositories.DemandRepository
{
    public class DemandRepository : IDemandRepository
    {
        public DataContext _context { get; set; }
        public DemandRepository(DataContext context)
        {
            _context = context;
        }


        public Demand Create(Demand Demand)
        {
            var result = _context.Add<Demand>(Demand);
            _context.SaveChanges();
            return result.Entity;
        }

        public Demand Delete(Demand Demand)
        {
            var result = _context.Remove(Demand);
            _context.SaveChanges();
            return result.Entity;
        }

        public Demand Get(int Id)
        {
            return _context.Demands.SingleOrDefault(x => x.Id == Id);
        }

        public List<Demand> GetAll()
        {
            return _context.Demands.ToList();
        }

        public Demand Update(Demand Demand)
        {
            _context.Entry(Demand).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Demand;
        }
    }
}
