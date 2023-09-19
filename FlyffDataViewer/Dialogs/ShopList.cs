using FlyffDataViewer.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FlyffDataViewer.Dialogs
{
    public partial class ShopList : Form
    {
        public ShopList()
        {
            InitializeComponent();

        }

        public void RefreshTextBox()
        {
            textBox_shoplist.Text = string.Join(Environment.NewLine, ContentManager.ShopList);
        }



        private void textBox_shoplist_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
