using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public interface IRouteStrategy
    {
        void CreateRoute(Coordinate start, Coordinate end);
    }
}
