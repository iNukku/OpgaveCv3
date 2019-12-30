using System;

namespace OpgaveCv3
{
    class Program
    {
        static void Main(string[] args)
        {

            MarineArmor myArmor = new MarineArmor();

            // End create armor

            //Create Knife
            AbstractKnife myKnife = new ButterflyKnife();

            //End create Knife

            //Create Sniper
            SniperRifle mySniper = new SniperRifle();


            //Create AK
            IAutomaticWeapon myAK = new AK47();

            AbstractHandgun myUSP = new USP();

            //Create grenade
            AbstractGrenade myGrenade = new HEGrenade();
            AbstractGrenade myGrenade1 = new HEGrenade();
            AbstractGrenade myGrenade2 = new HEGrenade();
            AbstractGrenade myGrenade3 = new HEGrenade();

            IUnit myMarine = new MarineUnit(myArmor, mySniper, myAK, myUSP, myKnife, myGrenade, myGrenade1, myGrenade2, null);
            myMarine.Attack();
            myMarine.ReloadWeapon();

            int x = myMarine.Health;
            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
