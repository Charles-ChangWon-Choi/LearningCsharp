using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _009_IterationStatement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            tbResult.Text = String.Empty;

            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    sb.Append(string.Format("Running a EP{0} of Season{1}\r\n", i, j));
                }
            }
            tbResult.Text = sb.ToString();
        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            tbResult.Text = string.Empty;
            StringBuilder sb = new StringBuilder();

            string[] strText = { "Alpha", "Bravo", "Charlie", "Delta", "Elephant", "Falcon" };

            int i = 0;

            foreach (string str in strText)
            {
                sb.Append(string.Format("[{0}] Allert {1} occurred...\r\n", i, str));
                i++;
            }
            tbResult.Text = sb.ToString();
        }
    }
}
