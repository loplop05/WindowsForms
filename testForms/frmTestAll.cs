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
    public partial class frmTestAll : Form
    {
        public frmTestAll()
        {
            InitializeComponent();
        
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Clear();   // important
            listView1.Columns.Add("ID", 100);
            listView1.Columns.Add("Name", 100);
            listView1.Columns.Add("Position", 100);
            listView1.Columns.Add("Salary", 100);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
