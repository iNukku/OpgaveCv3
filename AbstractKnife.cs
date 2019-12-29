using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    public class AbstractKnife : AbstractWeapon
    {
        public AbstractKnife(string name, int damage) : base(name, damage)
        {
        }

        public override int DoDamage()
        {
            Console.WriteLine($"Your {this.WeaponName} slashes your target !!!"); ;
            return this.Damage;
        }
    }
}
