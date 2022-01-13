using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
   
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_ID.Text) || string.IsNullOrEmpty(tb_Name.Text))
                return;
            string[] manProperty = { tb_Name.Text, tb_Surname.Text };
            ListViewItem item = new ListViewItem(tb_ID.Text);
            item.SubItems.AddRange(manProperty);
            listView1.Items.Add(item);
            tb_ID.Clear();
            tb_Name.Clear();
            tb_Surname.Clear();
            tb_ID.Focus();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void btn_UP_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Down_Click(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tb_ID.Text = listView1.SelectedItems[0].SubItems[1].Text;
            tb_Name.Text = listView1.FocusedItem.SubItems[1].Text;
            tb_Surname.Text = listView1.FocusedItem.SubItems[2].Text;
        }
    }
}
