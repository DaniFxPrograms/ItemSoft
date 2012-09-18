using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ItemSoft.Data;

namespace ItemSoft.Settings
{
    public class SettingService: ISettingService
    {

        #region Fields

        /// <summary>
        /// Object context
        /// </summary>
        private readonly ItemCoreEntities _context;


        #endregion

        public SettingService(ItemCoreEntities context)
        { this._context = context; }

        public string GetSettingValue(string Name, string DefaultValue)
        {
            var mySetting = _context.Setting.FirstOrDefault(x => x.Name.ToLower() == Name.ToLower());
            if (mySetting == null)
                return DefaultValue;
            else
                return mySetting.Value;

        }

       
        
    }
}
