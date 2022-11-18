using System;

namespace Gade6122_Part1_corrected
{
    class RangedWeapon : Weapon
    {
        protected Types types;
        public Types Types
        {
            get { return types; }
            set { Types types = value; }
        }

        public string rangedWeaponChar;
      

        public override int Range => base.Range;
        public RangedWeapon(int x, int y) : base(x, y)
        {
            Random random = new Random();
            int randWeapon = random.Next(0, 2);
            if (randWeapon == 0)
            {
                types = Types.Rifle;
            }
            else if (randWeapon == 1)
            {
                types = Types.Longbow;
            }
            if (types == Types.Rifle)
            {
                rangedWeaponChar = "R";
                this.weaponType = "Rifle";
                this.durability = 3;
                this.range = 3;
                this.damage = 5;
                this.cost = 7;

            }
            else if (types == Types.Longbow)
            {
                rangedWeaponChar = "B";
                this.weaponType = "Longbow";
                this.durability = 4;
                this.range = 2;
                this.damage = 4;
                this.cost = 6;
            }
        }

        public override string ToString()
        {
            return $"The Weapon Is A {weaponType}\n" +
                   $"The Durability Is {durability}\n" +
                   $"The Weapon Does {damage} Damage\n" +
                   $"The Weapon Costs {cost} Gold\n";
        }
    }
}

