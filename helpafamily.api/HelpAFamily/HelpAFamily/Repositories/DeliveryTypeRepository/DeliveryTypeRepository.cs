using HelpAFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Repositories.DeliveryTypeRepository
{
    public class DeliveryTypeRepository : IDeliveryTypeRepository
    {
        public DataContext _context { get; set; }
        public DeliveryTypeRepository(DataContext context)
        {
            _context = context;
        }


        public DeliveryType Create(DeliveryType DeliveryType)
        {
            var result = _context.Add<DeliveryType>(DeliveryType);
            _context.SaveChanges();
            return result.Entity;
        }

        public DeliveryType Delete(DeliveryType DeliveryType)
        {
            var result = _context.Remove(DeliveryType);
            _context.SaveChanges();
            return result.Entity;
        }

        public DeliveryType Get(int Id)
        {
            return _context.DeliveryTypes.SingleOrDefault(x => x.Id == Id);
        }

        public List<DeliveryType> GetAll()
        {
            return _context.DeliveryTypes.ToList();
        }

        public DeliveryType Update(DeliveryType DeliveryType)
        {
            _context.Entry(DeliveryType).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return DeliveryType;
        }
    }
}
