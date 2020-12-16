using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Car
    {
        public string model;

        public string make;

        public int mPH;

        public int mPHChange;

        public int GetSpeed(int mPH, int mPHChange)
        {

            mPH = mPH + mPHChange;

            return mPH;



        }
    }
}
