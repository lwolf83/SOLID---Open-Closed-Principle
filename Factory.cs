using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID___Open_Closed_Principle
{
    public sealed class Factory
    {
        public Production Craft(IEnumerable<Craftable> manyBlocks)
        {
            Production newProduction = new Production(manyBlocks);
            return newProduction;
        }

    }
}
