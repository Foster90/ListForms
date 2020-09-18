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

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void MoveAll_OnClick1(object sender, EventArgs e)
        {

            foreach (var item in listBox2.Items)
            {
               listBox1.Items.Add(item);
            }

            listBox2.Items.Clear();

        }


        void MoveAll2_OnClick1(object sender, EventArgs e)
        {
            foreach (var item in listBox1.Items)
            {
                listBox2.Items.Add(item);
            }

            listBox1.Items.Clear();
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
        }









    }
}
