using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    public abstract class AbstractGrenade : AbstractWeapon, IThrown
    {
        public abstract void DoEffect();

        public AbstractGrenade(string name, int damage) : base(name, damage)
        {
        }
    }
}
