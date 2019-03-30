using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    public static class LiquidConvertor
    {
        public static double GallonToLiter(string G)
        {
            double gallon = double.Parse(G);
            double litter = gallon * 3.7854;
            return litter;
        }

        public static double LiterToGallon(string L)
        {
            double litter = double.Parse(L);
            double gallon = litter * 0.2642;
            return gallon;
        }
    }
}
