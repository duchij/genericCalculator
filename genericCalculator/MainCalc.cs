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

            //no vzdy budeme spocitatavat len dve cisla a nasledne vysledok spocitam s dalsim, 
            //do buducna mozem tieto operacie zretazovat a vytvarat kombinacie
            //t.c. tak jednoducho po dve
            this.calcSequece = new genericCalculator.opSequence();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClickEvent(object sender, EventArgs e)
        {
            //cast objektu 
            Button Btn = sender as Button;
            //checkneme ci naozaj bol stlaceny button
            if (Btn == null)
            {
                throw new Exception("Invalid button....");
            }
            string type = Btn.Name;

            //parsujeme - ak bol stlaceny operator tak ideme
            if (type.IndexOf("btn_op") != -1)
            {
                //ak nie je ziadne cislo tak smola
                if (this.txt_calcViewer.Text.Trim().Length > 0)
                {
                    string[] opType = type.Split('_');

                    if (opType[1] != "opRun")
                    {
                        this.txt_calcViewer.Text += Environment.NewLine;
                    }

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
                            this.txt_calcViewer.Text += "*";
                            break;

                    }

                    if (opType[1] != "opRun")
                    {
                        this.txt_calcViewer.Text += Environment.NewLine;
                    }

                    this.calculate = this.calcSequece.Add(this.txt_calcViewer.Text);
                }
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
                    this.txt_calcViewer.Text += ",";
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

                bool isFloat = false;

                string[] seq = this.calcSequece.getSequence(out isFloat);

                //inak operacia ak je float a inak kde je int

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
