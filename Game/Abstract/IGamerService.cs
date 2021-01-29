using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Abstract
{
    interface IGamerService
    {
        void Verify();
        void Add();
        void Update();
        void Delete();
        
    }
}
