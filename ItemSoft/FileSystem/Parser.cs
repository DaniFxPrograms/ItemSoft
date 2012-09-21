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
                Console.WriteLine("Download Listino " + p.Name + " ...");
                client.DownloadFile(p.Path, LocalPath + @"\Pricings\" + fileName);
                Console.WriteLine("Estrazione...");
                ZipArchive.ExtractGZip(LocalPath + @"\Pricings\" + fileName, LocalPath + @"\Pricings\");
                

                string expFile= LocalPath + @"\Pricings\" +p.Name + ".csv";
                if (File.Exists(expFile))
                {
                    FileHelperEngine engine = new FileHelperEngine(typeof(Product));

                    Product[] _products = (Product[])engine.ReadFile(expFile);
                    Console.WriteLine("Ci sono " + _products.Count().ToString() + " prodotti");
                    Console.WriteLine("Elimino i prodotti vecchi...");
                    IoC.Resolve<IItemService>().DeleteOld(_products.ToList(),p.ProgramID.Value);
                    Console.WriteLine("Analizzaro i prodotti...");
                    IoC.Resolve<IItemService>().AnalyzeProducts(_products.ToList());
                }
                Console.WriteLine("Fine importazione Listino");


            }
        }
    }
}
