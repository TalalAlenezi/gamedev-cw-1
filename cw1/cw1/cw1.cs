using System;

namespace work1
{
    class Program
    {
        static double playerSpeed;
        static void Main(string[] args)
        {
            string characterName = "Ahmad";
            float speed = 1.65f;
            int age = 15;
            string superPower1 = "Steel Armor";
            string superPower2 = "Night Vision";

            //Second hero
            string heroName = "Link";
            double heroHeight = 175.0;
            int heroAge = 17;
            string heroSuperPower1 = "Steel Armor";
            string heroSuperPower2 = "Master Sword";

            int ageDifference = heroAge - age;


            //Console.WriteLine("My Name is {0}, my super powers are {1} and {2}. I'm {3} years old and my speed is {4}", characterName, superPower1, superPower2, age, speed);
            //Console.WriteLine("The Age difference is {0}", ageDifference);

            //bonuse
            //if (superPower1 == heroSuperPower1) {
            //    Console.WriteLine("They Have the Same Power: {0}",superPower1);
            //}
            //if (superPower2 == heroSuperPower2)
            //{
            //    Console.WriteLine("They Have the Same Power: {0}", superPower2);
            //}

            //cw3

            setSpeed(2.5);
            getSpeed();

        }

        static void setSpeed(double speed)
        {
            playerSpeed = speed;
        } 

        static void getSpeed()
        {
            Console.WriteLine("The current player speed is {0}", playerSpeed);
        }
    }
}
