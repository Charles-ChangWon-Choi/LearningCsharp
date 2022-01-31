using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _005_Enumerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private string strName = "";

        private enum enumDay
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        private enum enumTime
        {
            Morning,
            Afternoon,
            Evening
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbDay.Items.Add(enumDay.Monday);
            lbDay.Items.Add(enumDay.Tuesday);
            lbDay.Items.Add(enumDay.Wednesday);
            lbDay.Items.Add(enumDay.Thursday);
            lbDay.Items.Add(enumDay.Friday);
            lbDay.Items.Add(enumDay.Saturday);
            lbDay.Items.Add(enumDay.Sunday);

            lbTime.Items.Add(enumTime.Morning);
            lbTime.Items.Add(enumTime.Afternoon);
            lbTime.Items.Add(enumTime.Evening);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            try
            {
                string strResult = tbName.Text + "와 " + lbDay.SelectedItem.ToString() + "(요일) " + lbTime.SelectedItem.ToString() + "에 보기로 했습니다.";
                tbResult.Text = strResult;
            }
            catch
            {
                MessageBox.Show("정보가 빠졌습니다.", "다시요");
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                string strResult = String.Format("{0}와 {1}요일 {2}에 보기로 했다구!!!", tbName.Text, lbDay.SelectedItem.ToString(), lbTime.SelectedItem.ToString());
                tbResult.Text = strResult;
            }
            catch
            {
                MessageBox.Show("정보가 빠졌다니까!!!", "오키?");
            }
        }
    }
}
