using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID___Open_Closed_Principle
{
    public class Production
    {
        public IEnumerable<Craftable> Materials { get; set; }

        public Production(IEnumerable<Craftable> manyMaterials)
        {
            Materials = manyMaterials;
        }

        public override string ToString()
        {
            string description = "Object is composed of\n:";
            foreach (Craftable material in Materials)
            {
                description += "\t" + material.Type;
            }
            return description;
        }
    }
}
