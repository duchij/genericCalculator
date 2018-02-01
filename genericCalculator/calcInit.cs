using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace genericCalculator
{

    //malinkato factory method.....aspon dufam, da sa to aj brutalne elegantnejsie ale musim sa este ucit
    public static class calcInit
    {

        static calcInit()
        {

        }
              
        public static string calcOperator(string a, string b, string optr, string type)
        {

            string res = null;
            switch (type)
            {
                case "int":
                    calcInt ci = new calcInt();

                    int aI = int.Parse(a);
                    int bI = int.Parse(b);

                    if (optr == "+") { ci.add(aI, bI, out res);  }
                    if (optr == "-") { ci.sub(aI, bI, out res); }
                    if (optr == "/") { ci.div(aI, bI, out res); }
                    if (optr == "*") { ci.multi(aI, bI, out res); }
                    break;
                case "float":

                    

                    calcFloat cf = new calcFloat();
                    bool st = true;

                    float aF;
                    st = float.TryParse(a, out aF);

                    float bF; 
                    st = float.TryParse(b,out bF);

                    if (st == false)
                    {
                        throw new Exception("Nesparavny format musi byt");
                    }

                    if (optr == "+") { cf.add(aF, bF, out res); }
                    if (optr == "-") { cf.sub(aF, bF, out res); }
                    if (optr == "/") { cf.div(aF, bF, out res); }
                    if (optr == "*") { cf.multi(aF, bF, out res); }
                    break;

            }

            return res;
        }

    }
}
