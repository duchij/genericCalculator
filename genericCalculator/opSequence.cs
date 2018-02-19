using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace genericCalculator
{
    class opSequence
    {
        private string[] sequence = new string[3];

        private int index = 0;

        private bool isFloat = false;

        public bool Add(string txt)
        {

            if (index == sequence.Length - 1)
            {
                return true;
            }
            

            using (StreamReader sr = new StreamReader(txt))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    sequence[index] = line;
                    index++;
                }
            }

            return false;

        }

        public string[] getSequence(out bool isFloat)
        {
            isFloat = this.isFloat;
            return this.sequence;
        }

      
    }
        
}
