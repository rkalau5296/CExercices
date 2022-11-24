﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Circle : Shape
    {
        public override void Render()
        {
            Console.WriteLine("Render Circle");
        }
    }
}
