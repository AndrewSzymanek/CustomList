﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> thing = new List<int>() { 1, 2, 3, 4 };
            Console.WriteLine(thing.ToString());
            Console.ReadLine();
        }
    }
}
