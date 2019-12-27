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


            Console.ReadKey();
        }
    }
}
