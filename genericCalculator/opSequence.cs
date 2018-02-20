using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace genericCalculator
{
    class opSequence
    {
        private string[] sequence = new string[3];


        private bool isFloat = false;

        public bool Add(string txt)
        {
            string[] tmp = Regex.Split(txt, @"\r\n");

            if (tmp.Length < 2)
            {
                return false;
            }


            if (tmp[2].Trim().Length == 0)
            {
               // this.index = 0;
                return false;
            }

            for (int i = 0; i < 3; i++)
            {
                if (i != 1)
                {
                    if (tmp[i].IndexOf(',')!=-1)
                    {
                        this.isFloat = true;
                    }
                }
                else
                {
                    if (tmp[1] == "/")
                    {
                        this.isFloat = true;
                    }
                }

                this.sequence[i] = tmp[i];
            }

            return true;

        }

        public string[] getSequence(out bool isFloat)
        {
            isFloat = this.isFloat;
            return this.sequence;
        }

      
    }
        
}
