using System;
using System.Collections.Generic;
using System.Text;

namespace Gade6122_Part1_corrected
{
    [Serializable]
    public class Obstacle : Tile // empty returns an obstacle tile
    {
        public Obstacle(int x, int y) : base(x, y)
        {

        }
    }
}
