using System;
using System.Collections.Generic;
using System.Text;

namespace TBRPG
{
    class Player : Person
    {
        public int Level { get; private set; }

        public Player(string fname, string lname, Weapon weapon)
        : base(fname, lname, weapon)
        {
            Level = 0;
        }


        public Player(string fname, string lname, int hp, Weapon weapon) //allows for the person to be more customized
        : base(fname, lname, hp, weapon)
        {
            Level = 0;
        }

        public Player(string fname, string lname, int hp, Weapon weapon, string secret) //allows for the person to be more customized
        : base(fname, lname, hp, weapon)

        {
            if (secret == "GodMode")
            {
                Level = 100;
                Health_Points = 1000;
                Attack = 1000; 
            }
        }
        public override string ToString()
        {
            return string.Format("{0} {1} has {2} HP remaining and is at level {3}.", FName, LName, Health_Points, Level);
        }
    }
}
