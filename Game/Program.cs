
using Game.Concrete;
using Game.Entities;
using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {

            GamerManager gamerManager = new GamerManager(new Gamer());
            GameeManager gameeManager = new GameeManager(new Gamee());

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("what will do");
            Console.WriteLine("1 =Gamer menu");
            Console.WriteLine("2 =Game menu ");
            string answer=Console.ReadLine();

            switch (answer)
            {
                case "1":
                    gamerManager.Add();
                    Console.WriteLine();
                    break;
                case "2":
                    gameeManager.Add();
                    Console.WriteLine();
                    break;
                default:

                    break;
            }
            
            
            Console.ReadLine();

           
        }
    }
}
