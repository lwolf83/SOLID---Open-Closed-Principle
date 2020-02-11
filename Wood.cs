using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID___Open_Closed_Principle
{
    public class Wood : ICraftable
    {
        public string Type
        {
            get
            {
                return "Wood";
            }
        }
    }
}
