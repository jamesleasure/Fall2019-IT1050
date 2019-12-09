using System;

namespace InClass08
{
    class Program
    {
        static void Main(string[] args)
        {
            PCVideoGame videoGame = new PCVideoGame();
            videoGame.title = "Starcraft";
            videoGame.PlatformType("PC");
            videoGame.Amount(59.99d);
            videoGame.gameType = "Real-time strategy";
            videoGame.minimumRAM = "2 GB";

            VideoGame vg2 = new VideoGame("Clash Royale", "Real-time strategy", 0.00, "iOS");
            

            XBoxVideoGame vg3 = new XBoxVideoGame("Fortnite", "Battle Royale", 9.99);

            videoGame.Display();
            Console.WriteLine();

            vg2.Display();
            Console.WriteLine();

            vg3.Display();
            Console.WriteLine();
        }
    }

    class PCVideoGame : VideoGame
    {
        public string minimumRAM;
        public PCVideoGame(string title, string type, double price)
            : base(title, type, price, "PC")
        {

        }

        public PCVideoGame() { }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Minimum RAM: {this.minimumRAM}");
        }
    }

    class XBoxVideoGame : VideoGame
    {
        public bool requiresMicrosoftSubscription;
        public bool requiresHeadset;
        public bool requiresInternet;

        public XBoxVideoGame(string title, string type, double price)
            : base(title, type, price, "XBox One")
        {
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Requires Microsoft Subscription: {this.requiresMicrosoftSubscription}");
        }
    }

    class VideoGame
    {
        public string title;
        //public string genre;
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

        public virtual void Display()
        {
            Console.WriteLine(
                $"Title: {this.title}\n" +
                $"Game Type: {this.gameType}\n" +
                $"Cost: ${this.price.ToString("#.##")}\n" +
                $"Platform: {this.platform}");
        }
    }
}
