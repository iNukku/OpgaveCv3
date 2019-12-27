﻿using System;
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

        public void Reload()
        {
            int missingbullitsInClip = clipSize - amountOfBullitsInClip;
            if (amountOfBullits >= missingbullitsInClip)
            {
                amountOfBullitsInClip += missingbullitsInClip;
                amountOfBullits -= missingbullitsInClip;
            }
            else
            {
                amountOfBullitsInClip += amountOfBullits;
                amountOfBullits = 0;
            }
        }

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
