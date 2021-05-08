using System;

namespace TBRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon sword = new Weapon("Claymore", 10);

            Player protag = new Player("Kyler", "Martinez", 200, sword);
            Person enemy = new Person("Bad Guy", "Guyson", sword);

            Console.WriteLine(Player.Total_People);
            while (protag.Health_Points > 0 && enemy.Health_Points > 0)
            {
                Console.WriteLine(protag);
                Console.WriteLine(enemy);
                protag.change_hp(-10, enemy.Attack);
                enemy.change_hp(-2, protag.Attack);
            }

            if (enemy.Health_Points <= 0)
            {
                Console.WriteLine("{0} defeated {1}.", protag.FName, enemy.FName);
            }

            else
            {
                Console.WriteLine("{0} defeated {1}.", enemy.FName, protag.FName);
                
            }
        }
    }
}
