using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ItemSoft.FileSystem;
using ItemSoft.Data;
using ItemSoft.Infrastructure;
using ItemSoft.Categories;

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

        public void DeleteOld(List<Product> products, int programId)
        {
            string id=  programId.ToString();
            var lItems = _context.Item.Where(x => x.ProgramId == id).ToList();
            foreach (Item itm in lItems)
            {
                var oldItem = products.FirstOrDefault(x => x.Zupid == itm.Zupid);
                if (oldItem == null)
                {
                    itm.Category.Clear();
                    _context.Item.DeleteObject(itm);

                }
            }

            _context.SaveChanges();

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
                    _item.CreatedOn = DateTime.Now;
                    _context.AddToItem(_item);
                    
                }

                int idCat= IoC.Resolve<ICategoryService>().CategoryAnalyzer(p.MerchantProductCategory);
                var cat = _context.Category.FirstOrDefault(X=>X.CategoryId==idCat);
                if (cat != null)
                {
                    if (!_item.Category.IsLoaded)
                        _item.Category.Load();
                    if (_item.Category.FirstOrDefault(x => x.CategoryId == cat.CategoryId) == null)
                        _item.Category.Add(cat);
                }
                _item.Culture = "it-IT";
                _item.CurrencySymbolOfPrice = "€";
                _item.DeliveryTime = p.DeliveryTime;
                _item.ImageLargeUrl = p.ImageLargeURL;
                _item.ImageMediumUrl = p.ImageMediumURL;
                _item.ImageSmallUrl = p.ImageSmallURL;
                _item.ISBN = p.ISBN;
                _item.MerchantProductNumber = p.MerchantProductNumber;
                _item.ProductEAN = p.ProductEAN;
                _item.ProductLongDescription = p.ProductLongDescription;
                _item.ProductManufacturerBran = p.ProductManufacturerBrand;
                _item.ProductName = p.ProductName;
                _item.ProductPrice = p.ProductPrice;
                _item.ProductShortDescription = p.ProductShortDescription;
                _item.ShippingAndHandling = p.ShippingAndHandling;
                _item.ShippingAndHandlingCost = p.ShippingAndHandlingCost;
                _item.TermsOfContract = p.TermsOfContract;
                _item.ValidFromDate = p.ValidFromDate;
                _item.ZanoxCategoryIds = p.ZanoxCategoryIds;
                _item.ZanoxProductLink = p.ZanoxProductLink;
                _item.ProgramId = p.ProgramId;
                _item.ExtraTextOne = p.ExtraTextOne;
                _item.ExtraTextTree = p.ExtraTextThree;
                _item.ExtraTextTwo = p.ExtraTextTwo;
                _item.ValidToDate = p.ValidToDate;
                    

               
                
                
                
            }
            _context.SaveChanges();
        }

       
    }
}
