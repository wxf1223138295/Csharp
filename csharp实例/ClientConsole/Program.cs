﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CommonServer ces=new CommonServer();
            var result=ces.getResult(4);
           
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
