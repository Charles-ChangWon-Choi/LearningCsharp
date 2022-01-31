 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _007_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOneWeek_Click(object sender, EventArgs e)
        {
            dgvDay.Rows.Clear();

            int[] iTest = { 10, 5, 30, 4, 15, 22, 18 };

            //dgvDay.Rows.Add();
            for(int idx=0; idx < iTest.Length; idx++)
            {
                dgvDay[idx, 0].Value = iTest[idx];            
            }
        }

        private void btnTwoWeek_Click(object sender, EventArgs e)
        {
            dgvDay.Rows.Clear();

            int[,] iTest = { { 10, 5, 30, 4, 15, 22, 18 }, { 11, 15, 25, 14, 7, 5, 25 } };

            dgvDay.Rows.Add();

            for(int idxR = 0; idxR < 2; idxR++)
            {
                for (int idxC = 0; idxC < 7; idxC++)
                    dgvDay[idxC, idxR].Value = iTest[idxR, idxC];
            }

        }
    }
}
