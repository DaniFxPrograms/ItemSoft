using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICSharpCode.SharpZipLib.Zip;
using System.IO;
using System.Text.RegularExpressions;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.GZip;

namespace ItemSoft.FileSystem
{
    public class ZipArchive
    {

        public static void ExtractGZip(string gzipFileName, string targetDir)
        {

            byte[] dataBuffer = new byte[4096];

            using (System.IO.Stream fs = new FileStream(gzipFileName, FileMode.Open, FileAccess.Read))
            {
                using (GZipInputStream gzipStream = new GZipInputStream(fs))
                {                    
                    string fnOut = Path.Combine(targetDir, Path.GetFileNameWithoutExtension(gzipFileName));

                    using (FileStream fsOut = File.Create(fnOut))
                    {
                        StreamUtils.Copy(gzipStream, fsOut, dataBuffer);
                    }
                }
            }
        }
    }    
}
