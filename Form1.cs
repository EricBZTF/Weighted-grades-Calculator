using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace GradeCalc2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
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
                    else
                    {
                        values.Add(Convert.ToDouble(tb.Text));
                    }
                }
                catch(FormatException)
                {
                    MessageBox.Show("Buchstaben sind nicht zulässig", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
         
            double result = (((Convert.ToDouble(values[0]) * Convert.ToDouble(values[1]))) + ((Convert.ToDouble(values[2]) * Convert.ToDouble(values[3]))) + ((Convert.ToDouble(values[4]) * Convert.ToDouble(values[5]))) + ((Convert.ToDouble(values[6]) * Convert.ToDouble(values[7])))) / 100;
            decimal.Round((decimal)result, 1);
            double finalGrade = Math.Round(result * 2) / 2;
            MessageBox.Show("Durchschnitt ist " + result + " \n Zeugnissnote ist " +finalGrade, "Resultat", MessageBoxButtons.OK);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}
