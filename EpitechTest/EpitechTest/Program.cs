using System;

namespace EpitechTest
{
    class Program
    {
        static void Main(string[] args)
        {


            Character perso = new TestClass("Jean-Luc","Character");
            Console.WriteLine(perso.getName);
            Console.WriteLine(perso.getLife);
            Console.WriteLine(perso.getAgility);
            Console.WriteLine(perso.getStrength);
            Console.WriteLine(perso.getWit);
            Console.WriteLine(perso.getRPGCLASS);
            perso.Attack("my weapon");
        }
    }
}
