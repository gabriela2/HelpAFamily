using HelpAFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Repositories.CategoryRepository
{
    interface ICategoryRepository
    {
        List<Category> GetAll();
        Category Get(int Id);
        Category Create(Category Category);
        Category Update(Category Category);
        Category Delete(Category Category);
    }
}
