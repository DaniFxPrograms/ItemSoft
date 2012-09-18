using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ItemSoft.Data;

namespace ItemSoft.Categories
{
    public class CategoryService : ICategoryService
    {
        #region Fields

        /// <summary>
        /// Object context
        /// </summary>
        private readonly ItemCoreEntities _context;

     
        #endregion
        public CategoryService(ItemCoreEntities context)
        {
            this._context = context;
        }

        public void InsertCategory(string name)
        {
            InsertCategory(name, null);
        }

        public void InsertCategory(string name, int? parentId)
        {
            _context.Category.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());
        }



        int ICategoryService.CategoryAnalyzer(string categories)
        {
            string[] categoriesArray = categories.Split('/');
            for (int i = 0; i < categoriesArray.Length - 1; i++)
            {
                string cat = categoriesArray[i].Trim();
                var fCat = _context.Category.FirstOrDefault(x => x.Name == cat);
                if (fCat == null)
                {
 
                }
            }
           
        }
    }
}
