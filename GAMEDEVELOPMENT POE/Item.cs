using System;
using System.Collections.Generic;
using System.Text;

namespace Gade6122_Part1_corrected
{
   public class Item : Tile
    {
        public Item(int x, int y) : base(x, y)
        {

        }        
        public override string ToString()
        {

            return GetType().Name + " at [" + x + ", " + y + "] ";
        }
    }
}
