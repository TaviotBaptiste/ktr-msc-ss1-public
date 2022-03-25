using System;
namespace EpitechTest
{
    public abstract class Character : Movable
    {
        protected string name;
        protected int life;
        protected int agility;
        protected int strength;
        protected int wit;
        protected const string RPGClASS = "RpgClass";

        public Character(string name, string RPGCLASS)
        {
            this.name = name;
            this.life = 50;
            this.agility = 2;
            this.strength = 2;
            this.wit = 2;
        }


        public Character(string name)
        {
            this.name = name;
            this.life = 50;
            this.agility = 2;
            this.strength = 2;
            this.wit = 2;
        }


        public string getName { get => name; }
        public string setName { set => name = value; }

        public int getLife { get => life; }
        public int setLife { set => life = value; }

        public int getAgility { get => agility; }
        public int setAgility { set => agility = value; }

        public int getStrength { get => strength; }
        public int setStength { set => strength = value; }

        public int getWit { get => wit; }
        public int setWit { set => wit = value; }

        public string getRPGCLASS { get => RPGClASS; }

        public virtual void Attack(string test)
        {
            Console.WriteLine(this.name + " : Rrrrrrrrr....");
        }

        public virtual void MoveRight()
        {
            Console.WriteLine(this.name + " : moves right");
        }

        public virtual void MoveLeft()
        {
            Console.WriteLine(this.name + " : moves left");
        }

        public virtual void MoveForward()
        {
            Console.WriteLine(this.name + " : moves forward");
        }

        public virtual void MoveBack()
        {
            Console.WriteLine(this.name + " : moves back");
        }

        public virtual void Unsheathe()
        {
            Console.WriteLine(this.name + " unsheathes his weapon.");
        }
    }
}
