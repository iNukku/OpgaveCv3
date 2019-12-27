using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    class SniperRifle : AbstractWeapon, IShootingWeapon
    {
        private int amountOfBullits;
        private int amountOfBullitsInClip;
        private int clipSize;

        public int AmountOfBullits { get { return amountOfBullits; } }

        public int AmountOfBullitsInClip { get { return amountOfBullitsInClip; } }

        public int ClipSize { get { return clipSize; } }

        public int GetBullitsLeft()
        {
            throw new NotImplementedException();
        }

        public int GetBullitsLeftInClip()
        {
            throw new NotImplementedException();
        }

        public void Reload()
        {
            throw new NotImplementedException();
        }

        public override int DoDamage()
        {
            Console.WriteLine($"Bang !!!! Your {this.WeaponName} does {this.Damage} damage to your target!!!!");
            return this.Damage;
        }
        public SniperRifle(string name, int damage) : base("AWP Sniper Rifle", 436)
        {
        }
    }
}
