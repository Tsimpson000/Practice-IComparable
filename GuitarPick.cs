using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_IComparable
{
    internal class GuitarPick : IComparable<GuitarPick>
    {
        string _brand;
        double _thickness;
        int _packQuantity;

        public GuitarPick(string brand, double thickness, int packQuantity)
        {
            _brand = brand;
            _thickness = thickness;
            _packQuantity = packQuantity;
        }

        public string Brand { get => _brand; set => _brand = value; }
        public double Thickness { get => _thickness; set => _thickness = value; }
        public int PackQuantity { get => _packQuantity; set => _packQuantity = value; }

        public int CompareTo(GuitarPick? other)
        {
            if(this._thickness > other._thickness)
            {
                return 1;
            }
            else if (this._thickness < other._thickness)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{_brand} - {_thickness}mm QTY:{_packQuantity}";
        }
    }
}
