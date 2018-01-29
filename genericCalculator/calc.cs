using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericCalculator
{
    class calcInt : genericCalc<int>
    {

        public calcInt()
        {

        }
        public override void add(int a, int b, out int res)
        {
            res = a + b;
        }

        public override void sub(int a, int b, out int res)
        {
            res = a - b;
        }

        public override void div(int a, int b, out int res)
        {
            res = a / b;
        }

        public override void multi(int a, int b, out int res)
        {
            res = a * b;
        }

    }


    class calcFloat : genericCalc<float>
    {
        public calcFloat()
        {

        }

        public override void add(float a, float b, out float res)
        {
            res = a + b;
        }

        public override void sub(float a, float b, out float res)
        {
            res = a - b;
        }

        public override void div(float a, float b, out float res)
        {
            res = a / b;
        }

        public override void multi(float a, float b, out float res)
        {
            res = a * b;
        }

    }


}
