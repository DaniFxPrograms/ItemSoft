using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ItemSoft.FileSystem;

namespace ItemSoft.Items
{
    interface IItemService
    {
        void AnalyzeProducts(List<Product> products);
    }
}
