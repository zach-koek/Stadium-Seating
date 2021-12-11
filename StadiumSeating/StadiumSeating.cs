using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StadiumSeating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //This is what happens when the Calculate button is clicked.
        private void btnCalcRev_Click(object sender, EventArgs e)
        {
            //creating variables to use. Used to this from java class.
            int classATotal;
            int classBTotal;
            int classCTotal;
            int total;

            /*this is my data validation lines of code. This will check to see if numbers are
                actual numbers and then if it is it will continue with the rest of the if statement.
                if it doesnt contain numbers then it will send an error message. I Dont beleive at try
                statement would be nessecary.
             */
            if (Int32.TryParse(txtBoxClassASold.Text, out classATotal) && Int32.TryParse(txtBoxClassBSold.Text, out classBTotal)
                && Int32.TryParse(txtBoxClassCSold.Text, out classCTotal))
            {
                //This is the only other validation I could think of for this program. 
                
                if (classATotal >= 0 && classBTotal >= 0 && classCTotal >= 0)
                {
                    /*IF ITS ONLY A POSITIVE NUMBER...these lines of code will run.
                     *   this first one changes the text in the boxes to ints
                    */
                    classATotal = Convert.ToInt32(txtBoxClassASold.Text);
                    classBTotal = Convert.ToInt32(txtBoxClassBSold.Text);
                    classCTotal = Convert.ToInt32(txtBoxClassCSold.Text);


                    //the arithmetic behind the form
                    classATotal = (classATotal * 15);
                    classBTotal = (classBTotal * 12);
                    classCTotal = (classCTotal * 9);
                    total = classATotal + classBTotal + classCTotal;

                    //writes the results to the revenue boxes
                    txtBoxClassARev.Text = classATotal.ToString("C2");
                    txtBoxClassBRev.Text = classBTotal.ToString("C2");
                    txtBoxClassCRev.Text = classCTotal.ToString("C2");
                    txtBoxTotal.Text = total.ToString("C2");

                }
                else
                {
                    MessageBox.Show("Did you sell negative tickets? Please only use positive numbers.");
                }

            }
            //else statement for an error if client doesnt put in real numbers

            else
            {
                MessageBox.Show("Please only put numbers in the box, do not use letters.");
            }
           

            

        }

        //when clear is pressed it takes away all the numbers.
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxClassASold.Clear();
            txtBoxClassBSold.Clear();
            txtBoxClassCSold.Clear();
            txtBoxClassARev.Clear();
            txtBoxClassBRev.Clear();
            txtBoxClassCRev.Clear();
            txtBoxTotal.Clear();
        }

        //when you press exit it will close out the form.
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
