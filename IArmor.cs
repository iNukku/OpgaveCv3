using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    //Enums
    public enum ArmorType { light, medium, heavy };
    public enum Colour { red, green, blue}
    public interface IArmor
    {
        ArmorType Type { get; }
        int Value { get; }
        Colour ArmorColour{get;}

        void ReduceArmor(int damage);
    }
}
