using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    public abstract class AbstractShootingWeapon : AbstractWeapon
    {
        protected int amountOfBullits;
        protected int amountOfBullitsInClip;
        protected int clipSize;

        public int AmountOfBullits { get { return amountOfBullits; } }
        public int AmountOfBullitsInClip { get { return amountOfBullitsInClip; } }
        public int ClipSize { get { return clipSize; } }
        public virtual void Reload()
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
        public AbstractShootingWeapon(string name, int damage) : base(name, damage)
        {
        }
    }
}
