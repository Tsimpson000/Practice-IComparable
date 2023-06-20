using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_IComparable
{
    internal class BrandCompare : IComparer<GuitarPick>
    {
        public int Compare(GuitarPick? x, GuitarPick? y)
        {
            return x.Brand.CompareTo(y.Brand);
        }
    }
}
