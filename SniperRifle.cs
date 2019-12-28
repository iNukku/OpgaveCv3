using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    public class SniperRifle : AbstractBigGun
    {
        public override int DoDamage()
        {
            Console.WriteLine($"Bang !!!! Your {this.WeaponName} does {this.Damage} damage to your target!!!!");
            return this.Damage;
        }
        public SniperRifle() : base("AWP Sniper Rifle", 436)
        {
            amountOfBullits = 24;
            amountOfBullitsInClip = 7;
            clipSize = 7;
        }
    }
}
