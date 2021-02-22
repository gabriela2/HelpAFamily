using HelpAFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Repositories.PictureRepository
{
    public class PictureRepository : IPictureRepositry
    {
        public DataContext _context { get; set; }
        public PictureRepository(DataContext context)
        {
            _context = context;
        }


        public Picture Create(Picture Picture)
        {
            var result = _context.Add<Picture>(Picture);
            _context.SaveChanges();
            return result.Entity;
        }

        public Picture Delete(Picture Picture)
        {
            var result = _context.Remove(Picture);
            _context.SaveChanges();
            return result.Entity;
        }

        public Picture Get(int Id)
        {
            return _context.Pictures.SingleOrDefault(x => x.Id == Id);
        }

        public List<Picture> GetAll()
        {
            return _context.Pictures.ToList();
        }

        public Picture Update(Picture Picture)
        {
            _context.Entry(Picture).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Picture;
        }
    }
}
