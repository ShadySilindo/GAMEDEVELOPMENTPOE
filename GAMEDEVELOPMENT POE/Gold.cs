using System;
using System.Collections.Generic;
using System.Text;

namespace Gade6122_Part1_corrected
{ 
    class Gold : Item
    {
        public int amountGold
        {
            get { return amountGold; }
        }
        private Random random = new Random();
        public Gold(int x, int y) : base(x, y)
        {
            int amountGold = random.Next(1, 6);
        }
    }
}
