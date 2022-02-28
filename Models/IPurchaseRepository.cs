using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstoreProject.Models
{
    public interface IPurchaseRepository
    {
        IQueryable<Purchase> Purchases { get;}

        void savePurchase(Purchase purchase);
    }
}
