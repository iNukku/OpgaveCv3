using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    public interface IShootingWeapon
    {
        int AmountOfBullits { get; }
        int AmountOfBullitsInClip { get; }
        int ClipSize { get; }

        void Reload();
    }
}
