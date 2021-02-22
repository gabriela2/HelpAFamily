using HelpAFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Repositories.DeliveryTypeRepository
{
    interface IDeliveryTypeRepository
    {
        List<DeliveryType> GetAll();
        DeliveryType Get(int Id);
        DeliveryType Create(DeliveryType DeliveryType);
        DeliveryType Update(DeliveryType DeliveryType);
        DeliveryType Delete(DeliveryType DeliveryType);
    }
}
