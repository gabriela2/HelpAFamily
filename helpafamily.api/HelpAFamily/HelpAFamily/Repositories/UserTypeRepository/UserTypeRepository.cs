using HelpAFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Repositories.UserTypeRepository
{
    public class UserTypeRepository : IUserTypeRepository
    {
        public DataContext _context { get; set; }
        public UserTypeRepository(DataContext context)
        {
            _context = context;
        }



        public UserType Create(UserType UserType)
        {
            var result = _context.Add<UserType>(UserType);
            _context.SaveChanges();
            return result.Entity;
        }

        public UserType Delete(UserType UserType)
        {
            var result = _context.Remove(UserType);
            _context.SaveChanges();
            return result.Entity;
        }

        public UserType Get(int Id)
        {
            return _context.UserTypes.SingleOrDefault(x => x.Id == Id);
        }

        public List<UserType> GetAll()
        {
            return _context.UserTypes.ToList();
        }

        public UserType Update(UserType UserType)
        {
            _context.Entry(UserType).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return UserType;
        }
    }
}
