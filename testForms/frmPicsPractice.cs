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
    public partial class frmPicsPractice : Form
    {
        public frmPicsPractice()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pbPicture.Image = Image.FromFile(@"D:/picsPrac/Boy.png");
            lblTitle.Text = "Boy";
        }

        private void rbGirl_CheckedChanged(object sender, EventArgs e)
        {
            pbPicture.Image = Image.FromFile(@"D:/picsPrac/Girl.png");
            lblTitle.Text = "Girl";
        }

        private void rbBook_CheckedChanged(object sender, EventArgs e)
        {
            pbPicture.Image = Image.FromFile(@"D:/picsPrac/Book.png");
            lblTitle.Text = "Book";
        }

        private void rbPen_CheckedChanged(object sender, EventArgs e)
        {
            pbPicture.Image = Image.FromFile(@"D:/picsPrac/Pen.png");
            lblTitle.Text = "Pen";
        }
    }
}
