using System;
using System.Collections.Generic;
using System.Text;

namespace Gade6122_Part1_corrected
{
    public abstract class Enemy : Character
    {
        protected Random random = new Random();
        public Enemy(int x, int y, int damage, int hp) : base(x, y, 5) //thr 5 is a stand in for the goldPurse variable
        {
            this.damage = damage;
            this.hp = hp;
            this.maxHp = hp;
            type = TileType.Enemy;
        }
        public override Movement ReturnMove(Movement move = Movement.NoMovemnt)
        {
            if (move == Movement.NoMovemnt)
            {
                return move;
            }
            if (vision[(int)move] is EmptyTile)
            {
                return move;
            }

            return Movement.NoMovemnt;
        }
        public override string ToString()
        {
            return GetType().Name + " at [" + x + ", " + y + "] (" + damage + "DMG)"; 
        }
    }
}
