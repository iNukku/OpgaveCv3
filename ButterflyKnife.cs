using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    public class ButterflyKnife : AbstractWeapon
    {
        public ButterflyKnife() : base("Butterfly Knife", 78) { }

        public override int DoDamage()
        {
            Console.WriteLine($"Your {this.WeaponName} swiftly does {this.Damage} damage to your target!!!!");
            return this.Damage;
        }

    }
}
