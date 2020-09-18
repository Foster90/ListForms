using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {

                MoveItem2.Enabled = false;
                MoveAll2.Enabled = false;
            }
            else
            {
                MoveItem2.Enabled = true;
                MoveAll2.Enabled = true;
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.Items.Count == 0)
            {

                MoveItem.Enabled = false;
                MoveAll.Enabled = false;
            }
            else
            {
                MoveItem.Enabled = true;
                MoveAll.Enabled = true;
            }

        }

        void MoveAll_OnClick1(object sender, EventArgs e)
        {

            foreach (var item in listBox2.Items)
            {
               listBox1.Items.Add(item);
            }

            listBox2.Items.Clear();
            listBox1_SelectedIndexChanged(sender, e);
            listBox2_SelectedIndexChanged(sender, e);

        }


        void MoveAll2_OnClick1(object sender, EventArgs e)
        {
            foreach (var item in listBox1.Items)
            {
                listBox2.Items.Add(item);
            }

            listBox1.Items.Clear();
            listBox1_SelectedIndexChanged(sender, e);
            listBox2_SelectedIndexChanged(sender, e);

        }


        void Moveitem_OnClick1(object sender, EventArgs e)
        {

            ListBox.SelectedObjectCollection stem = listBox2.SelectedItems;
            foreach (var item in stem)

            {
                listBox1.Items.Add(item);
                
            }
            while (listBox2.SelectedItems.Count > 0)
            {
                listBox2.Items.Remove(listBox2.SelectedItems[0]);
            }

            listBox1_SelectedIndexChanged(sender, e);
            listBox2_SelectedIndexChanged(sender, e);
        }


        void Moveitem2_OnClick1(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection stem = listBox1.SelectedItems;
            foreach (var item in stem)

            {
                listBox2.Items.Add(item);

            }
            while (listBox1.SelectedItems.Count > 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }
            listBox1_SelectedIndexChanged(sender, e);
            listBox2_SelectedIndexChanged(sender, e);

        }









    }
}
