using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace genericCalculator
{
    public partial class MainCalc : Form
    {
        private bool calculate;

        private string[] opSequence;
        
        private opSequence calcSequece;

        private bool setDecimal
        {
            get; set;
        } 

        public MainCalc()
        {
            InitializeComponent();
            setDecimal = false;

            this.opSequence = new string[3];
            this.calculate = false;

            this.calcSequece = new genericCalculator.opSequence();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClickEvent(object sender, EventArgs e)
        {
            Button Btn = (Button)sender;
            string type = Btn.Name;

            

            if (type.IndexOf("btn_op") != -1)
            {

                //this.calculate = this.calcSequece.Add(this.txt_calcViewer.Text);

                string[] opType = type.Split('_');
                this.txt_calcViewer.Text += Environment.NewLine;
                switch (opType[1])
                {
                    case "opAdd":
                        this.txt_calcViewer.Text += "+";
                        break;
                    case "opSub":
                        this.txt_calcViewer.Text += "-";
                        break;
                    case "opDiv":
                        this.txt_calcViewer.Text += "/";
                        break;
                    case "opMul":
                        this.txt_calcViewer.Text += "/";
                        break;
                }
                this.txt_calcViewer.Text += Environment.NewLine;

                this.calculate = this.calcSequece.Add(this.txt_calcViewer.Text);

            }
            else if (type == "btn_clear")
            {
                this.txt_calcViewer.Text = null;
                this.setDecimal = false;
            }
            else if (type == "btn_point")
            {
                if (!this.setDecimal)
                {
                    this.txt_calcViewer.Text += ".";
                    this.setDecimal = true;
                }
                
            }
            else
            {
                string[] tmp = type.Split('_');
                this.txt_calcViewer.Text += tmp[1];
            }


            if (this.calculate)
            {
                //MessageBox.Show("hura");

                bool isFloat = false;

                string[] seq = this.calcSequece.getSequence(out isFloat);

                if (isFloat)
                {
                    this.txt_calcViewer.Text = calcInit.calcOperator(seq[0], seq[2], seq[1], "float");
                }
                else
                {
                    this.txt_calcViewer.Text = calcInit.calcOperator(seq[0], seq[2], seq[1], "int");
                }



            }

        }
    }
}
