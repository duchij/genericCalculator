using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions; 

namespace genericCalculator
{
    class Program : ApplicationContext
    {
        static void Main(string[] args) 
        {
            try
            {
                MainCalc mc = new MainCalc();
                Application.Run(mc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
