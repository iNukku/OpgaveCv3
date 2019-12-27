using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    public class AbstractKnife : IWeapon
    {
        private string weaponName;
        private int damage;
        public string WeaponName { get { return weaponName; } }
        public int DoDamage()
        {
            Console.WriteLine($"Your {weaponName} does {damage} damage to your target!!!!");
            return damage;
        }

        public AbstractKnife(string name, int damage)
        {
            this.weaponName = name;
            this.damage = damage;
        }

        public override string ToString()
        {
            string returnString = $"Your knife is a {weaponName} and its basedamage is {damage}";
            return returnString;
        }
    }
}
