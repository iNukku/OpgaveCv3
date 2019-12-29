using System;

namespace OpgaveCv3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create armor
            MarineArmor myArmor = new MarineArmor();
            Console.WriteLine(myArmor.ToString());
            myArmor.ReduceArmor(100);
            Console.WriteLine(myArmor.ToString());
            // End create armor

            //Create Knife
            IWeapon myKnife = new ButterflyKnife();
            Console.WriteLine(myKnife.ToString());
            myKnife.DoDamage();
            //End create Knife

            //Create Sniper
            IWeapon mySniper = new SniperRifle();
            Console.WriteLine(mySniper.ToString());
            mySniper.DoDamage();

            //Create AK
            IWeapon myAK = new AK47();
            Console.WriteLine(myAK.ToString());
            myAK.DoDamage();

            //Create grenade
            IWeapon myGrenade = new HEGrenade();
            Console.WriteLine(myGrenade.ToString());
            myGrenade.DoDamage();


            Console.ReadKey();
        }
    }
}
