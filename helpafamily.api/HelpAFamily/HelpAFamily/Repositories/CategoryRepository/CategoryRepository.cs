using HelpAFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Repositories.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        public DataContext _context { get; set; }
        public CategoryRepository(DataContext context)
        {
            _context = context;
        }

        public Category Create(Category Category)
        {
            var result = _context.Add<Category>(Category);
            _context.SaveChanges();
            return result.Entity;
        }

        public Category Delete(Category Category)
        {
            var result = _context.Remove(Category);
            _context.SaveChanges();
            return result.Entity;
        }

        public Category Get(int Id)
        {
            return _context.Categories.SingleOrDefault(x => x.Id == Id);
        }

        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }

        public Category Update(Category Category)
        {
            _context.Entry(Category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Category;
        }
    }
}
