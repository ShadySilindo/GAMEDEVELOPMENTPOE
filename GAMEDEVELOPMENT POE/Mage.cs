using System;
using System.Collections.Generic;
using System.Text;

namespace Gade6122_Part1_corrected
{
    public class Mage : Enemy
    {
        public Mage(int x, int y) : base(x, y, 5, 5)
        {

        }

        public override Movement ReturnMove(Movement move = Movement.NoMovemnt)
        {
            return Movement.NoMovemnt;
        }

        public override bool CheckRange(Character target)
        {
            int xDist = Math.Abs(target.X - X);
            int yDist = Math.Abs(target.Y - Y);
            if (xDist <= 1 && yDist <= 1 || xDist + yDist <= 1)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Mage: \n" +
                $"HP: {hp}/{maxHp}\n" +
                $"Damage: {damage} \n" +
                $"[{x}, {y}]\n";
        }
    }
}
