using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    public class HuntingKnife : AbstractWeapon
    {

        public override int DoDamage()
        {
            Console.WriteLine($"Your {this.WeaponName} slowly does {this.Damage} damage to your target!!!!");
            return this.Damage;
        }
        public HuntingKnife() : base("HuntingKnife", 90)
        {
        }
    }
}
