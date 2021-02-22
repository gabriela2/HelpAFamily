using HelpAFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Repositories.DonationRepository
{
    public class DonationRepository : IDonationRepository
    {
        public DataContext _context { get; set; }
        public DonationRepository (DataContext context)
        {
            _context = context;
        }


        public Donation Create(Donation Donation)
        {
            var result = _context.Add<Donation>(Donation);
            _context.SaveChanges();
            return result.Entity;
        }

        public Donation Delete(Donation Donation)
        {
            var result = _context.Remove(Donation);
            _context.SaveChanges();
            return result.Entity;
        }

        public Donation Get(int Id)
        {
            return _context.Donations.SingleOrDefault(x => x.Id == Id);
        }

        public List<Donation> GetAll()
        {
            return _context.Donations.ToList();
        }

        public Donation Update(Donation Donation)
        {
            _context.Entry(Donation).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Donation;
        }
    }
}
