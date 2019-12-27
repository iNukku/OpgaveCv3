using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    public enum ArmorType { light, medium, heavy };
    public enum Colour { red, green, blue}
    interface IArmor
    {
        ArmorType Type { get; }
        int Value { get; }
        Colour ArmorColour{get;}

        void ReduceArmor(int damage);
    }
}
