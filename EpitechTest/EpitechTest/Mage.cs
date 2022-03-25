﻿using System;
using System.Collections.Generic;

namespace EpitechTest
{
    public class Mage : Character
    {
        private List<string> weapons = new List<string> { "magic", "wand" };

        public Mage(string name, string RPGCLASS) : base(name, RPGClASS)
        {
            this.life = 70;
            this.strength = 3;
            this.agility = 10;
            this.wit = 10;
            Broadcast();
        }

        public override void Attack(string weapon)
        {
            if (weapons.Contains(weapon))
            {
                base.Attack(weapon);
                Console.WriteLine(base.name + " : Feel the power of my  " + weapon + " !");
            }

        }

        public void Broadcast()
        {
            Console.WriteLine(base.name + " : May the gods be with me.");
        }
    }
}