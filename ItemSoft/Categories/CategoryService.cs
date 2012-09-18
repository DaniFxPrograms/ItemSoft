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
            for (int i = 0; i <= categoriesArray.Length - 1; i++)
            {
                string cat = categoriesArray[i].Trim();
                var fCat = _context.Category.FirstOrDefault(x => x.Name == cat);


                if (fCat == null)
                {
                    Category nCat = null;
                    switch (i)
                    {
                        case 0:
                            nCat = new Category() { CreatedOn = DateTime.Now, Name = cat, ParentId = 0 };
                            break;
                        default:
                            string nameInCat = categoriesArray[i - 1].Trim();
                            var pCat = _context.Category.FirstOrDefault(x => x.Name == nameInCat.Trim());
                            if (pCat != null)
                                nCat = new Category() { ParentId = pCat.CategoryId, CreatedOn = DateTime.Now, Name = cat };
                            else
                            {
                                throw new Exception("Errore nella creazione delle cateogorie");
                            }
                            break;
                    }
                    _context.Category.AddObject(nCat);
                    _context.SaveChanges();
                }
            }
            _context.SaveChanges();
            string nameCat=categoriesArray[categoriesArray.Length - 1];
            var catObj = _context.Category.FirstOrDefault(x => x.Name == nameCat.Trim());
            return catObj.CategoryId;           
           
        }
    }
}
