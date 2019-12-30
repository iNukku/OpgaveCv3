﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    public class MarineUnit : AbstractUnit
    {
        public MarineUnit(IArmor armor, SniperRifle rifle, IAutomaticWeapon autoweapon, AbstractHandgun gun, AbstractKnife knife, AbstractGrenade grenadeone, AbstractGrenade grenadetwo, AbstractGrenade grenadethree, AbstractGrenade grenadefour) : base(1.5, armor, rifle, autoweapon, gun, knife, grenadeone, grenadetwo, grenadethree, grenadefour)
        {
        }
    }
}
