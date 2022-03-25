using System;
namespace EpitechTest.exceptions
{
    public class WeaponException : Exception
    {

        string Name { get; }

        public void NoWeapon()
        {
            Console.WriteLine(Name + " : I refuse to fight with my bare hands .");
        }

        public void WrongWeaponWarrior(string weapon)
        {
            Console.WriteLine(Name + " : A "+ weapon +" ?? What should I do with this ?");
        }

        public void WrongWeaponMage(string weapon)
        {
            Console.WriteLine(Name + " I don 't need this stupid " + weapon + "! Don 't misjudge my powers !");
        }

        public void TryToAttack()
        {
            throw new ArgumentNullException();
        }

    }
}
