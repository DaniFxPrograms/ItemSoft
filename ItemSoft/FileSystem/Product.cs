using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FileHelpers;

namespace ItemSoft.FileSystem
{
    [DelimitedRecord("\t")]
    [IgnoreFirst(1)] 
    public class Product
    {
        public string Zupid;
        public string MerchantProductNumber;
        public string ProductName;
        public string ProductPrice;
        public string CurrencySymbolOfPrice;
        public string ValidFromDate;
        public string ProductShortDescription;
        public string ProductLongDescription;
        public string MerchantProductCategory;
        public string ZanoxCategoryIds;
        public string ImageSmallURL;
        public string ImageMediumURL;
        public string ImageLargeURL;
        public string ProductManufacturerBrand;
        public string ZanoxProductLink;
        public string DeliveryTime;
        public string TermsOfContract;
        public string ISBN;
        public string ShippingAndHandling;
        public string ShippingAndHandlingCost;
        public string ProductPriceOld;
        public string ProductEAN;

    }
}
