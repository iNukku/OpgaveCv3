using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    public abstract class AbstractBigGun : AbstractShootingWeapon
    {
        public AbstractBigGun(string name, int damage) : base(name, damage)
        {
        }
    }
}
