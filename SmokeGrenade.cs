﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    public class SmokeGrenade : AbstractGrenade
    {

        public override int DoDamage()
        {
            Console.WriteLine("You throw your smokeGrenade");
            return 0;
        }

        public override string DoEffect()
        {
            return "After a few seconds the area is surrounded with smoke.";
        }

        public SmokeGrenade() : base("Smoke Grenade", 0)
        {
        }
    }
}
