using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    public class FlavorComparer : IComparer<Flavor>
    {
        public int Compare(Flavor flavor1, Flavor flavor2)
        {
            // this Compare method takes in 2 Flavor objects
            // and compares the names alphabetically
            return string.Compare(flavor1.Name, flavor2.Name);
        }
    }
}
