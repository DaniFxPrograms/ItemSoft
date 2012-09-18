using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ItemSoft.Settings
{
    interface ISettingService
    {
        string GetSettingValue(string Name, string DefaultValue);
    }
}
