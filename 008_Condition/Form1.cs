using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _008_Condition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            try
            {
                int iNum1 = (int)nNumber1.Value;
                int iNum2 = (int)nNumber2.Value;

                if (iNum1 > iNum2)
                {
                    lblCompare.Text = "Number1 is greater than Number2";
                }
                else if (iNum1 < iNum2)
                {
                    lblCompare.Text = "Number1 is less than Number2";
                }
                else
                {
                    lblCompare.Text = "Number1 is equal to Number2";
                }
            }
            catch
            {
                MessageBox.Show("Input the numbers");
            }
        }

        private void btnCheckDay_Click(object sender, EventArgs e)
        {
            try
            {
                string strDay = cbDay.Text;
                // string strDay = cbDay.SelectedItem.ToString();
                switch (strDay)
                {
                    case "Monday":
                        lblSelesctedDay.Text = "Selected day is " + strDay;
                        break;
                    case "Tuesday":
                        lblSelesctedDay.Text = "Selected day is " + strDay;
                        break;
                    case "Wednesday":
                        lblSelesctedDay.Text = "Selected day is " + strDay;
                        break;
                    case "Thursday":
                        lblSelesctedDay.Text = "Selected day is " + strDay;
                        break;
                    case "Friday":
                        lblSelesctedDay.Text = "Selected day is " + strDay;
                        break;
                    case "Saturday":
                        lblSelesctedDay.Text = "Selected day is " + strDay;
                        break;
                    case "Sunday":
                        lblSelesctedDay.Text = "Selected day is " + strDay;
                        break;
                    default:
                        lblSelesctedDay.Text = "Day is not selected";
                        break;
                }                
            }
            catch
            {
                MessageBox.Show("Select one of day");
            }
        }
    }
}
