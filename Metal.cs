﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID___Open_Closed_Principle
{
    public class Metal : ICraftable
    {
        public string Type
        {
            get
            {
                return "Metal";
            }
        }
    }
}
