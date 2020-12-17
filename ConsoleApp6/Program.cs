using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Car myCar = new Car();

            myCar.make = " Ford ";

            myCar.model = " Fiesta ";

            //string ans = string.Format("My Car is a {0} {1}.",myCar.make,myCar.model);

            //Console.WriteLine(ans);





            //myCar.mPH = 0;

            //myCar.mPHChange = 20;

            //myCar.mPH = myCar.GetSpeed(myCar.mPH, myCar.mPHChange);


            //myCar.mPH = myCar.GetSpeed(myCar.mPH, myCar.mPHChange);

            //Console.WriteLine("My car is travling at " + myCar.mPH);


            Console.WriteLine("Enter the current speed ?");

            string ans = Console.ReadLine();

            myCar.mPH = myCar.GetNumber(ans);



            Console.WriteLine("Enter the Change in speed?");

                string change = Console.ReadLine();

            myCar.mPHChange = myCar.GetNumber(change);


            myCar.mPH = myCar.GetSpeed(myCar.mPH, myCar.mPHChange);

            Console.WriteLine("My car is travling at " + myCar.mPH);




        }
    }
}
