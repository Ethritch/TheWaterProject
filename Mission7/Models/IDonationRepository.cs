using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7.Models
{
    public interface IDonationRepository
    {
        public IQueryable<Donation> Donations { get; }

        public void SaveDonation(Donation donation);
    }
}
