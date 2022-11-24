using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public abstract class Shape
    {
        public int x; 
        public int y;

        public abstract void Render();
    }
}
