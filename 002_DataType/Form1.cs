using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002_DataType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToShort_Click(object sender, EventArgs e)
        {
            Clear();
            try
            {
                short sNumber = short.Parse(tbNumber.Text);
                lblShort.Text = sNumber.ToString();
            }
            catch (Exception err)
            {
                lblException.Text = err.ToString();
            }      
        }

        private void btnToInt_Click(object sender, EventArgs e)
        {
            Clear();
            try
            {
                int iNumber = int.Parse(tbNumber.Text);
                lblInt.Text = iNumber.ToString();
            }
            catch (Exception err)
            {
                lblException.Text = err.ToString();
            }
        }

        private void btnToDouble_Click(object sender, EventArgs e)
        {
            Clear();
            try
            {
                double dNumber = double.Parse(tbNumber.Text);
                lblDouble.Text = dNumber.ToString();
            }
            catch (Exception err)
            {
                lblException.Text = err.ToString();
            }
        }

        private void Clear()
        {
            //tbNumber.Text = "";
            lblShort.Text = "0";
            lblInt.Text = "0";
            lblDouble.Text = "0";
            lblException.Text = "-";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbNumber.Text = "";
            Clear();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            Clear();
            short sNumber = 0;
            int iNumber = 0;
            double dNumber = 0.0f;
            
            if (short.TryParse(tbNumber.Text, out sNumber))
            {
                lblShort.Text = sNumber.ToString();
            }
            else if(int.TryParse(tbNumber.Text, out iNumber)){
                lblInt.Text = iNumber.ToString();
            }
            else if (double.TryParse(tbNumber.Text, out dNumber)) {
                lblDouble.Text = dNumber.ToString();
            }
            else
            {
                lblException.Text = "It can't be converted!!!!";
            }
        }
    }
}
