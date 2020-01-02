using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    class MarineBuilder : UnitBuilder
    {
        public override void BuildArmor()
        {
            armor = new MarineArmor();
        }

        public override void BuildGuns()
        {
            sniper = new SniperRifle();
            shooter = new AK47();
            gun = new USP();
        }

        public override void BuildKnife()
        {
            knife = new ButterflyKnife();
        }

        public override void BuildThrown()
        {
            g1 = new HEGrenade();
            g2 = new SmokeGrenade();
            g3 = new FlashbangGrenade();
            g4 = null;
        }

        public override void BuildStats()
        {
            health = 100;
        }

        public override void BuildUnit()
        {
            unit = new MarineUnit(armor, sniper, shooter, gun, knife, g1, g2, g3, g4);
        }
        public override IUnit Unit { get { return unit; } }

        public MarineBuilder()
        {
        }
    }
}
