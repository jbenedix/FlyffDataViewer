namespace FlyffDataViewer.Usercontrols
{
    partial class ItemsView
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            listBox_Items = new ListBox();
            label2 = new Label();
            textBox_ID = new TextBox();
            textBox_Name = new TextBox();
            label3 = new Label();
            textBox_IngameName = new TextBox();
            label4 = new Label();
            textBox_szComment = new TextBox();
            label5 = new Label();
            textBox_MaxStack = new TextBox();
            label6 = new Label();
            panel1 = new Panel();
            comboBox_MoverClass = new ComboBox();
            label35 = new Label();
            label34 = new Label();
            button_CardFilter = new Button();
            button_FoodFilter = new Button();
            button_ScrollFilter = new Button();
            button_ArmorFilter = new Button();
            button_weaponFilter = new Button();
            textBox_search = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            textBox_dwItemKind3 = new TextBox();
            label7 = new Label();
            textBox_dwItemKind2 = new TextBox();
            label8 = new Label();
            textBox_dwItemKind1 = new TextBox();
            label9 = new Label();
            textBox_dwCost = new TextBox();
            label10 = new Label();
            textBox_dwAttackRange = new TextBox();
            label11 = new Label();
            textBox_dwWeaponType = new TextBox();
            label12 = new Label();
            textBox_dwAbilityMin = new TextBox();
            label13 = new Label();
            textBox_dwHanded = new TextBox();
            label14 = new Label();
            textBox_dwItemJob = new TextBox();
            label16 = new Label();
            textBox_dwItemRare = new TextBox();
            label17 = new Label();
            textBox_dwCircleTime = new TextBox();
            label18 = new Label();
            textBox_dwItemLV = new TextBox();
            label19 = new Label();
            textBox_dwAbilityMax = new TextBox();
            label15 = new Label();
            textBox_dwAttackSpeed = new TextBox();
            label20 = new Label();
            button7 = new Button();
            textBox_nAdjParamVal6 = new TextBox();
            label27 = new Label();
            textBox_nAdjParamVal5 = new TextBox();
            label28 = new Label();
            textBox_nAdjParamVal4 = new TextBox();
            textBox_nAdjParamVal1 = new TextBox();
            label29 = new Label();
            label30 = new Label();
            textBox_nAdjParamVal3 = new TextBox();
            label31 = new Label();
            label32 = new Label();
            textBox_nAdjParamVal2 = new TextBox();
            textBox_dwDestParam6 = new TextBox();
            label25 = new Label();
            textBox_dwDestParam5 = new TextBox();
            label26 = new Label();
            textBox_dwDestParam4 = new TextBox();
            textBox_dwDestParam1 = new TextBox();
            label21 = new Label();
            label24 = new Label();
            textBox_dwDestParam3 = new TextBox();
            label23 = new Label();
            label22 = new Label();
            textBox_dwDestParam2 = new TextBox();
            label33 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 0;
            label1.Text = "Items";
            // 
            // listBox_Items
            // 
            listBox_Items.BackColor = Color.FromArgb(64, 64, 64);
            listBox_Items.BorderStyle = BorderStyle.FixedSingle;
            listBox_Items.DisplayMember = "ingameName";
            listBox_Items.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBox_Items.ForeColor = Color.White;
            listBox_Items.FormattingEnabled = true;
            listBox_Items.ItemHeight = 14;
            listBox_Items.Location = new Point(0, 74);
            listBox_Items.Name = "listBox_Items";
            listBox_Items.Size = new Size(242, 548);
            listBox_Items.TabIndex = 1;
            listBox_Items.SelectedIndexChanged += listBox_Items_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(321, 85);
            label2.Name = "label2";
            label2.Size = new Size(20, 16);
            label2.TabIndex = 2;
            label2.Text = "ID";
            // 
            // textBox_ID
            // 
            textBox_ID.BackColor = SystemColors.ControlDarkDark;
            textBox_ID.BorderStyle = BorderStyle.FixedSingle;
            textBox_ID.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_ID.ForeColor = Color.White;
            textBox_ID.Location = new Point(347, 83);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(87, 21);
            textBox_ID.TabIndex = 3;
            // 
            // textBox_Name
            // 
            textBox_Name.BackColor = SystemColors.ControlDarkDark;
            textBox_Name.BorderStyle = BorderStyle.FixedSingle;
            textBox_Name.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Name.ForeColor = Color.White;
            textBox_Name.Location = new Point(347, 116);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(193, 21);
            textBox_Name.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(297, 116);
            label3.Name = "label3";
            label3.Size = new Size(44, 16);
            label3.TabIndex = 4;
            label3.Text = "Name";
            // 
            // textBox_IngameName
            // 
            textBox_IngameName.BackColor = SystemColors.ControlDarkDark;
            textBox_IngameName.BorderStyle = BorderStyle.FixedSingle;
            textBox_IngameName.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_IngameName.ForeColor = Color.White;
            textBox_IngameName.Location = new Point(347, 140);
            textBox_IngameName.Name = "textBox_IngameName";
            textBox_IngameName.Size = new Size(193, 21);
            textBox_IngameName.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(249, 140);
            label4.Name = "label4";
            label4.Size = new Size(92, 16);
            label4.TabIndex = 6;
            label4.Text = "Ingame Name";
            // 
            // textBox_szComment
            // 
            textBox_szComment.BackColor = SystemColors.ControlDarkDark;
            textBox_szComment.BorderStyle = BorderStyle.FixedSingle;
            textBox_szComment.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_szComment.ForeColor = Color.White;
            textBox_szComment.Location = new Point(347, 164);
            textBox_szComment.Name = "textBox_szComment";
            textBox_szComment.Size = new Size(193, 21);
            textBox_szComment.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(266, 164);
            label5.Name = "label5";
            label5.Size = new Size(75, 16);
            label5.TabIndex = 8;
            label5.Text = "Description";
            // 
            // textBox_MaxStack
            // 
            textBox_MaxStack.BackColor = SystemColors.ControlDarkDark;
            textBox_MaxStack.BorderStyle = BorderStyle.FixedSingle;
            textBox_MaxStack.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_MaxStack.ForeColor = Color.White;
            textBox_MaxStack.Location = new Point(347, 188);
            textBox_MaxStack.Name = "textBox_MaxStack";
            textBox_MaxStack.Size = new Size(87, 21);
            textBox_MaxStack.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(272, 193);
            label6.Name = "label6";
            label6.Size = new Size(69, 16);
            label6.TabIndex = 10;
            label6.Text = "Max Stack";
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox_MoverClass);
            panel1.Controls.Add(label35);
            panel1.Controls.Add(label34);
            panel1.Controls.Add(button_CardFilter);
            panel1.Controls.Add(button_FoodFilter);
            panel1.Controls.Add(button_ScrollFilter);
            panel1.Controls.Add(button_ArmorFilter);
            panel1.Controls.Add(button_weaponFilter);
            panel1.Location = new Point(242, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(898, 31);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // comboBox_MoverClass
            // 
            comboBox_MoverClass.BackColor = SystemColors.ControlDarkDark;
            comboBox_MoverClass.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_MoverClass.FlatStyle = FlatStyle.Popup;
            comboBox_MoverClass.ForeColor = Color.White;
            comboBox_MoverClass.FormattingEnabled = true;
            comboBox_MoverClass.Items.AddRange(new object[] { "0", "1", "2", "3" });
            comboBox_MoverClass.Location = new Point(680, 4);
            comboBox_MoverClass.Name = "comboBox_MoverClass";
            comboBox_MoverClass.Size = new Size(205, 23);
            comboBox_MoverClass.TabIndex = 109;
            comboBox_MoverClass.SelectedIndexChanged += comboBox_MoverClass_SelectedIndexChanged;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(635, 7);
            label35.Name = "label35";
            label35.Size = new Size(39, 15);
            label35.TabIndex = 108;
            label35.Text = "Klasse";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label34.Location = new Point(7, 5);
            label34.Name = "label34";
            label34.Size = new Size(46, 18);
            label34.TabIndex = 101;
            label34.Text = "Filter";
            // 
            // button_CardFilter
            // 
            button_CardFilter.BackColor = Color.DimGray;
            button_CardFilter.FlatStyle = FlatStyle.Popup;
            button_CardFilter.Location = new Point(404, 3);
            button_CardFilter.Name = "button_CardFilter";
            button_CardFilter.Size = new Size(80, 24);
            button_CardFilter.TabIndex = 105;
            button_CardFilter.Text = "Upgrading";
            button_CardFilter.UseVisualStyleBackColor = false;
            button_CardFilter.Click += button_CardFilter_Click;
            // 
            // button_FoodFilter
            // 
            button_FoodFilter.BackColor = Color.DimGray;
            button_FoodFilter.FlatStyle = FlatStyle.Popup;
            button_FoodFilter.Location = new Point(332, 3);
            button_FoodFilter.Name = "button_FoodFilter";
            button_FoodFilter.Size = new Size(66, 24);
            button_FoodFilter.TabIndex = 104;
            button_FoodFilter.Text = "Food";
            button_FoodFilter.UseVisualStyleBackColor = false;
            button_FoodFilter.Click += button_FoodFilter_Click;
            // 
            // button_ScrollFilter
            // 
            button_ScrollFilter.BackColor = Color.DimGray;
            button_ScrollFilter.FlatStyle = FlatStyle.Popup;
            button_ScrollFilter.Location = new Point(255, 3);
            button_ScrollFilter.Name = "button_ScrollFilter";
            button_ScrollFilter.Size = new Size(71, 24);
            button_ScrollFilter.TabIndex = 103;
            button_ScrollFilter.Text = "Scrolls";
            button_ScrollFilter.UseVisualStyleBackColor = false;
            button_ScrollFilter.Click += button_ScrollFilter_Click;
            // 
            // button_ArmorFilter
            // 
            button_ArmorFilter.BackColor = Color.DimGray;
            button_ArmorFilter.FlatStyle = FlatStyle.Popup;
            button_ArmorFilter.Location = new Point(165, 3);
            button_ArmorFilter.Name = "button_ArmorFilter";
            button_ArmorFilter.Size = new Size(84, 24);
            button_ArmorFilter.TabIndex = 102;
            button_ArmorFilter.Text = "Armor";
            button_ArmorFilter.UseVisualStyleBackColor = false;
            button_ArmorFilter.Click += button_ArmorFilter_Click;
            // 
            // button_weaponFilter
            // 
            button_weaponFilter.BackColor = Color.DimGray;
            button_weaponFilter.FlatStyle = FlatStyle.Popup;
            button_weaponFilter.Location = new Point(66, 3);
            button_weaponFilter.Name = "button_weaponFilter";
            button_weaponFilter.Size = new Size(93, 24);
            button_weaponFilter.TabIndex = 101;
            button_weaponFilter.Text = "Weapons";
            button_weaponFilter.UseVisualStyleBackColor = false;
            button_weaponFilter.Click += button8_Click;
            // 
            // textBox_search
            // 
            textBox_search.BackColor = SystemColors.ControlDarkDark;
            textBox_search.BorderStyle = BorderStyle.FixedSingle;
            textBox_search.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_search.ForeColor = Color.White;
            textBox_search.Location = new Point(3, 46);
            textBox_search.Name = "textBox_search";
            textBox_search.PlaceholderText = "Search Item";
            textBox_search.Size = new Size(178, 21);
            textBox_search.TabIndex = 13;
            textBox_search.TextChanged += textBox_search_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(275, 592);
            button1.Name = "button1";
            button1.Size = new Size(128, 30);
            button1.TabIndex = 14;
            button1.Text = "Copy Create Item CMD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(423, 592);
            button2.Name = "button2";
            button2.Size = new Size(128, 30);
            button2.TabIndex = 15;
            button2.Text = "Open propItem.txt";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.DimGray;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(573, 592);
            button3.Name = "button3";
            button3.Size = new Size(160, 30);
            button3.TabIndex = 16;
            button3.Text = "Open propItem.txt EXCEL";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.BackColor = Color.DimGray;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(1000, 592);
            button4.Name = "button4";
            button4.Size = new Size(128, 30);
            button4.TabIndex = 17;
            button4.Text = "Open Shoplist";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DimGray;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Location = new Point(866, 592);
            button5.Name = "button5";
            button5.Size = new Size(128, 30);
            button5.TabIndex = 18;
            button5.Text = "Add to Shoplist";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DimGray;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Location = new Point(1000, 80);
            button6.Name = "button6";
            button6.Size = new Size(128, 30);
            button6.TabIndex = 19;
            button6.Text = "Edit Entry in Notepad";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // textBox_dwItemKind3
            // 
            textBox_dwItemKind3.BackColor = SystemColors.ControlDarkDark;
            textBox_dwItemKind3.BorderStyle = BorderStyle.FixedSingle;
            textBox_dwItemKind3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_dwItemKind3.ForeColor = Color.White;
            textBox_dwItemKind3.Location = new Point(713, 164);
            textBox_dwItemKind3.Name = "textBox_dwItemKind3";
            textBox_dwItemKind3.Size = new Size(193, 21);
            textBox_dwItemKind3.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(630, 169);
            label7.Name = "label7";
            label7.Size = new Size(77, 16);
            label7.TabIndex = 24;
            label7.Text = "Item Type 3";
            // 
            // textBox_dwItemKind2
            // 
            textBox_dwItemKind2.BackColor = SystemColors.ControlDarkDark;
            textBox_dwItemKind2.BorderStyle = BorderStyle.FixedSingle;
            textBox_dwItemKind2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_dwItemKind2.ForeColor = Color.White;
            textBox_dwItemKind2.Location = new Point(713, 140);
            textBox_dwItemKind2.Name = "textBox_dwItemKind2";
            textBox_dwItemKind2.Size = new Size(193, 21);
            textBox_dwItemKind2.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(630, 140);
            label8.Name = "label8";
            label8.Size = new Size(77, 16);
            label8.TabIndex = 22;
            label8.Text = "Item Type 2";
            // 
            // textBox_dwItemKind1
            // 
            textBox_dwItemKind1.BackColor = SystemColors.ControlDarkDark;
            textBox_dwItemKind1.BorderStyle = BorderStyle.FixedSingle;
            textBox_dwItemKind1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_dwItemKind1.ForeColor = Color.White;
            textBox_dwItemKind1.Location = new Point(713, 116);
            textBox_dwItemKind1.Name = "textBox_dwItemKind1";
            textBox_dwItemKind1.Size = new Size(193, 21);
            textBox_dwItemKind1.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(630, 116);
            label9.Name = "label9";
            label9.Size = new Size(77, 16);
            label9.TabIndex = 20;
            label9.Text = "Item Type 1";
            // 
            // textBox_dwCost
            // 
            textBox_dwCost.BackColor = SystemColors.ControlDarkDark;
            textBox_dwCost.BorderStyle = BorderStyle.FixedSingle;
            textBox_dwCost.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_dwCost.ForeColor = Color.White;
            textBox_dwCost.Location = new Point(713, 188);
            textBox_dwCost.Name = "textBox_dwCost";
            textBox_dwCost.Size = new Size(193, 21);
            textBox_dwCost.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(666, 193);
            label10.Name = "label10";
            label10.Size = new Size(41, 16);
            label10.TabIndex = 26;
            label10.Text = "Costs";
            // 
            // textBox_dwAttackRange
            // 
            textBox_dwAttackRange.BackColor = SystemColors.ControlDarkDark;
            textBox_dwAttackRange.BorderStyle = BorderStyle.FixedSingle;
            textBox_dwAttackRange.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_dwAttackRange.ForeColor = Color.White;
            textBox_dwAttackRange.Location = new Point(713, 326);
            textBox_dwAttackRange.Name = "textBox_dwAttackRange";
            textBox_dwAttackRange.Size = new Size(87, 21);
            textBox_dwAttackRange.TabIndex = 45;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(619, 326);
            label11.Name = "label11";
            label11.Size = new Size(88, 16);
            label11.TabIndex = 44;
            label11.Text = "Attack Range";
            // 
            // textBox_dwWeaponType
            // 
            textBox_dwWeaponType.BackColor = SystemColors.ControlDarkDark;
            textBox_dwWeaponType.BorderStyle = BorderStyle.FixedSingle;
            textBox_dwWeaponType.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_dwWeaponType.ForeColor = Color.White;
            textBox_dwWeaponType.Location = new Point(713, 298);
            textBox_dwWeaponType.Name = "textBox_dwWeaponType";
            textBox_dwWeaponType.Size = new Size(193, 21);
            textBox_dwWeaponType.TabIndex = 43;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(613, 298);
            label12.Name = "label12";
            label12.Size = new Size(94, 16);
            label12.TabIndex = 42;
            label12.Text = "Weapon Type";
            // 
            // textBox_dwAbilityMin
            // 
            textBox_dwAbilityMin.BackColor = SystemColors.ControlDarkDark;
            textBox_dwAbilityMin.BorderStyle = BorderStyle.FixedSingle;
            textBox_dwAbilityMin.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_dwAbilityMin.ForeColor = Color.White;
            textBox_dwAbilityMin.Location = new Point(713, 274);
            textBox_dwAbilityMin.Name = "textBox_dwAbilityMin";
            textBox_dwAbilityMin.Size = new Size(87, 21);
            textBox_dwAbilityMin.TabIndex = 41;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(640, 274);
            label13.Name = "label13";
            label13.Size = new Size(67, 16);
            label13.TabIndex = 40;
            label13.Text = "Ability Min";
            // 
            // textBox_dwHanded
            // 
            textBox_dwHanded.BackColor = SystemColors.ControlDarkDark;
            textBox_dwHanded.BorderStyle = BorderStyle.FixedSingle;
            textBox_dwHanded.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_dwHanded.ForeColor = Color.White;
            textBox_dwHanded.Location = new Point(713, 250);
            textBox_dwHanded.Name = "textBox_dwHanded";
            textBox_dwHanded.Size = new Size(193, 21);
            textBox_dwHanded.TabIndex = 39;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(651, 250);
            label14.Name = "label14";
            label14.Size = new Size(56, 16);
            label14.TabIndex = 38;
            label14.Text = "Handed";
            // 
            // textBox_dwItemJob
            // 
            textBox_dwItemJob.BackColor = SystemColors.ControlDarkDark;
            textBox_dwItemJob.BorderStyle = BorderStyle.FixedSingle;
            textBox_dwItemJob.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_dwItemJob.ForeColor = Color.White;
            textBox_dwItemJob.Location = new Point(347, 250);
            textBox_dwItemJob.Name = "textBox_dwItemJob";
            textBox_dwItemJob.Size = new Size(193, 21);
            textBox_dwItemJob.TabIndex = 35;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(311, 252);
            label16.Name = "label16";
            label16.Size = new Size(30, 16);
            label16.TabIndex = 34;
            label16.Text = "Job";
            // 
            // textBox_dwItemRare
            // 
            textBox_dwItemRare.BackColor = SystemColors.ControlDarkDark;
            textBox_dwItemRare.BorderStyle = BorderStyle.FixedSingle;
            textBox_dwItemRare.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_dwItemRare.ForeColor = Color.White;
            textBox_dwItemRare.Location = new Point(347, 323);
            textBox_dwItemRare.Name = "textBox_dwItemRare";
            textBox_dwItemRare.Size = new Size(87, 21);
            textBox_dwItemRare.TabIndex = 33;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(299, 326);
            label17.Name = "label17";
            label17.Size = new Size(42, 16);
            label17.TabIndex = 32;
            label17.Text = "Rarity";
            // 
            // textBox_dwCircleTime
            // 
            textBox_dwCircleTime.BackColor = SystemColors.ControlDarkDark;
            textBox_dwCircleTime.BorderStyle = BorderStyle.FixedSingle;
            textBox_dwCircleTime.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_dwCircleTime.ForeColor = Color.White;
            textBox_dwCircleTime.Location = new Point(347, 299);
            textBox_dwCircleTime.Name = "textBox_dwCircleTime";
            textBox_dwCircleTime.Size = new Size(193, 21);
            textBox_dwCircleTime.TabIndex = 31;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(284, 299);
            label18.Name = "label18";
            label18.Size = new Size(57, 16);
            label18.TabIndex = 30;
            label18.Text = "Duration";
            // 
            // textBox_dwItemLV
            // 
            textBox_dwItemLV.BackColor = SystemColors.ControlDarkDark;
            textBox_dwItemLV.BorderStyle = BorderStyle.FixedSingle;
            textBox_dwItemLV.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_dwItemLV.ForeColor = Color.White;
            textBox_dwItemLV.Location = new Point(347, 275);
            textBox_dwItemLV.Name = "textBox_dwItemLV";
            textBox_dwItemLV.Size = new Size(87, 21);
            textBox_dwItemLV.TabIndex = 29;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(301, 275);
            label19.Name = "label19";
            label19.Size = new Size(40, 16);
            label19.TabIndex = 28;
            label19.Text = "Level";
            // 
            // textBox_dwAbilityMax
            // 
            textBox_dwAbilityMax.BackColor = SystemColors.ControlDarkDark;
            textBox_dwAbilityMax.BorderStyle = BorderStyle.FixedSingle;
            textBox_dwAbilityMax.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_dwAbilityMax.ForeColor = Color.White;
            textBox_dwAbilityMax.Location = new Point(910, 276);
            textBox_dwAbilityMax.Name = "textBox_dwAbilityMax";
            textBox_dwAbilityMax.Size = new Size(87, 21);
            textBox_dwAbilityMax.TabIndex = 47;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(827, 274);
            label15.Name = "label15";
            label15.Size = new Size(71, 16);
            label15.TabIndex = 46;
            label15.Text = "Ability Max";
            // 
            // textBox_dwAttackSpeed
            // 
            textBox_dwAttackSpeed.BackColor = SystemColors.ControlDarkDark;
            textBox_dwAttackSpeed.BorderStyle = BorderStyle.FixedSingle;
            textBox_dwAttackSpeed.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_dwAttackSpeed.ForeColor = Color.White;
            textBox_dwAttackSpeed.Location = new Point(713, 353);
            textBox_dwAttackSpeed.Name = "textBox_dwAttackSpeed";
            textBox_dwAttackSpeed.Size = new Size(87, 21);
            textBox_dwAttackSpeed.TabIndex = 49;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(619, 353);
            label20.Name = "label20";
            label20.Size = new Size(88, 16);
            label20.TabIndex = 48;
            label20.Text = "Attack Speed";
            // 
            // button7
            // 
            button7.BackColor = Color.DimGray;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Location = new Point(187, 47);
            button7.Name = "button7";
            button7.Size = new Size(49, 21);
            button7.TabIndex = 50;
            button7.Text = "Reset";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // textBox_nAdjParamVal6
            // 
            textBox_nAdjParamVal6.BackColor = SystemColors.ControlDarkDark;
            textBox_nAdjParamVal6.BorderStyle = BorderStyle.FixedSingle;
            textBox_nAdjParamVal6.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_nAdjParamVal6.ForeColor = Color.White;
            textBox_nAdjParamVal6.Location = new Point(713, 524);
            textBox_nAdjParamVal6.Name = "textBox_nAdjParamVal6";
            textBox_nAdjParamVal6.Size = new Size(75, 21);
            textBox_nAdjParamVal6.TabIndex = 99;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label27.Location = new Point(655, 524);
            label27.Name = "label27";
            label27.Size = new Size(52, 16);
            label27.TabIndex = 98;
            label27.Text = "Value 6";
            // 
            // textBox_nAdjParamVal5
            // 
            textBox_nAdjParamVal5.BackColor = SystemColors.ControlDarkDark;
            textBox_nAdjParamVal5.BorderStyle = BorderStyle.FixedSingle;
            textBox_nAdjParamVal5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_nAdjParamVal5.ForeColor = Color.White;
            textBox_nAdjParamVal5.Location = new Point(713, 500);
            textBox_nAdjParamVal5.Name = "textBox_nAdjParamVal5";
            textBox_nAdjParamVal5.Size = new Size(75, 21);
            textBox_nAdjParamVal5.TabIndex = 97;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label28.Location = new Point(655, 500);
            label28.Name = "label28";
            label28.Size = new Size(52, 16);
            label28.TabIndex = 96;
            label28.Text = "Value 5";
            // 
            // textBox_nAdjParamVal4
            // 
            textBox_nAdjParamVal4.BackColor = SystemColors.ControlDarkDark;
            textBox_nAdjParamVal4.BorderStyle = BorderStyle.FixedSingle;
            textBox_nAdjParamVal4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_nAdjParamVal4.ForeColor = Color.White;
            textBox_nAdjParamVal4.Location = new Point(713, 475);
            textBox_nAdjParamVal4.Name = "textBox_nAdjParamVal4";
            textBox_nAdjParamVal4.Size = new Size(75, 21);
            textBox_nAdjParamVal4.TabIndex = 95;
            // 
            // textBox_nAdjParamVal1
            // 
            textBox_nAdjParamVal1.BackColor = SystemColors.ControlDarkDark;
            textBox_nAdjParamVal1.BorderStyle = BorderStyle.FixedSingle;
            textBox_nAdjParamVal1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_nAdjParamVal1.ForeColor = Color.White;
            textBox_nAdjParamVal1.Location = new Point(713, 403);
            textBox_nAdjParamVal1.Name = "textBox_nAdjParamVal1";
            textBox_nAdjParamVal1.Size = new Size(75, 21);
            textBox_nAdjParamVal1.TabIndex = 89;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label29.Location = new Point(655, 475);
            label29.Name = "label29";
            label29.Size = new Size(52, 16);
            label29.TabIndex = 94;
            label29.Text = "Value 4";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label30.Location = new Point(655, 403);
            label30.Name = "label30";
            label30.Size = new Size(52, 16);
            label30.TabIndex = 88;
            label30.Text = "Value 1";
            // 
            // textBox_nAdjParamVal3
            // 
            textBox_nAdjParamVal3.BackColor = SystemColors.ControlDarkDark;
            textBox_nAdjParamVal3.BorderStyle = BorderStyle.FixedSingle;
            textBox_nAdjParamVal3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_nAdjParamVal3.ForeColor = Color.White;
            textBox_nAdjParamVal3.Location = new Point(713, 451);
            textBox_nAdjParamVal3.Name = "textBox_nAdjParamVal3";
            textBox_nAdjParamVal3.Size = new Size(75, 21);
            textBox_nAdjParamVal3.TabIndex = 93;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label31.Location = new Point(655, 427);
            label31.Name = "label31";
            label31.Size = new Size(52, 16);
            label31.TabIndex = 90;
            label31.Text = "Value 2";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label32.Location = new Point(655, 451);
            label32.Name = "label32";
            label32.Size = new Size(52, 16);
            label32.TabIndex = 92;
            label32.Text = "Value 3";
            // 
            // textBox_nAdjParamVal2
            // 
            textBox_nAdjParamVal2.BackColor = SystemColors.ControlDarkDark;
            textBox_nAdjParamVal2.BorderStyle = BorderStyle.FixedSingle;
            textBox_nAdjParamVal2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_nAdjParamVal2.ForeColor = Color.White;
            textBox_nAdjParamVal2.Location = new Point(713, 427);
            textBox_nAdjParamVal2.Name = "textBox_nAdjParamVal2";
            textBox_nAdjParamVal2.Size = new Size(75, 21);
            textBox_nAdjParamVal2.TabIndex = 91;
            // 
            // textBox_dwDestParam6
            // 
            textBox_dwDestParam6.BackColor = SystemColors.ControlDarkDark;
            textBox_dwDestParam6.BorderStyle = BorderStyle.FixedSingle;
            textBox_dwDestParam6.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_dwDestParam6.ForeColor = Color.White;
            textBox_dwDestParam6.Location = new Point(347, 524);
            textBox_dwDestParam6.Name = "textBox_dwDestParam6";
            textBox_dwDestParam6.Size = new Size(273, 21);
            textBox_dwDestParam6.TabIndex = 87;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label25.Location = new Point(264, 524);
            label25.Name = "label25";
            label25.Size = new Size(57, 16);
            label25.TabIndex = 86;
            label25.Text = "Param 6";
            // 
            // textBox_dwDestParam5
            // 
            textBox_dwDestParam5.BackColor = SystemColors.ControlDarkDark;
            textBox_dwDestParam5.BorderStyle = BorderStyle.FixedSingle;
            textBox_dwDestParam5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_dwDestParam5.ForeColor = Color.White;
            textBox_dwDestParam5.Location = new Point(347, 500);
            textBox_dwDestParam5.Name = "textBox_dwDestParam5";
            textBox_dwDestParam5.Size = new Size(273, 21);
            textBox_dwDestParam5.TabIndex = 85;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label26.Location = new Point(264, 500);
            label26.Name = "label26";
            label26.Size = new Size(57, 16);
            label26.TabIndex = 84;
            label26.Text = "Param 5";
            // 
            // textBox_dwDestParam4
            // 
            textBox_dwDestParam4.BackColor = SystemColors.ControlDarkDark;
            textBox_dwDestParam4.BorderStyle = BorderStyle.FixedSingle;
            textBox_dwDestParam4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_dwDestParam4.ForeColor = Color.White;
            textBox_dwDestParam4.Location = new Point(347, 475);
            textBox_dwDestParam4.Name = "textBox_dwDestParam4";
            textBox_dwDestParam4.Size = new Size(273, 21);
            textBox_dwDestParam4.TabIndex = 83;
            // 
            // textBox_dwDestParam1
            // 
            textBox_dwDestParam1.BackColor = SystemColors.ControlDarkDark;
            textBox_dwDestParam1.BorderStyle = BorderStyle.FixedSingle;
            textBox_dwDestParam1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_dwDestParam1.ForeColor = Color.White;
            textBox_dwDestParam1.Location = new Point(347, 403);
            textBox_dwDestParam1.Name = "textBox_dwDestParam1";
            textBox_dwDestParam1.Size = new Size(273, 21);
            textBox_dwDestParam1.TabIndex = 77;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(264, 475);
            label21.Name = "label21";
            label21.Size = new Size(57, 16);
            label21.TabIndex = 82;
            label21.Text = "Param 4";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(264, 403);
            label24.Name = "label24";
            label24.Size = new Size(57, 16);
            label24.TabIndex = 76;
            label24.Text = "Param 1";
            // 
            // textBox_dwDestParam3
            // 
            textBox_dwDestParam3.BackColor = SystemColors.ControlDarkDark;
            textBox_dwDestParam3.BorderStyle = BorderStyle.FixedSingle;
            textBox_dwDestParam3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_dwDestParam3.ForeColor = Color.White;
            textBox_dwDestParam3.Location = new Point(347, 451);
            textBox_dwDestParam3.Name = "textBox_dwDestParam3";
            textBox_dwDestParam3.Size = new Size(273, 21);
            textBox_dwDestParam3.TabIndex = 81;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(264, 427);
            label23.Name = "label23";
            label23.Size = new Size(57, 16);
            label23.TabIndex = 78;
            label23.Text = "Param 2";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(264, 451);
            label22.Name = "label22";
            label22.Size = new Size(57, 16);
            label22.TabIndex = 80;
            label22.Text = "Param 3";
            // 
            // textBox_dwDestParam2
            // 
            textBox_dwDestParam2.BackColor = SystemColors.ControlDarkDark;
            textBox_dwDestParam2.BorderStyle = BorderStyle.FixedSingle;
            textBox_dwDestParam2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_dwDestParam2.ForeColor = Color.White;
            textBox_dwDestParam2.Location = new Point(347, 427);
            textBox_dwDestParam2.Name = "textBox_dwDestParam2";
            textBox_dwDestParam2.Size = new Size(273, 21);
            textBox_dwDestParam2.TabIndex = 79;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label33.Location = new Point(264, 383);
            label33.Name = "label33";
            label33.Size = new Size(184, 17);
            label33.TabIndex = 100;
            label33.Text = "Stats from Spec_Item.txt";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(249, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(878, 1);
            panel2.TabIndex = 101;
            // 
            // ItemsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(panel2);
            Controls.Add(label33);
            Controls.Add(textBox_nAdjParamVal6);
            Controls.Add(label27);
            Controls.Add(textBox_nAdjParamVal5);
            Controls.Add(label28);
            Controls.Add(textBox_nAdjParamVal4);
            Controls.Add(textBox_nAdjParamVal1);
            Controls.Add(label29);
            Controls.Add(label30);
            Controls.Add(textBox_nAdjParamVal3);
            Controls.Add(label31);
            Controls.Add(label32);
            Controls.Add(textBox_nAdjParamVal2);
            Controls.Add(textBox_dwDestParam6);
            Controls.Add(label25);
            Controls.Add(textBox_dwDestParam5);
            Controls.Add(label26);
            Controls.Add(textBox_dwDestParam4);
            Controls.Add(textBox_dwDestParam1);
            Controls.Add(label21);
            Controls.Add(label24);
            Controls.Add(textBox_dwDestParam3);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(textBox_dwDestParam2);
            Controls.Add(button7);
            Controls.Add(textBox_dwAttackSpeed);
            Controls.Add(label20);
            Controls.Add(textBox_dwAbilityMax);
            Controls.Add(label15);
            Controls.Add(textBox_dwAttackRange);
            Controls.Add(label11);
            Controls.Add(textBox_dwWeaponType);
            Controls.Add(label12);
            Controls.Add(textBox_dwAbilityMin);
            Controls.Add(label13);
            Controls.Add(textBox_dwHanded);
            Controls.Add(label14);
            Controls.Add(textBox_dwItemJob);
            Controls.Add(label16);
            Controls.Add(textBox_dwItemRare);
            Controls.Add(label17);
            Controls.Add(textBox_dwCircleTime);
            Controls.Add(label18);
            Controls.Add(textBox_dwItemLV);
            Controls.Add(label19);
            Controls.Add(textBox_dwCost);
            Controls.Add(label10);
            Controls.Add(textBox_dwItemKind3);
            Controls.Add(label7);
            Controls.Add(textBox_dwItemKind2);
            Controls.Add(label8);
            Controls.Add(textBox_dwItemKind1);
            Controls.Add(label9);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox_search);
            Controls.Add(panel1);
            Controls.Add(textBox_MaxStack);
            Controls.Add(label6);
            Controls.Add(textBox_szComment);
            Controls.Add(label5);
            Controls.Add(textBox_IngameName);
            Controls.Add(label4);
            Controls.Add(textBox_Name);
            Controls.Add(label3);
            Controls.Add(textBox_ID);
            Controls.Add(label2);
            Controls.Add(listBox_Items);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "ItemsView";
            Size = new Size(1140, 635);
            Load += ItemsView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox_Items;
        private Label label2;
        private TextBox textBox_ID;
        private TextBox textBox_Name;
        private Label label3;
        private TextBox textBox_IngameName;
        private Label label4;
        private TextBox textBox_szComment;
        private Label label5;
        private TextBox textBox_MaxStack;
        private Label label6;
        private Panel panel1;
        private TextBox textBox_search;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox textBox_dwItemKind3;
        private Label label7;
        private TextBox textBox_dwItemKind2;
        private Label label8;
        private TextBox textBox_dwItemKind1;
        private Label label9;
        private TextBox textBox_dwCost;
        private Label label10;
        private TextBox textBox_dwAttackRange;
        private Label label11;
        private TextBox textBox_dwWeaponType;
        private Label label12;
        private TextBox textBox_dwAbilityMin;
        private Label label13;
        private TextBox textBox_dwHanded;
        private Label label14;
        private TextBox textBox_dwItemJob;
        private Label label16;
        private TextBox textBox_dwItemRare;
        private Label label17;
        private TextBox textBox_dwCircleTime;
        private Label label18;
        private TextBox textBox_dwItemLV;
        private Label label19;
        private TextBox textBox_dwAbilityMax;
        private Label label15;
        private TextBox textBox_dwAttackSpeed;
        private Label label20;
        private Button button7;
        private TextBox textBox_nAdjParamVal6;
        private Label label27;
        private TextBox textBox_nAdjParamVal5;
        private Label label28;
        private TextBox textBox_nAdjParamVal4;
        private TextBox textBox_nAdjParamVal1;
        private Label label29;
        private Label label30;
        private TextBox textBox_nAdjParamVal3;
        private Label label31;
        private Label label32;
        private TextBox textBox_nAdjParamVal2;
        private TextBox textBox_dwDestParam6;
        private Label label25;
        private TextBox textBox_dwDestParam5;
        private Label label26;
        private TextBox textBox_dwDestParam4;
        private TextBox textBox_dwDestParam1;
        private Label label21;
        private Label label24;
        private TextBox textBox_dwDestParam3;
        private Label label23;
        private Label label22;
        private TextBox textBox_dwDestParam2;
        private Label label33;
        private Button button_CardFilter;
        private Button button_FoodFilter;
        private Button button_ScrollFilter;
        private Button button_ArmorFilter;
        private Button button_weaponFilter;
        private Label label34;
        private Panel panel2;
        private ComboBox comboBox_MoverClass;
        private Label label35;
    }
}
