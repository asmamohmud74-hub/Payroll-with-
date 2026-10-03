using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payroll_with_overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
              
            {
                decimal hoursWorked = decimal.Parse(txtHoursworked.Text);
                decimal hourlyPayRate = decimal.Parse(textHourlypayrate.Text);
                decimal grossPay = 0.0m;

                if (hoursWorked > 40)
                {
                    // Saacadaha caadiga ah (40) + Saacadaha dheeraadka ah
                    decimal basePay = 40 * hourlyPayRate;
                    decimal overtimeHours = hoursWorked - 40;
                    decimal overtimePay = overtimeHours * (hourlyPayRate * 1.5m);

                    grossPay = basePay + overtimePay;
                }
                else
                {
                    // Marka saacaduhu 40 ama ka yar yihiin
                    grossPay = hoursWorked * hourlyPayRate;
                }

                Grosspay.Text = grossPay.ToString("c");
            }
            catch (Exception)
            {
                MessageBox.Show("Fadlan geli tirooyin sax ah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            txtHoursworked.Clear();
            textHourlypayrate.Clear();
            txtcalculatecrosspay.Text = "";

           
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
   
