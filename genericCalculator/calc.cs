using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericCalculator
{
    //definujeme si co pre int a float, nedalo mi to skusil som si Singleton a ma to svoju logiku
    //pamat fakt tak nenarasta...
    //rozvijame nasu abstraktnu genericku triedu, ktora sa da rozsirovat o matiku ako chceme.....
    public sealed class calcInt : genericCalc<int>
    {

        private static readonly calcInt calc = new calcInt();

        //private calcIntS() { }
        private calcInt()
        {

        }

        public static calcInt Calc
        {
            get
            {
                return calc;
            }
        }



        public override void add(int a, int b, out string res)
        {
            res = (a + b).ToString();
        }

        public override void sub(int a, int b, out string res)
        {
            res = (a - b).ToString();
        }

        public override void div(int a, int b, out string res)
        {
            res = (a / b).ToString();
        }

        public override void multi(int a, int b, out string res)
        {
            res = (a * b).ToString();
        }

    }


    class calcFloat : genericCalc<float>
    {

        private static readonly calcFloat calc = new calcFloat();

        //private calcIntS() { }
       

        public static calcFloat Calc
        {
            get
            {
                return calc;
            }
        }


        private calcFloat()
        {

        }

        public override void add(float a, float b, out string res)
        {
            res =(a + b).ToString();
        }

        public override void sub(float a, float b, out string res)
        {
            res = (a - b).ToString();
        }

        public override void div(float a, float b, out string res)
        {
            res = (a / b).ToString();
        }

        public override void multi(float a, float b, out string res)
        {
            res = (a * b).ToString();
        }

    }


}
