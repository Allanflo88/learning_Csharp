using System;
using System.Collections.Generic;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>{"Allan", "Ana", "Felipe"};
            names.Add("João");
            names.Add("Maria");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            
        }
    }
}
