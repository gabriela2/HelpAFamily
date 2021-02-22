using HelpAFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Repositories.UserRepository
{
    public class UserRepository : IUserRepository
    {
        public DataContext _context { get; set; }
        public UserRepository( DataContext context)
        {
            _context = context;
        }


        public User Create(User User)
        {
            var result = _context.Add<User>(User);
            _context.SaveChanges();
            return result.Entity;
        }

        public User Delete(User User)
        {
            var result = _context.Remove(User);
            _context.SaveChanges();
            return result.Entity;
        }

        public User Get(int Id)
        {
            return _context.Users.SingleOrDefault(x => x.Id == Id);
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User Update(User User)
        {
            _context.Entry(User).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return User;
        }
    }
}
