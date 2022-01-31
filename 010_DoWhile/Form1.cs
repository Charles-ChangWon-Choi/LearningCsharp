using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _010_DoWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRottery_Click(object sender, EventArgs e)
        {
            //List<int> iList = new List<int>();
            int[] iArray = new int[5];
            int iCount = 0;

            StringBuilder sb = new StringBuilder();
            Random rdNum = new Random();

            while (Array.IndexOf(iArray, 0) != -1)
            {
                int iNumber = rdNum.Next(1, 46);

                if (Array.IndexOf(iArray, iNumber) == -1)
                {
                    iArray[iCount] = iNumber;
                    //sb.Append(string.Format("{0}, ", iNumber));
                    iCount++;
                }
            }
            Array.Sort(iArray);
            for(int i=0; i<4; i++)
            {
                sb.Append(string.Format("{0}, ", iArray[i]));
            }
            sb.Append(string.Format("{0}", iArray[4]));

            lblRottery.Text = sb.ToString();
            lbResult.Items.Add(sb.ToString());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbResult.Items.Clear();
            lblRottery.Text = "0, 0, 0, 0, 0";
            lblResult.Text = "-";
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            Random rdNum = new Random();

            int iNumber = int.Parse(tbNumber.Text);

            int iCheckNumber = 0;
            int iCount = 0;

            if (iNumber < 1 || iNumber > 46)
            {
                MessageBox.Show("Input the right number");
                return;
            }

            do
            {
                iCheckNumber = rdNum.Next(1, 101);
                iCount++;
            } while (iNumber != iCheckNumber);

            lblResult.Text = string.Format("- The number you input is {0} : Count {1}", iNumber, iCount);
        }
    }
}
