namespace Gade6122_Part1_corrected
{
    [System.Serializable]
    abstract class Weapon : Item
    {
        protected int damage;

        protected int range;

        protected int durability;

        protected int cost;

        protected string weaponType;

        public int Damage 
        {
            get { return damage; }
        }
        public virtual int Range
        {
            get { return range; }
        }

        public int Durability
        {
            get { return durability; }
        }

        public int Cost
        {
            get { return cost; }
        }

        public string WeaponType
        {
            get { return weaponType; }
        }
        
        protected Weapon(int x, int y) : base(x, y)
        {

        }
    }
}
