using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID___Open_Closed_Principle
{
    public class Production
    {
        public IEnumerable<ICraftable> Materials { get; set; }

        public Production(IEnumerable<ICraftable> manyMaterials)
        {
            Materials = manyMaterials;
        }

        public override string ToString()
        {
            string description = "Object is composed of\n:";
            foreach (ICraftable material in Materials)
            {
                description += "\t" + material.Type;
            }
            return description;
        }
    }
}
