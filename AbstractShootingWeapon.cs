using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    public abstract class AbstractShootingWeapon : AbstractWeapon
    {
        #region fields and properties
        protected int amountOfBullits;
        protected int amountOfBullitsInClip;
        protected int clipSize;

        public int AmountOfBullits { get { return amountOfBullits; } }
        public int AmountOfBullitsInClip { get { return amountOfBullitsInClip; } }
        public int ClipSize { get { return clipSize; } }

        #endregion
        #region public methods
        public virtual void Reload()
        {
            int missingbullitsInClip = clipSize - amountOfBullitsInClip;
            if (amountOfBullits >= missingbullitsInClip)
            {
                amountOfBullitsInClip += missingbullitsInClip;
                amountOfBullits -= missingbullitsInClip;
                Console.WriteLine($"Reloaded weapon - your {WeaponName} now has {amountOfBullitsInClip} and you have {amountOfBullits} left");
            }
            else
            {
                amountOfBullitsInClip += amountOfBullits;
                amountOfBullits = 0;
                Console.WriteLine($"bullits in clip: {amountOfBullitsInClip}; Bullits left: 0");
            }
        }

        public override int DoDamage()
        {
            if (this.amountOfBullitsInClip > 0)
            {
                Console.WriteLine($"Boom - Your {this.WeaponName} fires !!!");
                amountOfBullitsInClip--;
                return this.Damage;
            }
            else
            {
                Console.WriteLine("Click.... You seem to be out of bullits");
                return 0;
            }
        }
        #endregion
        #region constructors
        public AbstractShootingWeapon(string name, int damage) : base(name, damage)
        {
        }
        #endregion
    }
}
