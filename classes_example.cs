using System;

namespace classes
{
 class RangeRover
        {
            int speed = 0, gear = 1;

        public void Accelerate(int a)
        {
            speed = speed + a;
            Console.Write("Acceleration");
            Console.WriteLine("\nSpeed is : " + speed + "Kmph");
        }

        public void Decelerate(int d)
        {
            speed = speed - d;
            Console.Write("\n.Deceleration");
            Console.WriteLine("\nSpeed is: " + speed + "Kmph");
        }

        public void Gear_Accelerate(int ga)
        {
            gear = gear + ga;
            Console.WriteLine("Gear No is: " + gear);
        }

        public void Gear_Decelerate(int gd)
        {
            gear = gear - gd;
            Console.WriteLine("Gear No is: " + gear);
        }

            static void Main(string[] args)
            {
                RangeRover vehicle = new RangeRover();

                Console.WriteLine("\t-----------------------------------------------\n\t Range Rover Acceleration/Deceleration Display\n\t-----------------------------------------------\t\n");

                vehicle.Accelerate(40);
                vehicle.Gear_Accelerate(3);
                vehicle.Decelerate(15);
                vehicle.Gear_Decelerate(2);

                Console.ReadKey();
            }
        }
}
