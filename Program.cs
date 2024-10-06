using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;

Console.WriteLine("Jump Statements"); Console.WriteLine("");

// Break
Console.WriteLine(""); Console.WriteLine("Break");
int i = 0;
for (i=0; i <5; i++)
{
    Console.WriteLine("i = {0}", i);
    if (i == 2)
        break;
}

// Continue
Console.WriteLine(""); Console.WriteLine("Continue");
for (int o = 0 ; o <5; o++)
{
    Console.WriteLine("o = {0}", o);
    if (o == 2)
        continue;
    Console.WriteLine("I will not be printed if o=2. \n");
}

