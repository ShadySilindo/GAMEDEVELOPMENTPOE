using System;
using System.Collections.Generic;
using System.Text;

namespace Gade6122_Part1_corrected
{
    class Shop
    {
        private string[] weapons = new string[3];
        private Random random = new Random();
        private Character character;
        private Hero hero;
        private Weapon weapon;
        private Item item;
        public Shop(Weapon[] weapons, Random random, Character character)
        {
            this.random = random;
            this.character = character;
        }
        public void RandomWeapon()
        {
            weapons[0] = "Dagger";
            weapons[1] = "Longsword";
            weapons[2] = "Rifle";
            weapons[3] = "Longbow";
            for (int i = 0; i < weapons.Length; i++)
            {
                int randomWeapon = random.Next(0, weapons.Length);
                weapons[i] = weapons[randomWeapon];
            }
        }

        public bool CanBuy(int num)
        {
            if (character.GoldPurse > weapon.Cost)
            {
                return true;
            }

            return false;
        }

        public void Buy(int num)
        {
            if (CanBuy(num) == true)
            {
                character.GoldPurse = character.GoldPurse - weapon.Cost;
                character.Pickup(item);
            }
        }

        public string DisplayWeapon(int num)
        {
            return $"The {GetType().Name} Will Cost You {weapon.Cost} Gold \n";
        }
    }
}
