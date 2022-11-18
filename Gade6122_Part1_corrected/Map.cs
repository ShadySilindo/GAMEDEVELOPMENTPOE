using System;

namespace Gade6122_Part1_corrected
{
    [Serializable]
    public class Map
    {
        private Tile[,] map;
        private Hero hero;
        private Character character;
        private Gold gold;
        private Enemy enemy;
        private SwampCreature swampcreature;
        private GameEngine gamengine;
        private Enemy[] enemies;
        private Item[] items;
        private int width;
        private int height;
        private Random random;
        public Hero Hero
        {
            get { return hero; }
        }
        public Enemy Enemy
        {
            get { return enemy; }
        }
        public SwampCreature SwampCreature
        {
            get { return swampcreature; }
        }



        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int numEnemies, int numItems)
        {
            
            random = new Random();
            numItems = random.Next(1, 6);
            width = random.Next(minWidth, maxWidth);
            height = random.Next(minHeight, maxHeight);
            map = new Tile[width, height];
            InitialiseMap();
            enemies = new Enemy[numEnemies];
            items = new Item[numItems];

            hero = (Hero)Create(TileType.Hero);
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = (Enemy)Create(TileType.Enemy);
            }
            for (int j = 0; j < items.Length; j++)
            {
                items[j] = (Item)Create(TileType.Gold);
            }
            UpdateVision();
        }

        private void UpdateVision()
        {
            hero.UpdateVision(map);
            foreach (Enemy enemy in enemies)
            {
                enemy.UpdateVision(map);
            }
        }
        public void UpdateMap()
        {
            InitialiseMap();

            foreach (Enemy enemy in enemies)
            {
                map[enemy.X, enemy.Y] = enemy;
            }

            foreach (Item item in items)
            {
                map[item.X, item.Y] = item;
            }
            //place hero last so its not overwritten
            map[hero.X, hero.Y] = hero;
            UpdateVision();
        }

        private Tile Create(TileType type)
        {
            int tileX = random.Next(1, width - 1);
            int tileY = random.Next(1, height - 1);

            while (!(map[tileX, tileY] is EmptyTile))
            {
                tileX = random.Next(1, width - 1);
                tileY = random.Next(1, height - 1);
            }
            if (type == TileType.Hero)
            {
                map[tileX, tileY] = new Hero(tileX, tileY, 10);
            }
            else if (type == TileType.Enemy)
            {
                int enemyType = random.Next(0, 2);
                if (enemyType == 0)
                {
                    map[tileX, tileY] = new SwampCreature(tileX, tileY);
                }
                if (enemyType == 1)
                {
                    map[tileX, tileY] = new Mage(tileX, tileY);
                }
            }
            else if (type == TileType.Gold)
            {
                int itemType = random.Next(0);
                if (itemType == 0)
                {
                    map[tileX, tileY] = new Gold(tileX, tileY);
                }
            }
            return map[tileX, tileY];
        }

        private void InitialiseMap()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (x == 0 || y == 0 || x == width - 1 || y == height - 1)
                    {
                        map[x, y] = new Obstacle(x, y);

                    }
                    else
                    {
                        map[x, y] = new EmptyTile(x, y);
                    }
                }
            }
        }
        public override string ToString()
        {
            string s = "";
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Tile tile = map[x, y];
                    if (tile is EmptyTile)
                    {
                        s += ".";
                    }
                    else if (tile is Obstacle)
                    {
                        s += "X";
                    }
                    else if (tile is Hero)
                    {
                        s += "H";
                    }
                    else if (tile is SwampCreature)
                    {
                        Enemy enemy = (Enemy)tile;
                        if (enemy.IsDead == false)
                        {
                            s += "S";
                        }
                        if (enemy.IsDead)
                        {
                            s += "†";
                        }
                    }
                    else if (tile is Mage)
                    {
                        Enemy enemy = (Enemy)tile;
                        if (enemy.IsDead == false)
                        {
                            s += "M";
                        }
                        if (enemy.IsDead)
                        {
                            s += "D";
                        }
                    }
                    else if (tile is Gold)
                    {

                        Item item = (Item)tile;
                        {
                            s += "G";
                        }
                        if (remove == true)
                        {
                            s += ".";
                        }
                    }
                }
                s += "\n";
            }
            return s;
        }

        bool remove = false;

        public void GetItemAtPosition(int x, int y)
        {
            if (hero.X == gold.X && hero.Y == gold.Y)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if (items[j] == gold)
                        remove = true;
                }
            }
        }

        public void MoveEnemies() //this method is meant to allow for the enemies that have movement i.e swampcreatures to move in the map
        {
            for (int i = 0; i < this.enemies.Length; i++)
            {
                if (enemies[i] is SwampCreature && enemies[i].IsDead == false) 
                {

                    enemies[i].UpdateVision(map);

                    Movement direction = (enemies[i] as SwampCreature).ReturnMove();
                    Tile tile = enemies[i];
                    if (direction == Movement.NoMovemnt)
                    {
                        return;
                    }
                    if (direction == Movement.Up)
                    {
                        enemies[i].Move((Movement)Movement.Up);
                    }
                    if (direction == Movement.Down)
                    {
                        enemies[i].Move((Movement)Movement.Down);
                    }
                    if (direction == Movement.Left)
                    {
                        enemies[i].Move((Movement)Movement.Left);
                    }
                    if (direction == Movement.Right)
                    {
                        enemies[i].Move((Movement)Movement.Right);
                    }

                    enemies[i].UpdateVision(map);
                }
            }
        }

        public string EnemyAttack(Movement direction) //this method is to allow for enemies to attack the player
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


    }
}

