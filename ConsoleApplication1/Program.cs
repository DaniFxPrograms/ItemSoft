using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ItemSoft.FileSystem;
using ItemSoft.Infrastructure;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize IoC
            IoC.InitializeWith(new DependencyResolverFactory());
            Parser _parse = new Parser();
            _parse.Execute();
        }
    }
}
