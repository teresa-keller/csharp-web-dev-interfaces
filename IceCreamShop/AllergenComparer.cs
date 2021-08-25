using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    class AllergenComparer : IComparer<Flavor>
    {
        public int Compare(Flavor x, Flavor y)
        {
            if (x.Allergens.Count - y.Allergens.Count < 0)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}
