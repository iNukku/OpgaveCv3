using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    public abstract class AbstractHandgun : AbstractShootingWeapon
    {
        public AbstractHandgun(string name, int damage) : base(name, damage)
        {
        }

    }
}
