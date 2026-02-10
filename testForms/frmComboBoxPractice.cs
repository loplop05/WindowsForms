using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testForms.Properties;

namespace testForms
{
    public partial class frmComboBoxPractice : Form
    {
        public frmComboBoxPractice()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

          if(comboBox1.SelectedIndex == 0)
            {
                pictureBox1.Image = Resources.Boy;
                label1.Text = "BOY";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                pictureBox1.Image = Resources.finn1;
                label1.Text = "fin1";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                pictureBox1.Image = Resources.finn2;
                label1.Text = "fin2";
            }

        }

      
    }
}
