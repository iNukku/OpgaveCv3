using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    public class AK47 : AbstractBigGun, IAutomaticWeapon
    {
        private int rateOfFire;
        public int RateOfFire { get { return rateOfFire; } }

        public AK47() : base("AK-47", 88)
        {
            amountOfBullits = 90;
            amountOfBullitsInClip = 30;
            clipSize = 30;
            rateOfFire = 3;
        }
    }
}
