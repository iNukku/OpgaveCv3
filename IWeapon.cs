using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    public interface IWeapon
    {
        string WeaponName { get; }

        int DoDamage();
    }
}
