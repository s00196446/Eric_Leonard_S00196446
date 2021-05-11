using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Eric_Leonard_S00196446
{
    public class Game
    {
        public string Name { get; set; }

        public double Metacritic { get; set; }

        public string Description { get; set; }

        public string Platform { get; set; }

        public decimal Price { get; set; }

        public string Game_Image { get; set; }

        public Game()
        {

        }

        public Game(string name, decimal price, double metacritic, string description, string platform, string game_image)
        {
            Name = name;
            Metacritic = metacritic;
            Description = description;
            Platform = platform;
            Price = price;
            Game_Image = game_image;
        }

        public void DecreasePrice(double increase)
        {
            Price *= (decimal)(1 - increase);
        }

    }

    public class GameDB : DbContext
    {
        public GameDB() : base("MyGameData") { }

        public DbSet<Game> GameDetails { get; set; }
    }
}



