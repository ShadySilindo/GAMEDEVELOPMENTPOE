using System;
using System.Collections.Generic;

namespace Gade6122_Part1_corrected
{
    class Leader : Enemy
    {
        private Tile tile;
        private EmptyTile EmptyTile;
        private Hero hero;
        new Random random = new Random();


        private Tile target
        {
            get { return hero; }
            set { tile = target; }
        }

        public Leader(int x, int y) : base(x, y, 2, 20)
        {
            this.hp = 20;
            this.damage = 2;
            maxHp = 20;
        }
        public override Movement ReturnMove(Movement move = Movement.NoMovemnt)
        {
             Hero hero = new Hero(x, y, hp);
             Random random = new Random();
            int tracker = random.Next(8);
            int targetX = hero.X;
            int targetY = hero.Y;

            int randomMove;
            double lowDist = 1000;
            int arrayNum = 0;
            int leadersMoveNum = 0;
            double[] distances = new double[4];

            if (tracker >= 4)
            {
                return Movement.NoMovemnt;
            }

            else
            {
                distances[0] = Math.Sqrt(Math.Pow(this.x - targetX, 2) + Math.Pow((this.y - 1) - targetY, 2));

                distances[1] = Math.Sqrt(Math.Pow(this.x - targetX, 2) + Math.Pow((this.y + 1) - targetY, 2));

                distances[2] = Math.Sqrt(Math.Pow((this.x - 1) - targetX, 2) + Math.Pow(this.y - targetY, 2));

                distances[3] = Math.Sqrt(Math.Pow((this.x + 1) - targetX, 2) + Math.Pow(this.y - targetY, 2));

                for (int i = 0; i < distances.Length; i++)
                {
                    lowDist = distances[i];
                    arrayNum = i;
                    if (lowDist == 0)
                    {
                        arrayNum = 4;
                    }
                }
            }
            if (arrayNum == 0)
            {
                leadersMoveNum = 0;
            }
            else if (arrayNum == 1)
            {
                leadersMoveNum = 2;
            }
            else if (arrayNum == 2)
            {
                leadersMoveNum = 3;
            }
            else if (arrayNum == 3)
            {
                leadersMoveNum = 1;
            }
            else if (arrayNum == 4)
            {
                leadersMoveNum = 4;
            }

            if (leadersMoveNum == 4)
            {
                return (Movement)leadersMoveNum;
            }
            else if (vision[leadersMoveNum] is Obstacle || vision[leadersMoveNum] is Enemy)
            {
                int moveAttempt = 0;
                while (moveAttempt <= 4)
                {
                    moveAttempt++;
                    if (moveAttempt == 4)
                    {
                        return Movement.NoMovemnt;
                    }
                }

                randomMove = random.Next(0, 4);

                while (!(vision[randomMove] is EmptyTile || !(vision[randomMove] is Gold || !(vision[randomMove] is MeleeWeapon || !(vision[randomMove] is RangedWeapon)))))
                {
                    return (Movement)randomMove;
                }
            }

            return (Movement)leadersMoveNum;
        }
        public override string ToString()
        {
            return $"The Leader Is Now At Position {x},{y}\n" +
                   $"The Leader Does {damage} Damage\n" +
                   $"The Leader Has {hp}/{maxHp}\n";
        }
    }
}
