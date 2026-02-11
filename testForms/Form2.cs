using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnShowPart1_Click(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            frm1.Show();
        }

        private void btnShowAsDialog_Click(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void btnMessageBoxForm_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmMessageBoxForm();
            frm1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm1 = new chkRadioGrp();
            frm1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmTextBox();
            frm1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmTextBox();
            frm1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmPicsPractice();
            frm1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frm1 = new Form3();
            frm1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmComboBox();
            frm1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmComboBoxPractice();
            frm1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmLinkLabel();
            frm1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmCheckedListBox();
            frm1.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmDateTimePicker();
            frm1.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmMonthCalender();
            frm1.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmTimer();
            frm1.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmNotifyIcon();
            frm1.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmImageList();
            frm1.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmProgressBar();
            frm1.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmListView();
            frm1.Show();
        }
    }
}
