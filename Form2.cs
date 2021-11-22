using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCalc2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void calcFinalBtn_Click(object sender, EventArgs e)
        {
            ArrayList values = new ArrayList();
            ArrayList textBoxes = new ArrayList();
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    textBoxes.Add(c);
                }
            }

            foreach (TextBox tb in textBoxes)
            {
                try
                {
                    if (String.IsNullOrEmpty(tb.Text))
                    {
                        values.Add(0);
                    }
                    else if(tb.Name == "wantedGrade")
                    {

                    }else
                    {
                        values.Add(Convert.ToDouble(tb.Text));
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Buchstaben sind nicht zulässig", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }

            
            try {
                double wanted = Convert.ToDouble(wantedGrade.Text) - 0.25;
                double finalWeight = 100 - Convert.ToDouble(values[0]) - Convert.ToDouble(values[2]) - Convert.ToDouble(values[4]);
                double final = wanted * 100 - (Convert.ToDouble(values[0]) * Convert.ToDouble(values[1]) + Convert.ToDouble(values[2]) * Convert.ToDouble(values[3]) + Convert.ToDouble(values[4]) * Convert.ToDouble(values[5]));

                if (final / finalWeight > 6)
                {
                    MessageBox.Show("Your wanted grade is not possible anymore :(", "Needed Grade", MessageBoxButtons.OK);

                }
                else
                {
                    MessageBox.Show("You need at least a " + final / finalWeight, "Needed Grade", MessageBoxButtons.OK);
                }
                }

            catch (FormatException)
            {
                MessageBox.Show("Buchstaben sind nicht zulässig", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           

            double result = (((Convert.ToDouble(values[0]) * Convert.ToDouble(values[1]))) + ((Convert.ToDouble(values[2]) * Convert.ToDouble(values[3]))) + ((Convert.ToDouble(values[4]) * Convert.ToDouble(values[5])))) / 100;
            double finalGrade = Math.Round(result * 2) / 2;

        }
    }
}
