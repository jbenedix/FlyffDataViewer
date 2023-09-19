﻿using FlyffDataViewer.Classes;
using FlyffDataViewer.Dialogs;
using FlyffDataViewer.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyffDataViewer.Usercontrols
{
    public partial class ItemsView : UserControl
    {
        ShopList shopList;
        bool loadSpecItem;

        public ItemsView()
        {
            InitializeComponent();
            shopList = new ShopList();

        }

        private void ItemsView_Load(object sender, EventArgs e)
        {
            listBox_Items.DataSource = ContentManager.Items;
        }

        private void listBox_Items_SelectedIndexChanged(object sender, EventArgs e)
        {
            PropItemDTO selectedItem = (PropItemDTO)listBox_Items.SelectedItem;
            textBox_ID.Text = selectedItem.ID;
            textBox_IngameName.Text = selectedItem.ingameName;
            textBox_MaxStack.Text = selectedItem.dwPackMax.ToString();
            textBox_Name.Text = selectedItem.dwID;
            textBox_dwCost.Text = selectedItem.dwCost;
            textBox_szComment.Text = selectedItem.szComment;
            textBox_dwCircleTime.Text = selectedItem.dwCircleTime;
            textBox_dwHanded.Text = selectedItem.dwHanded;
            textBox_dwItemLV.Text = selectedItem.dwItemLV;
            textBox_dwItemRare.Text = selectedItem.dwItemRare;
            textBox_dwItemJob.Text = selectedItem.dwItemJob;
            textBox_dwItemKind3.Text = selectedItem.dwItemKind3;
            textBox_dwItemKind2.Text = selectedItem.dwItemKind2;
            textBox_dwItemKind1.Text = selectedItem.dwItemKind1;
            textBox_dwAbilityMin.Text = selectedItem.dwAbilityMin;
            textBox_dwAbilityMax.Text = selectedItem.dwAbilityMax;
            textBox_dwWeaponType.Text = selectedItem.dwWeaponType;
            textBox_dwAttackRange.Text = selectedItem.dwAttackRange;
            textBox_dwAttackSpeed.Text = selectedItem.dwAttackSpeed;

            if (selectedItem.dwItemKind1 == "IK1_WEAPON")
            {
                //Find Spec Item for ID
                var specItem = ContentManager.SpecItems.SingleOrDefault(x => x.dwID == selectedItem.dwID);
                if (specItem != null)
                {
                    textBox_dwDestParam1.Text = specItem.dwDestParam1;
                    textBox_dwDestParam2.Text = specItem.dwDestParam2;
                    textBox_dwDestParam3.Text = specItem.dwDestParam3;
                    textBox_dwDestParam4.Text = specItem.dwDestParam4;
                    textBox_dwDestParam5.Text = specItem.dwDestParam5;
                    textBox_dwDestParam6.Text = specItem.dwDestParam6;

                    textBox_nAdjParamVal1.Text = specItem.nAdjParamVal1;
                    textBox_nAdjParamVal2.Text = specItem.nAdjParamVal2;
                    textBox_nAdjParamVal3.Text = specItem.nAdjParamVal3;
                    textBox_nAdjParamVal4.Text = specItem.nAdjParamVal4;
                    textBox_nAdjParamVal5.Text = specItem.nAdjParamVal5;
                    textBox_nAdjParamVal6.Text = specItem.nAdjParamVal6;
                }


            }



        }

        private void waffenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var filteredItems = ContentManager.Items.Where(x => x.dwItemKind1 == "IK1_WEAPON").ToList();
            listBox_Items.DataSource = filteredItems;
            textBox_search.Text = "";
        }

        private void rüstungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var filteredItems = ContentManager.Items.Where(x => x.dwItemKind1 == "IK1_ARMOR").ToList();
            listBox_Items.DataSource = filteredItems;
            textBox_search.Text = "";
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            List<PropItemDTO> filteredItems = new List<PropItemDTO>();
            if (textBox_search.Text.Length > 0)
            {
                filteredItems = ContentManager.Items.Where(x => x.ingameName.Contains(textBox_search.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                listBox_Items.DataSource = filteredItems;
            }
            else
            {
                listBox_Items.DataSource = ContentManager.Items;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (listBox_Items.SelectedItem is not null)
            {
                PropItemDTO selectedItem = (PropItemDTO)listBox_Items.SelectedItem;
                Clipboard.SetText("/CreateItem " + selectedItem.ID + " 1");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("notepad", SettingsManager.resourcePath + @"\propItem.txt");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ContentManager.OpenCSVWithExcel(SettingsManager.resourcePath + @"\propItem.txt");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Process.Start("notepad", SettingsManager.resourcePath + @"\propItem.txt");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (listBox_Items.SelectedItem is not null)
            {
                PropItemDTO selectedItem = (PropItemDTO)listBox_Items.SelectedItem;
                Clipboard.SetText("/CreateItem " + selectedItem.ID + " 1");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddToShopList addToShopList = new AddToShopList();

            PropItemDTO selectedItem = (PropItemDTO)listBox_Items.SelectedItem;
            addToShopList.Itemname = selectedItem.dwID;

            shopList.Show();
            shopList.Visible = true;

            if (addToShopList.ShowDialog() == DialogResult.OK)
            {
                // Sie abonnieren das DataChanged-Ereignis
                shopList.RefreshTextBox();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            shopList.Show();
            shopList.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", SettingsManager.resourcePath + @"\propItem.txt");
            PropItemDTO selectedItem = (PropItemDTO)listBox_Items.SelectedItem;
            // Add a delay to allow Notepad to open the file
            System.Threading.Thread.Sleep(1000);

            // Send keys to Notepad to navigate to the desired line
            SendKeys.SendWait("^{g}"); // Ctrl+G to open "Go to Line" dialog
            System.Threading.Thread.Sleep(1000);
            SendKeys.SendWait(ContentManager.Items.IndexOf(selectedItem).ToString());
            System.Threading.Thread.Sleep(1000);
            //SendKeys.SendWait("{ENTER}");
            //System.Threading.Thread.Sleep(1000);
            //SendKeys.SendWait("+(END)");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox_search.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}