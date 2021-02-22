using HelpAFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Repositories.StatusRepository
{
    public class StatusRepository : IStatusRepository
    {
        public DataContext _context { get; set; }
        public StatusRepository(DataContext context)
        {
            _context = context;
        }


        public Status Create(Status Status)
        {
            var result = _context.Add<Status>(Status);
            _context.SaveChanges();
            return result.Entity;
        }

        public Status Delete(Status Status)
        {
            var result = _context.Remove(Status);
            _context.SaveChanges();
            return result.Entity;
        }

        public Status Get(int Id)
        {
            return _context.Statuses.SingleOrDefault(x => x.Id == Id);
        }

        public List<Status> GetAll()
        {
            return _context.Statuses.ToList();
        }

        public Status Update(Status Status)
        {
            _context.Entry(Status).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Status;
        }
    }
}
