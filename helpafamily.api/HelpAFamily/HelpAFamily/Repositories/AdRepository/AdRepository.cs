using HelpAFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Repositories.AdRepository
{
    public class AdRepository : IAdRepository
    {
        public DataContext _context { get; set; }
        public AdRepository(DataContext context)
        {
            _context = context;
        }


        public Ad Create(Ad Ad)
        {
            var result = _context.Add<Ad>(Ad);
            _context.SaveChanges();
            return result.Entity;
        }

        public Ad Delete(Ad Ad)
        {
            var result = _context.Remove(Ad);
            _context.SaveChanges();
            return result.Entity;
        }

        public Ad Get(int Id)
        {
            return _context.Ads.SingleOrDefault(x => x.Id == Id);
        }

        public List<Ad> GetAll()
        {
            return _context.Ads.ToList();
        }

        public Ad Update(Ad Ad)
        {
            _context.Entry(Ad).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Ad;
        }
    }
}
