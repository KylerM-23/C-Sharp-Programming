using System;
using System.Collections.Generic;
using System.Text;

namespace TBRPG
{
    class Weapon
    {
        public string Weapon_Name { get; private set; }

        public int Weapon_Damage { get; private set; }

        public Weapon(string name, int attack)
        {
            Weapon_Name = name;
            Weapon_Damage = attack;
        }
        
    }
}
