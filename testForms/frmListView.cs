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
    public partial class frmListView : Form
    {
        public frmListView()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Clear();   // important
            listView1.Columns.Add("ID", 120);
            listView1.Columns.Add("Name", 200);
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtBoxID.Text)|| string.IsNullOrEmpty(txtBoxName.Text))
            {
                return;
            }

            ListViewItem item = new ListViewItem(txtBoxID.Text.Trim());
            if(rbMale.Checked)
            {
                item.ImageIndex = 1;
                
            }
            else
            {
                item.ImageIndex = 0;
            }

            item.SubItems.Add(txtBoxName.Text.Trim());
            listView1.Items.Add(item);

            txtBoxID.Clear();
            txtBoxName.Clear();
           
            txtBoxID.Focus();



        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbDetails_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void rbLargeIcons_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void rbSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void rbList_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void rbTitle_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void btnFillRandom_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <= 10; i++)
            {
                ListViewItem item = new ListViewItem(i.ToString());
                if (i % 2 == 0)
                {
                    item.ImageIndex = 0;
                }
                else
                    item.ImageIndex = 0;


                item.SubItems.Add("Person " + i);
                listView1.Items.Add(item);
            }
        }
    }
}
