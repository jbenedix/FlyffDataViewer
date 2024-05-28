namespace FlyffDataViewer.Usercontrols
{
    partial class MoversView
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
            button7 = new Button();
            textBox_search = new TextBox();
            panel1 = new Panel();
            comboBox_MoverClass = new ComboBox();
            label6 = new Label();
            label34 = new Label();
            button_PetFilter = new Button();
            button_MonsterFilter = new Button();
            label1 = new Label();
            listBox_Movers = new ListBox();
            textBox_szComment = new TextBox();
            label5 = new Label();
            textBox_IngameName = new TextBox();
            label4 = new Label();
            textBox_Name = new TextBox();
            label3 = new Label();
            textBox_ID = new TextBox();
            label2 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button7
            // 
            button7.BackColor = Color.DimGray;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Location = new Point(187, 47);
            button7.Name = "button7";
            button7.Size = new Size(49, 21);
            button7.TabIndex = 54;
            button7.Text = "Reset";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
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
            textBox_search.TabIndex = 53;
            textBox_search.TextChanged += textBox_search_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox_MoverClass);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label34);
            panel1.Controls.Add(button_PetFilter);
            panel1.Controls.Add(button_MonsterFilter);
            panel1.Location = new Point(242, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(898, 31);
            panel1.TabIndex = 52;
            // 
            // comboBox_MoverClass
            // 
            comboBox_MoverClass.BackColor = SystemColors.ControlDarkDark;
            comboBox_MoverClass.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_MoverClass.FlatStyle = FlatStyle.Popup;
            comboBox_MoverClass.ForeColor = Color.White;
            comboBox_MoverClass.FormattingEnabled = true;
            comboBox_MoverClass.Items.AddRange(new object[] { "0", "1", "2", "3" });
            comboBox_MoverClass.Location = new Point(582, 4);
            comboBox_MoverClass.Name = "comboBox_MoverClass";
            comboBox_MoverClass.Size = new Size(143, 23);
            comboBox_MoverClass.TabIndex = 107;
            comboBox_MoverClass.SelectedIndexChanged += comboBox_MoverClass_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(538, 8);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 106;
            label6.Text = "Klasse";
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
            // button_PetFilter
            // 
            button_PetFilter.BackColor = Color.DimGray;
            button_PetFilter.FlatStyle = FlatStyle.Popup;
            button_PetFilter.Location = new Point(165, 3);
            button_PetFilter.Name = "button_PetFilter";
            button_PetFilter.Size = new Size(84, 24);
            button_PetFilter.TabIndex = 102;
            button_PetFilter.Text = "Pets";
            button_PetFilter.UseVisualStyleBackColor = false;
            button_PetFilter.Click += button_PetFilter_Click;
            // 
            // button_MonsterFilter
            // 
            button_MonsterFilter.BackColor = Color.DimGray;
            button_MonsterFilter.FlatStyle = FlatStyle.Popup;
            button_MonsterFilter.Location = new Point(66, 3);
            button_MonsterFilter.Name = "button_MonsterFilter";
            button_MonsterFilter.Size = new Size(93, 24);
            button_MonsterFilter.TabIndex = 101;
            button_MonsterFilter.Text = "Monsters";
            button_MonsterFilter.UseVisualStyleBackColor = false;
            button_MonsterFilter.Click += button_MonsterFilter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(177, 25);
            label1.TabIndex = 51;
            label1.Text = "Monsters, Pets etc.";
            // 
            // listBox_Movers
            // 
            listBox_Movers.BackColor = Color.FromArgb(64, 64, 64);
            listBox_Movers.BorderStyle = BorderStyle.FixedSingle;
            listBox_Movers.DisplayMember = "ingameName";
            listBox_Movers.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBox_Movers.ForeColor = Color.White;
            listBox_Movers.FormattingEnabled = true;
            listBox_Movers.ItemHeight = 14;
            listBox_Movers.Location = new Point(3, 73);
            listBox_Movers.Name = "listBox_Movers";
            listBox_Movers.Size = new Size(242, 548);
            listBox_Movers.TabIndex = 103;
            listBox_Movers.SelectedIndexChanged += listBox_Movers_SelectedIndexChanged;
            // 
            // textBox_szComment
            // 
            textBox_szComment.BackColor = SystemColors.ControlDarkDark;
            textBox_szComment.BorderStyle = BorderStyle.FixedSingle;
            textBox_szComment.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_szComment.ForeColor = Color.White;
            textBox_szComment.Location = new Point(351, 162);
            textBox_szComment.Name = "textBox_szComment";
            textBox_szComment.Size = new Size(193, 21);
            textBox_szComment.TabIndex = 111;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(270, 162);
            label5.Name = "label5";
            label5.Size = new Size(75, 16);
            label5.TabIndex = 110;
            label5.Text = "Description";
            // 
            // textBox_IngameName
            // 
            textBox_IngameName.BackColor = SystemColors.ControlDarkDark;
            textBox_IngameName.BorderStyle = BorderStyle.FixedSingle;
            textBox_IngameName.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_IngameName.ForeColor = Color.White;
            textBox_IngameName.Location = new Point(351, 138);
            textBox_IngameName.Name = "textBox_IngameName";
            textBox_IngameName.Size = new Size(193, 21);
            textBox_IngameName.TabIndex = 109;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(253, 138);
            label4.Name = "label4";
            label4.Size = new Size(92, 16);
            label4.TabIndex = 108;
            label4.Text = "Ingame Name";
            // 
            // textBox_Name
            // 
            textBox_Name.BackColor = SystemColors.ControlDarkDark;
            textBox_Name.BorderStyle = BorderStyle.FixedSingle;
            textBox_Name.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Name.ForeColor = Color.White;
            textBox_Name.Location = new Point(351, 114);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(193, 21);
            textBox_Name.TabIndex = 107;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(301, 114);
            label3.Name = "label3";
            label3.Size = new Size(44, 16);
            label3.TabIndex = 106;
            label3.Text = "Name";
            // 
            // textBox_ID
            // 
            textBox_ID.BackColor = SystemColors.ControlDarkDark;
            textBox_ID.BorderStyle = BorderStyle.FixedSingle;
            textBox_ID.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_ID.ForeColor = Color.White;
            textBox_ID.Location = new Point(351, 81);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(87, 21);
            textBox_ID.TabIndex = 105;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(325, 83);
            label2.Name = "label2";
            label2.Size = new Size(20, 16);
            label2.TabIndex = 104;
            label2.Text = "ID";
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(253, 591);
            button1.Name = "button1";
            button1.Size = new Size(128, 30);
            button1.TabIndex = 112;
            button1.Text = "Copy Create Mover";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MoversView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(button1);
            Controls.Add(textBox_szComment);
            Controls.Add(label5);
            Controls.Add(textBox_IngameName);
            Controls.Add(label4);
            Controls.Add(textBox_Name);
            Controls.Add(label3);
            Controls.Add(textBox_ID);
            Controls.Add(label2);
            Controls.Add(listBox_Movers);
            Controls.Add(button7);
            Controls.Add(textBox_search);
            Controls.Add(panel1);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "MoversView";
            Size = new Size(1140, 635);
            Load += MoversView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button7;
        private TextBox textBox_search;
        private Panel panel1;
        private Label label34;
        private Button button_PetFilter;
        private Button button_MonsterFilter;
        private Label label1;
        private ListBox listBox_Movers;
        private TextBox textBox_szComment;
        private Label label5;
        private TextBox textBox_IngameName;
        private Label label4;
        private TextBox textBox_Name;
        private Label label3;
        private TextBox textBox_ID;
        private Label label2;
        private Label label6;
        private ComboBox comboBox_MoverClass;
        private Button button1;
    }
}
