using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _003_Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Add(int a, int b)
        {
            int res = 0;
            res = a + b;
            return res;
        }

        private int Sub(int a, int b)
        {
            int res = 0;
            res = a - b;
            return res;
        }

        private int Mul(int a, int b)
        {
            int res = 0;
            res = a * b;
            return res;
        }

        private double Div(double a, double b)
        {
            double res = 0;
            res = a / b;
            return res;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tbFirst.Text);
            int iNumB = int.Parse(tbSecond.Text);
            tbResult.Text = Add(iNumA,iNumB).ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tbFirst.Text);
            int iNumB = int.Parse(tbSecond.Text);
            tbResult.Text = Sub(iNumA, iNumB).ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tbFirst.Text);
            int iNumB = int.Parse(tbSecond.Text);
            tbResult.Text = Mul(iNumA, iNumB).ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tbFirst.Text);
            int iNumB = int.Parse(tbSecond.Text);
            tbResult.Text = Div((double)iNumA, (double)iNumB).ToString();
        }
    }
}
