using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions; 

namespace genericCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            //cele to mozeme dat do nejakeho cyklu a pod
            //btw dalo by sa to napisat kompletne cez regularne vyrazy t.j. rovno napiseme a+b
            //ale casova tiesna.... a lenivost
            try
            {


                Regex reg = null;

                bool isFloat = false;

                float test = 0;



                Console.WriteLine("Vlozte a:");
                string a = Console.ReadLine();

                //testneme si vstup cislo hociake
                reg = new Regex(@"\d+");
                if (!reg.IsMatch(a))
                {
                    throw new Exception("Toto nieje validne cislo");
                }

                //testneme ci obsahuje . alebo , C# berie len s bodkou
                //ak ano nastavime ze operacia bude float a ak je ciarka menime na bodku
                //mozeme z toho napisat metodu, ale principialne takto
                if (a.IndexOfAny(new char[] { '.', ',' }) != -1)
                {
                    isFloat = true;
                    a= a.Replace('.', ',');
                    //Console.WriteLine(a);
                }

                Console.WriteLine("Vlozte operator validne su +,-,/,*:");
                string optr = Console.ReadLine();

                //checkneme ci su dovolene ooperatory
                reg = new Regex(@"[\+\-\*\\]");
                if (!reg.IsMatch(optr))
                {
                    throw new Exception("Nie je validny operator");
                }

                Console.WriteLine("Vlozte b:");
                string b = Console.ReadLine();
                //detto ako a
                reg = new Regex(@"\d+");
                if (!reg.IsMatch(a))
                {
                    throw new Exception("Toto nieje validne cislo");
                }
                if (b.IndexOfAny(new char[] { '.', ',' }) != -1)
                {
                    isFloat = true;
                    b = b.Replace('.', ',');

                   // Console.WriteLine(b);
                }

                string res = null;

               
                //nasledne volame operaciu calkulacky :), posleme len info o type
                //toto sa da spravit aj krajsie v v dannej triede cez reflection ale este sa musim vela ucit
                //tak na skaredo
                if (isFloat)
                {
                    res = calcInit.calcOperator(a, b, optr, "float");
                }
                else
                {
                    res = calcInit.calcOperator(a, b, optr, "int");
                }

                Console.WriteLine("Vysledok: {0}", res);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.ReadLine();
        }

       
    }
}
