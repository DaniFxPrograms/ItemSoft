using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ItemSoft.Data;

namespace ItemSoft.PricingServices
{
    public class PricingService :IPricingService
    {
        #region Fields

        /// <summary>
        /// Object context
        /// </summary>
        private readonly ItemCoreEntities _context;

     
        #endregion
        public PricingService(ItemCoreEntities context)
        {
            this._context = context;
        }

        public List<Data.Pricing> GetAllPricings()
        {
            List<Pricing> retList = _context.Pricing.ToList();
            return retList;
        }
    }
}
