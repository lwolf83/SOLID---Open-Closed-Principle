using System;
using System.Collections.Generic;

namespace SOLID___Open_Closed_Principle
{
    public class Program
    {
        public static void Main()
        {
            Factory factory = new Factory();

            List<Wood> woodBlocks = new List<Wood>
            {
                new Wood(),
                new Wood()
            };

            List<Metal> metalBlocks = new List<Metal>
            {
                new Metal(),
                new Metal()
            };
            List<Production> manyProductions = new List<Production>
            {
                factory.Craft(woodBlocks),
                factory.Craft(metalBlocks)
            };

            foreach (Production production in manyProductions)
            {
                Console.WriteLine(production);
            }
        }
    }

}