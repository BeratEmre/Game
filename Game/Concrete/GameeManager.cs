using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Concrete
{
    class GameeManager : IGameeService
    {
        Gamee _gamee;
        public GameeManager(Gamee gamee )
        {
            _gamee = gamee;
        }
        public void Add()
        {

            Console.Write("Gamer name=");
            _gamee.GameName = Console.ReadLine();
            Console.WriteLine();

            

            Console.Write("Gamer Tc=");
            _gamee.GameId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("GAMER  {0} ADDED", _gamee.GameName);
        }

        public void Delete()
        {
            Console.WriteLine("Game {0} silindi", _gamee.GameName);
        }
    }
}
