using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericCalculator
{
    public abstract class genericCalc<T>
    {
        public virtual void add(T a, T b, out T res)
        {
            res = default(T);
        }

        public virtual void sub(T a, T b, out T res)
        {
            res = default(T);
        }

        public virtual void multi(T a, T b, out T res)
        {
            res = default(T);
        }

        public virtual void div(T a, T b, out T res)
        {
            res = default(T);
        }


    }
}
