using FlyffDataViewer.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyffDataViewer.Dialogs
{
    public partial class AddToShopList : Form
    {
        public string Itemname;
        public AddToShopList()
        {
            InitializeComponent();
            comboBox_Slot.SelectedIndex = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var line = "AddShopItem( " + comboBox_Slot.SelectedItem.ToString() + ", " + textBox_ItemName.Text + ", " + textBox_Price.Text + ")";
            ContentManager.ShopList.Add(line);
            DialogResult = DialogResult.OK;
        }

        private void AddToShopList_Load(object sender, EventArgs e)
        {
            if (Itemname.Length > 0)
            {
                textBox_ItemName.Text = Itemname;
            }
        }
    }
}
