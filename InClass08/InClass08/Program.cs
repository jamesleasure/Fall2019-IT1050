using System;

namespace InClass08
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoGame videoGame = new VideoGame();
            videoGame.title = "Starcraft";
            videoGame.PlatformType("PC");
            videoGame.Amount(60d);
            videoGame.genre = "Real-time strategy";

            VideoGame vg2 = new VideoGame("Clash Royale", "Real-time strategy", 0.00, "iOS");

            VideoGame vg3 = new VideoGame("Fortnite", "Battle Royale", 9.99, "Xbox One");

            videoGame.Display(); ;
            vg2.Display();
            vg3.Display();
        }
    }

    class VideoGame
    {
        public string title;
        public string genre;
        public double price;
        public string platform;
        public string gameType;

        public VideoGame()
        {

        }

        public VideoGame(string title, string type, double price, string platform)
        {
            this.title = title;
            this.gameType = type;
            this.price = price;
            this.platform = platform;
        }

        public void TypeOfGame(string type)
        {
            this.gameType = type;
        }
        public void Amount(double amount)
        {
            this.price = amount;
        }
        public void PlatformType(string type)
        {
            this.platform = type;
        }

        public void Display()
        {
            Console.WriteLine(
                $"Title: {this.title}\n" +
                $"Game Type: {this.gameType}\n" +
                $"Cost: ${this.price.ToString("#.##")}\n" +
                $"Platform: {this.platform}\n\n");
        }
    }
}
