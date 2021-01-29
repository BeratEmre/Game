using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Concrete
{
    class GamerManager : IGamerService
    {
        Gamer _gamer;
        public GamerManager(Gamer gamer)
        {
            _gamer = gamer;
        }
        public void Add()
        {
            Console.Write("Gamer name=");
            _gamer.GamerName=Console.ReadLine();
            Console.WriteLine();

            Console.Write("Gamer Lastname=");
            _gamer.GamerLastName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Gamer BirthYear=");
            _gamer.GamerBirthYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Gamer Tc=");
            _gamer.GamerTc = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("GAMER  {0} ADDED", _gamer.GamerName);


        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update( )
        {
            throw new NotImplementedException();
        }

        public void Verify( )
        {
            throw new NotImplementedException();
        }
    }
}
