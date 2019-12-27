using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    public class AK47 : AbstractBigGun
    {
        public override int DoDamage()
        {
            Console.WriteLine($"pop !!!! Your {this.WeaponName} does {this.Damage} damage to your target!!!!");
            return this.Damage;
        }
        public AK47() : base("AK-47", 88)
        {
            amountOfBullits = 90;
            amountOfBullitsInClip = 30;
            clipSize = 30;
        }
    }
}
