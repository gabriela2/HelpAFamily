using HelpAFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpAFamily.Repositories.DonationRepository
{
    interface IDonationRepository
    {
        List<Donation> GetAll();
        Donation Get(int Id);
        Donation Create(Donation Donation);
        Donation Update(Donation Donation);
        Donation Delete(Donation Donation);
    }
}
