using FlyffDataViewer.Classes;
using FlyffDataViewer.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyffDataViewer.Usercontrols
{
    public partial class MoversView : UserControl
    {
        List<string> MoverClasses = new List<string>();
        public MoversView()
        {
            InitializeComponent();

        }

        private void MoversView_Load(object sender, EventArgs e)
        {
            foreach (var item in ContentManager.Movers)
            {
                MoverClasses.Add(item.dwClass);
            }
            MoverClasses = MoverClasses.Distinct().ToList();
            comboBox_MoverClass.DataSource = MoverClasses;
            listBox_Movers.DataSource = ContentManager.Movers;
        }

        private void listBox_Movers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = (PropMoverDTO)listBox_Movers.SelectedItem;
            Console.WriteLine(selectedItem.dwID);
            textBox_ID.Text = selectedItem.ID;
            textBox_szComment.Text = selectedItem.description;
            textBox_Name.Text = selectedItem.dwID;
            textBox_IngameName.Text = selectedItem.ingameName;
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            List<PropMoverDTO> filteredItems = new List<PropMoverDTO>();
            if (textBox_search.Text.Length > 0)
            {
                foreach (var item in ContentManager.Movers)
                {
                    if (item.dwID is not null && item.ID is not null && item.ingameName is not null)
                    {
                        if (item.ingameName.Contains(textBox_search.Text, StringComparison.OrdinalIgnoreCase) ||
                            item.dwID.Contains(textBox_search.Text, StringComparison.OrdinalIgnoreCase) ||
                            item.ID.Contains(textBox_search.Text, StringComparison.OrdinalIgnoreCase))
                        {
                            filteredItems.Add(item);
                        }
                    }
                }
                listBox_Movers.DataSource = filteredItems;
            }
            else
            {
                listBox_Movers.DataSource = ContentManager.Items;
            }
        }

        private void comboBox_MoverClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filteredItems = ContentManager.Movers.Where(x => x.dwClass == comboBox_MoverClass.SelectedItem.ToString()).ToList();
            listBox_Movers.DataSource = filteredItems;
            textBox_search.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox_Movers.SelectedItem is not null)
            {
                PropMoverDTO selectedItem = (PropMoverDTO)listBox_Movers.SelectedItem;
                Clipboard.SetText("/cn " + selectedItem.ID + " 1 0");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox_Movers.DataSource = ContentManager.Movers;
        }

        private void button_MonsterFilter_Click(object sender, EventArgs e)
        {
            var filteredItems = ContentManager.Movers.Where(x => x.dwAI == "AII_MONSTER").ToList();
            listBox_Movers.DataSource = filteredItems;
            textBox_search.Text = "";
        }

        private void button_PetFilter_Click(object sender, EventArgs e)
        {
            var filteredItems = ContentManager.Movers.Where(x => x.dwAI == "AII_PET").ToList();
            listBox_Movers.DataSource = filteredItems;
            textBox_search.Text = "";
        }
    }
}
