using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ItemSoft.Data;
using ItemSoft.Infrastructure;
using ItemSoft.PricingServices;
using System.IO;
using System.Reflection;
using System.Net;
using ItemSoft.Settings;

namespace ItemSoft.FileSystem
{
    public class Downloader
    {
        public static void DowloadAllFiles()
        {
            var lPricings = IoC.Resolve<IPricingService>().GetAllPricings();
       
            string LocalPath = IoC.Resolve<ISettingService>().GetSettingValue("Application.Data.Folder", string.Empty);
            foreach (Pricing p in lPricings)
            {
                if (!Directory.Exists(LocalPath + @"\Pricings"))
                {

                    if (!string.IsNullOrEmpty(LocalPath))
                    {
                        Directory.CreateDirectory(LocalPath + @"\Pricings");
                    }
                }
                Uri rPath = new Uri(p.Path);
                
                WebClient client = new WebClient();
                string fileName = p.Name +  ".csv.gz";
                client.DownloadFile(p.Path, LocalPath + @"\Pricings\" + fileName);
                ZipArchive.ExtractGZip(LocalPath + @"\Pricings\" + fileName, LocalPath + @"\Pricings\");

            }
        }
    }
}
