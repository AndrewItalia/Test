using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_SAC
{
    public partial class Form1 : Form
    {

        float payAmount = 0;
        int numberOfYears = 0;
        float NewpayAmount = 0;
        float TotalProfit = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Assign new values to the varibles 

            if (float.TryParse(txt_payAmount.Text, out payAmount))
            {
                if (int.TryParse(txt_numberOfYears.Text, out numberOfYears))
                {
                    // Sucess

                    // Calculate the loan

                    int counter = 0;

                    while (counter < numberOfYears)
                    {

                        if (numberOfYears >= 5)
                        {
                            NewpayAmount = (float)(payAmount * 0);
                            break;
                        }

                        else 
                        {
                            NewpayAmount = (float)(payAmount - (payAmount * (0.2 * numberOfYears)));
                            counter = counter + 1;
                        }

                    }

                }

                // done with the while loop
                txt_individualWorth.Text = NewpayAmount.ToString("c");
            }

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_collectionWorth_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_individualWorth.Text = " ";
            txt_payAmount.Text = " ";
            txt_numberOfYears.Text = " ";
        }
    }
}
