using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _001_SetString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string str = lblText.Text;

            lblContain.Text = str.Contains("Test").ToString();
            lblEqual.Text = str.Equals("Test").ToString();
            lblLength.Text = str.Length.ToString();
            lblReplace.Text = str.Replace("Test", "I can");

            string[] strSplit = str.Split(',');
            lblSplit1.Text = strSplit[0];
            lblSplit2.Text = strSplit[1];
            lblSplit3.Text = strSplit[2];

            lblSubString.Text = str.Substring(3, 7);
            lblToLower.Text = str.ToLower();
            lblToUpper.Text = str.ToUpper();
            lblTrim.Text = str.Trim();
        }
    }
}
