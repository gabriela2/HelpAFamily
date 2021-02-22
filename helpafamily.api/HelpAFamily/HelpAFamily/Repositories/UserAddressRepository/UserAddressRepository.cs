using HelpAFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Repositories.UserAddressRepository
{
    public class UserAddressRepository : IUserAddressRepository
    {
        DataContext _context { get; set; }
        public UserAddressRepository(DataContext context)
        {
            _context = context;
        }

        public UserAddress Create(UserAddress UserAddress)
        {
            var result = _context.Add<UserAddress>(UserAddress);
            _context.SaveChanges();
            return result.Entity;
        }

        public UserAddress Delete(UserAddress UserAddress)
        {
            var result = _context.Remove(UserAddress);
            _context.SaveChanges();
            return result.Entity;
        }

        public UserAddress Get(int Id)
        {
            return _context.UserAddresses.SingleOrDefault(x => x.Id == Id);
        }

        public List<UserAddress> GetAll()
        {
            return _context.UserAddresses.ToList();
        }

        public UserAddress Update(UserAddress UserAddress)
        {
            _context.Entry(UserAddress).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return UserAddress;
        }
    }
}
