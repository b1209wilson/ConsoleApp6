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





            myCar.mPH = 0;

            myCar.mPHChange = 20;


            myCar.mPH = myCar.GetSpeed(myCar.mPH, myCar.mPHChange);



            Console.WriteLine("My car is traviling at :" + myCar.mPH);

            myCar.mPH = myCar.GetSpeed(myCar.mPH, myCar.mPHChange);


            Console.WriteLine("My car is traviling at :" + myCar.mPH);
        }
    }
}
