using System;
using System.Collections.Generic;
using System.Text;

namespace Gade6122_Part1_corrected
{
    [System.Serializable]
    public abstract class Enemy : Character
    {
        protected static Random random = new Random();
        private MeleeWeapon meleeWeapon;
        private RangedWeapon rangedWeapon;
        private Weapon Weapon;
        public Enemy(int x, int y, int damage, int hp) : base(x, y)
        {
            this.damage = damage;
            this.hp = hp;
            this.maxHp = hp;
            type = TileType.Enemy;
        }


        public override string ToString()
        {
            return GetType().Name + " at [" + x + ", " + y + "] (" + damage + "DMG)"; 
        }
    }
}
