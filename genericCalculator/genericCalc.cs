using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericCalculator
{
    //spravime si abstraktnu triedu kam narveme co chceme, este by sa to dalo ze interface... :)
    public abstract class genericCalc<T>
    {
        public virtual void add(T a, T b, out string res)
        {
            res = default(T).ToString();
        }

        public virtual void sub(T a, T b, out string res)
        {
            res = default(T).ToString();
        }

        public virtual void multi(T a, T b, out string res)
        {
            res = default(T).ToString();
        }

        public virtual void div(T a, T b, out string res)
        {
            res = default(T).ToString();
        }


    }
}
