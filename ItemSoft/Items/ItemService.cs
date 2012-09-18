using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ItemSoft.FileSystem;
using ItemSoft.Data;

namespace ItemSoft.Items
{
    public class ItemService : IItemService
    {
         #region Fields

        /// <summary>
        /// Object context
        /// </summary>
        private readonly ItemCoreEntities _context;

     
        #endregion
        public ItemService(ItemCoreEntities context)
        {
            this._context = context;
        }
        public void AnalyzeProducts(List<Product> products)
        {
            foreach (var p in products)
            {
                Item _item = _context.Item.FirstOrDefault(x => x.Zupid == p.Zupid);
                if (_item == null)
                {
                    _item = new Item();
                    _item.Zupid = p.Zupid;
                    _context.AddToItem(_item);
                    _context.SaveChanges();
                }

                
                
                
            }
        }

       
    }
}
