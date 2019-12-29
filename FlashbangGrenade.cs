using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    public class FlashbangGrenade : AbstractGrenade
    {

        public override int DoDamage()
        {
            Console.WriteLine("You Throw your flashbang grenade");
            DoEffect();
            return 0;
        }

        public override void DoEffect()
        {
            Console.WriteLine("Every opponent in front of you are blinded");
        }

        public FlashbangGrenade() : base("Flashbang Grenade", 0)
        {
        }
    }
}
