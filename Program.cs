using System;
using System.Collections.Generic;

namespace SOLID___Open_Closed_Principle
{
    public class Program
    {
        public static void Main()
        {
            Factory factory = new Factory();

            IEnumerable<Craftable> craftables = new List<Craftable>
            {
                new Wood(),
                new Metal()
            };

            Production production = factory.Craft(craftables);

            Console.WriteLine(production);
        }
    }

}