using System;
using System.Collections.Generic;

namespace EpitechTest
{
    public class Warrior : Character
    {
        private List<string> weapons = new List<string> { "sword", "hammer" };

        public Warrior(string name, string RPGCLASS):base(name, RPGClASS)
        {
            this.life = 100;
            this.strength = 10;
            this.agility = 8;
            this.wit = 3;
            Broadcast();
        }

        public override void Attack(string weapon)
        {
            if (weapons.Contains(weapon))
            {
                base.Attack(weapon);
                Console.WriteLine(base.name + " : I'll crush you with my " + weapon + " !");
            }
        }


        public void Broadcast()
        {
            Console.WriteLine(base.name + " : My name will go down in history!");
        }

        public void MoveRight()
        {

        }
    }
}
