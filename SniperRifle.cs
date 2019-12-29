using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    public class SniperRifle : AbstractBigGun
    {
        public SniperRifle() : base("AWP Sniper Rifle", 436)
        {
            amountOfBullits = 24;
            amountOfBullitsInClip = 7;
            clipSize = 7;
        }
    }
}
