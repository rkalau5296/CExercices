﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Triangle : Shape
    {
        public override void Render()
        {
            Console.WriteLine("Render Triangle");
        }
    }
}
