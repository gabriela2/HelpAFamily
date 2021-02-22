using HelpAFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Repositories.AddressRepository
{
    public class AddressRepository : IAddressRepository
    {
        public DataContext _context { get; set; }
        public AddressRepository(DataContext context)
        {
            _context = context;
        }

        public Address Create(Address Address)
        {
            var result = _context.Add<Address>(Address);
            _context.SaveChanges();
            return result.Entity;
        }

        public Address Delete(Address Address)
        {
            var result = _context.Remove(Address);
            _context.SaveChanges();
            return result.Entity;
        }

        public Address Get(int Id)
        {
            return _context.Addresses.SingleOrDefault(x => x.Id == Id);
        }

        public List<Address> GetAll()
        {
            return _context.Addresses.ToList();
        }

        public Address Update(Address Address)
        {
            _context.Entry(Address).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Address;
        }
    }
}
