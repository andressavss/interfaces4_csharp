﻿using System;
using Interfaces4.Devices;

namespace Interfaces4;
class Program
{
    static void Main(string[] args)
    {
        Printer p = new Printer() { SerialNumber = 1080 };
        p.ProcessDoc("My letter");
        p.Print("My letter");

        Console.WriteLine();
        Scanner s = new Scanner() { SerialNumber = 2003 };
        s.ProcessDoc("My email");
        Console.WriteLine(s.Scan());
    }
}
