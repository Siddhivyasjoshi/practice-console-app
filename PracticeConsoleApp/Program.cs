using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PracticeConsoleApp
{
    class Program
    {
        static void Main(String[] args)
        {
            //Pass your key based on need 
               var v = new TypeFactory().GetType(TypeEnum.one).GetData();
            //We could have filter data method in each type 
        }
    }
}
