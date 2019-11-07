using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Menu
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void listViewOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMenu.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewMenu.SelectedItems[0];
                labelName.Text = item.Text;
                textBoxName.Text = item.Text;
                textBoxPrice.Text = item.SubItems[1].Text;
                numericUpDownNumber.Value = 1;
                buttonImage.ImageIndex = listViewMenu.SelectedItems[0].Index;
                subTotal();
            }
        }

        public void subTotal()
        {
            textBoxSubTotal.Text = "" + (int.Parse(textBoxPrice.Text) * numericUpDownNumber.Value);
        }

        private void numericUpDownNumber_ValueChanged(object sender, EventArgs e)
        {
            subTotal();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = textBoxName.Text;
            addSubItem(item, textBoxPrice.Text);
            addSubItem(item, numericUpDownNumber.Value+"");
            addSubItem(item, textBoxSubTotal.Text);
            listViewReceipts.Items.Add(item);
            textBoxTotal.Text = ""+total();
        }

        public void addSubItem(ListViewItem item, String text)
        {
            ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem();
            subItem.Text = text;
            item.SubItems.Add(subItem);
        }

        public int total()
        {
            int total = 0;
            foreach (ListViewItem item in listViewReceipts.Items)
            {
                int subtotal = int.Parse(item.SubItems[3].Text);
                total += subtotal;
            }
            return total;
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
