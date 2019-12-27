using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    public class AK47 : AbstractWeapon, IShootingWeapon
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
