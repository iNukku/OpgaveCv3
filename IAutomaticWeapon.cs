using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    public interface IAutomaticWeapon
    {
        //Indicate shots fired pr. second
        int RateOfFire { get; }
    }
}
