using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    public class SoldierUnit : AbstractUnit
    {
        public SoldierUnit(IArmor armor, SniperRifle rifle, AbstractShootingWeapon autoweapon, AbstractHandgun gun, AbstractKnife knife, AbstractGrenade grenadeone, AbstractGrenade grenadetwo, AbstractGrenade grenadethree, AbstractGrenade grenadefour) : base(1, armor, rifle, autoweapon, gun, knife, grenadeone, grenadetwo, grenadethree, grenadefour)
        {
        }
    }
}
