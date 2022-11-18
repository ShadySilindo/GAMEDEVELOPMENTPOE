using System;

namespace Gade6122_Part1_corrected
{
    public enum Types
    {
        Dagger,
        Longsword,
        Rifle,
        Longbow,
    }

    class MeleeWeapon : Weapon
    {
        protected Types types;
        public Types Types
        {
            get { return types; }
            set { Types types = value; }
        }

        public string meleeWeaponChar;
        public override int Range => 1;
        public MeleeWeapon(int x, int y) : base(x, y)
        {
            Random random = new Random();
            int randWeapon = random.Next(0, 2);
            if (randWeapon == 0)
            {
                types = Types.Dagger;
            }
            else if (randWeapon == 1)
            {
                types = Types.Longsword;
            }           
                if (types == Types.Dagger)
                {
                    meleeWeaponChar = "D";
                    this.weaponType = "Dagger";
                    this.durability = 10;
                    this.damage = 3;
                    this.cost = 3;
                }
                else if (types == Types.Longsword)
                {
                    meleeWeaponChar = "O";
                    this.weaponType = "Longsword";
                    this.durability = 6;
                    this.damage = 4;
                    this.cost = 5;
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
