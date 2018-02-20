using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace genericCalculator
{

    //vytvorime staticku triedu a nasledne dla stavu co potrebujeme....

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

                    int aI = int.Parse(a);
                    int bI = int.Parse(b);

                    if (optr == "+") { calcInt.Calc.add(aI, bI, out res);  }
                    if (optr == "-") { calcInt.Calc.sub(aI, bI, out res); }
                    if (optr == "/") { calcInt.Calc.div(aI, bI, out res); }
                    if (optr == "*") { calcInt.Calc.multi(aI, bI, out res); }
                    break;
                case "float":

                    bool st = true;

                    float aF;
                    st = float.TryParse(a, out aF);

                    float bF; 
                    st = float.TryParse(b,out bF);

                    if (st == false)
                    {
                        throw new Exception("Nesparavny format musi byt");
                    }

                    if (optr == "+") { calcFloat.Calc.add(aF, bF, out res); }
                    if (optr == "-") { calcFloat.Calc.sub(aF, bF, out res); }
                    if (optr == "/") { calcFloat.Calc.div(aF, bF, out res); }
                    if (optr == "*") { calcFloat.Calc.multi(aF, bF, out res); }
                    break;

            }

            return res;
        }

    }
}
