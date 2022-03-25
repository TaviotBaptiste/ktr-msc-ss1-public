using System;

namespace EpitechTest
{
    class Program
    {
        static void Main(string[] args)
        {

            //STEP 01
            //Character perso = new TestClass("Jean-Luc","Character");
            //Console.WriteLine(perso.getName);
            //Console.WriteLine(perso.getLife);
            //Console.WriteLine(perso.getAgility);
            //Console.WriteLine(perso.getStrength);
            //Console.WriteLine(perso.getWit);
            //Console.WriteLine(perso.getRPGCLASS);
            //perso.Attack("my weapon");

            //STEP 02
            //Character warrior = new Warrior("Jean-Luc", "Warrior");
            //Character mage = new Mage("Robert", "Mage");
            //warrior.Attack("hammer");
            //mage.Attack("magic");


            //SETP 03

            //SETP 04
            Warrior warrior = new Warrior("Jean-Luc", "Warrior");
            Mage mage = new Mage("Robert", "Mage");
            warrior.MoveRight();
            warrior.MoveLeft();
            warrior.MoveBack();
            warrior.MoveForward();
            mage.MoveRight();
            mage.MoveLeft();
            mage.MoveBack();
            mage.MoveForward();
        }
    }
}
