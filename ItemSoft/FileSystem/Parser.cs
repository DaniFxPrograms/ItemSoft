using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ItemSoft.PricingServices;
using ItemSoft.Settings;
using ItemSoft.Infrastructure;
using ItemSoft.Data;
using System.IO;
using System.Net;
using FileHelpers;
using ItemSoft.Items;

namespace ItemSoft.FileSystem
{
    public class Parser
    {
        public void Execute()
        {
           DowloadAllFiles();

        }

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
                string fileName = p.Name + ".csv.gz";
                client.DownloadFile(p.Path, LocalPath + @"\Pricings\" + fileName);
                ZipArchive.ExtractGZip(LocalPath + @"\Pricings\" + fileName, LocalPath + @"\Pricings\");


                string expFile= LocalPath + @"\Pricings\" +p.Name + ".csv";
                if (File.Exists(expFile))
                {
                    FileHelperEngine engine = new FileHelperEngine(typeof(Product));

                    Product[] _products = (Product[])engine.ReadFile(expFile);
                    IoC.Resolve<IItemService>().AnalyzeProducts(_products.ToList());
                }


            }
        }
    }
}
