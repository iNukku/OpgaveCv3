using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    public class HEGrenade : AbstractGrenade
    {

        public override int DoDamage()
        {
            Console.WriteLine("Your grenade explodes and fragments shatter all over the place");
            DoEffect();
            return this.Damage;
        }

        public override void DoEffect()
        {
            Console.WriteLine("The bang is loud and ruins everyones hearing");
        }

        public HEGrenade() : base("He-Grenade", 99)
        {
        }
    }
}
