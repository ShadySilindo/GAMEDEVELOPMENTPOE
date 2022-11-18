﻿using System.Collections.Generic;

namespace Gade6122_Part1_corrected
{
    public class SwampCreature : Enemy
    {
        public SwampCreature(int x, int y) : base(x, y, 1, 10)
        {

        }

        public override Movement ReturnMove(Movement move = Movement.NoMovemnt)
        {
            int index = random.Next(4);
            List<int> checkedDirection = new List<int>();
            while (checkedDirection.Count < 4 && !(vision[index] is EmptyTile))
            {
                if (checkedDirection.Contains(index))
                    checkedDirection.Add(index);

                index = random.Next(4);
            }
            if (checkedDirection.Count == 4)
                return Movement.NoMovemnt;

            return (Movement)index;
        }

        public override string ToString()
        {
            return $"SwampCreature: \n" +
                $"HP: {hp}/{maxHp}\n" +
                $"Damage: {damage} \n" +
                $"[{x}, {y}]\n";
        }
    }

}

