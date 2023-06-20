using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_IComparable
{
    internal class QuantityDesc : IComparer<GuitarPick>
    {
        public int Compare(GuitarPick? x, GuitarPick? y)
        {
            return -(x.PackQuantity.CompareTo(y.PackQuantity));
        }
    }
}
