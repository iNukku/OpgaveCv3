using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCv3
{
    public abstract class AbstractArmor : IArmor
    {
        #region fields and properties
        private ArmorType type;
        private int value;
        private Colour armorColour;
        public virtual ArmorType Type { get { return type; } }

        public virtual int Value { get { return value; } }

        public virtual Colour ArmorColour { get { return armorColour; } }
        #endregion

        #region public methods
        public virtual void ReduceArmor(int damage)
        {
            value -= damage;
        }

        public override string ToString()
        {
           string returnstring = $"{this.GetType().Name} has {value} armor left. The colour is {armorColour}";

            return returnstring;
        }

        public AbstractArmor(ArmorType armorType, Colour colour)
        {
            this.armorColour = colour;
            type = armorType;

            switch (armorType)
            {
                case ArmorType.light:
                    value = 100;
                    break;
                case ArmorType.medium:
                    value = 150;
                    break;
                case ArmorType.heavy:
                    value = 200;
                    break;
                default:
                    value = 0;
                    break;
            }
        }
        #endregion
    }
}
