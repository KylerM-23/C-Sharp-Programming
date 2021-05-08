using System;
using System.Collections.Generic;
using System.Text;

namespace TBRPG
{
    
    class Person
    {
        public static int Total_People { get; private set; }
        public string FName { get;  protected set; }
        public string LName { get; protected set; }
        
        public int Health_Points { get; protected set; }
        public int Attack { get; protected set; }

        public Weapon Personal_Weapon { get; protected set; }

        public void change_hp(int multi, int change)
        {
            Health_Points = Health_Points + multi * change; //multi allows to use one function to increase or decrease

        }

        public Person(string fname, string lname, Weapon weapon)
        {
            FName = fname;
            LName = lname;
            Personal_Weapon = weapon;
            Health_Points = 100; //default health
            Attack = Personal_Weapon.Weapon_Damage;
            Total_People++;
        }


        public Person(string fname, string lname, int hp, Weapon weapon) //allows for the person to be more customized
        {
            FName = fname;
            LName = lname;
            Health_Points = hp;
            Personal_Weapon = weapon;
            Attack = Personal_Weapon.Weapon_Damage;
            Total_People++;
        }

        public override string ToString()
        {

            return string.Format("{0} {1} has {2} HP remaining.",FName, LName, Health_Points);
        }
    }
}
