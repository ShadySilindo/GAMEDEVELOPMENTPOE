using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Gade6122_Part1_corrected
{
    [Serializable]
    public class GameEngine
    {
        private Gold gold { get; set; }
   
        public Map map { get; set; }
        public Tile tile { get; set; }
        public Character character { get; set; }
        public SwampCreature swampcreature { get; set; }
        public Obstacle obstacle { get; set; }
        public Enemy enemy { get; set; }
        public Item item { get; set; }
        public GameEngine gameengine { get; set; }
        public Mage mage { get; set; }
        public Hero hero { get; set; }

        public string Display
        {
            get { return map.ToString(); }
        }
        public string HeroStats
        {
            get { return map.Hero.ToString(); }
        }
        public GameEngine()
        {
            map = new Map(10, 20, 10, 20, 8, 5);
        }
        public bool MovePlayer(Movement direction)
        {
            if (direction == Movement.NoMovemnt)
            {
                return false;
            }
            Movement validMove = map.Hero.ReturnMove(direction);
            if (validMove == Movement.NoMovemnt)
            {
                return false;
            }
            map.MoveEnemies();
            map.Hero.Move(validMove);
            map.UpdateMap();
            return true;
        }
        public string EnemyAttack(Movement direction)
        {
            if (direction == Movement.NoMovemnt)
            {
                return "No Attack";
            }
            Tile tile = swampcreature.Vision[(int)direction];
            if (tile is Hero)
            {
                Hero hero = (Hero)tile;
                swampcreature.Attack(hero);
                return "Enemy attacked: " + hero.ToString();
            }
            return "Nada";
        }

        public Hero GetHero()
        {
            return hero;
        }

        public string PlayerAttack(Movement direction, Hero hero)
        {
            if (direction == Movement.NoMovemnt)
            {
                return "Attack Failed!";
            }
            Tile tile = map.Hero.Vision[(int)direction];
            if (tile is Enemy)
            {
                Enemy enemy = (Enemy)tile;
                map.Hero.Attack(enemy);
                return "Hero attacked: " + enemy.ToString();

            }
            if (tile is Gold)
            {
                Item item = (Item)tile;
                map.Hero.PickUp((Item)tile); //if gold is picked up redraw the entire map excluding that gold piece  
                map.UpdateMap();
                return "Hero Picked Up: " + tile.ToString();
            }
            return "Nothing To Do There";
        }
        const string SERIALIZED_FILE_NAME = "C# ascii game.txt";
        public void Save()
        {
            {
                FileStream stream = new FileStream(
                SERIALIZED_FILE_NAME, FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(stream, map);// gold, tile, character, enemy, gameengine, item, mage, obstacle, hero are selected and added to the filestream
                bf.Serialize(stream, gold);
                bf.Serialize(stream, hero);
                bf.Serialize(stream, tile);
                bf.Serialize(stream, character);
                bf.Serialize(stream, enemy);
                bf.Serialize(stream, gameengine);
                bf.Serialize(stream, item);
                bf.Serialize(stream, mage);
                bf.Serialize(stream, obstacle);
                bf.Serialize(stream, swampcreature);
                stream.Close();
            }
        }

        public void Load() //files are loaded from the filestream
        {
            FileStream stream = new FileStream(
            SERIALIZED_FILE_NAME, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            Map map;
            while (stream.Position < stream.Length)
            {
                map = (Map)bf.Deserialize(stream);
                gold = (Gold)bf.Deserialize(stream);
                hero = (Hero)bf.Deserialize(stream);
                tile = (Tile)bf.Deserialize(stream);
                character = (Character)bf.Deserialize(stream);
                enemy = (Enemy)bf.Deserialize(stream);
                gameengine = (GameEngine)bf.Deserialize(stream);
                item = (Item)bf.Deserialize(stream);
                mage = (Mage)bf.Deserialize(stream);
                obstacle = (Obstacle)bf.Deserialize(stream);
                swampcreature = (SwampCreature)bf.Deserialize(stream);
            }
            stream.Close();
        }
    }
}

