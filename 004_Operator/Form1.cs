using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _004_Operator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShiftLeft_Click(object sender, EventArgs e)
        {
            int iResult = 0;
            int iTemp = int.Parse(tbResult.Text);
            int iNumber = int.Parse(tbNumber.Text);

            iResult = iTemp << iNumber;
            tbResult.Text = iResult.ToString();
        }

        private void tbResult_TextChanged(object sender, EventArgs e)
        {
            tbResultBit.Text = Convert.ToString(int.Parse(tbResult.Text), 2) + "b";
        }

        private void btnShiftRight_Click(object sender, EventArgs e)
        {
            int iResult = 0;
            int iTemp = int.Parse(tbResult.Text);
            int iNumber = int.Parse(tbNumber.Text);

            iResult = iTemp >> iNumber;
            tbResult.Text = iResult.ToString();

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int iTemp = int.Parse(tbResult.Text);
            int iNumber = int.Parse(tbNumber.Text);

            iTemp += iNumber;
            tbResult.Text = iTemp.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int iTemp = int.Parse(tbResult.Text);
            int iNumber = int.Parse(tbNumber.Text);

            iTemp -= iNumber;
            tbResult.Text = iTemp.ToString();
        }

        private void btnIncreaseFirst_Click(object sender, EventArgs e)
        {
            int iTemp = int.Parse(tbResult.Text);
            tbResult.Text = (++iTemp).ToString();
            tbResultAfter.Text = iTemp.ToString();
        }

        private void btnIncreaseLater_Click(object sender, EventArgs e)
        {
            int iTemp = int.Parse(tbResult.Text);
            tbResult.Text = (iTemp++).ToString();
            tbResultAfter.Text = iTemp.ToString();
        }

        private void btnBitAnd_Click(object sender, EventArgs e)
        {
            int iTemp1 = int.Parse(tbResult.Text);
            int iTemp2 = int.Parse(tbResultAfter.Text);
            int iNumber = int.Parse(tbNumber.Text);

            bool bResult = (iTemp1 > iNumber && iTemp2 > iNumber);

            tbResultBit.Text = bResult.ToString();
        }

        private void btnBitOr_Click(object sender, EventArgs e)
        {
            int iTemp1 = int.Parse(tbResult.Text);
            int iTemp2 = int.Parse(tbResultAfter.Text);
            int iNumber = int.Parse(tbNumber.Text);

            bool bResult = (iTemp1 > iNumber || iTemp2 > iNumber);

            tbResultBit.Text = bResult.ToString();
        }
    }
}
