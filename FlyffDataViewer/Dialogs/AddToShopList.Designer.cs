namespace FlyffDataViewer.Dialogs
{
    partial class AddToShopList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_ItemName = new TextBox();
            label2 = new Label();
            textBox_Price = new TextBox();
            label1 = new Label();
            button2 = new Button();
            label3 = new Label();
            comboBox_Slot = new ComboBox();
            SuspendLayout();
            // 
            // textBox_ItemName
            // 
            textBox_ItemName.BackColor = SystemColors.ControlDarkDark;
            textBox_ItemName.BorderStyle = BorderStyle.FixedSingle;
            textBox_ItemName.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_ItemName.ForeColor = Color.White;
            textBox_ItemName.Location = new Point(80, 25);
            textBox_ItemName.Name = "textBox_ItemName";
            textBox_ItemName.Size = new Size(180, 21);
            textBox_ItemName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 25);
            label2.Name = "label2";
            label2.Size = new Size(44, 16);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // textBox_Price
            // 
            textBox_Price.BackColor = SystemColors.ControlDarkDark;
            textBox_Price.BorderStyle = BorderStyle.FixedSingle;
            textBox_Price.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Price.ForeColor = Color.White;
            textBox_Price.Location = new Point(80, 95);
            textBox_Price.Name = "textBox_Price";
            textBox_Price.Size = new Size(121, 21);
            textBox_Price.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(36, 95);
            label1.Name = "label1";
            label1.Size = new Size(38, 16);
            label1.TabIndex = 6;
            label1.Text = "Price";
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(30, 143);
            button2.Name = "button2";
            button2.Size = new Size(128, 30);
            button2.TabIndex = 16;
            button2.Text = "Add To List";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(36, 63);
            label3.Name = "label3";
            label3.Size = new Size(30, 16);
            label3.TabIndex = 17;
            label3.Text = "Slot";
            // 
            // comboBox_Slot
            // 
            comboBox_Slot.BackColor = SystemColors.ControlDarkDark;
            comboBox_Slot.FlatStyle = FlatStyle.Popup;
            comboBox_Slot.ForeColor = Color.White;
            comboBox_Slot.FormattingEnabled = true;
            comboBox_Slot.Items.AddRange(new object[] { "0", "1", "2", "3" });
            comboBox_Slot.Location = new Point(80, 61);
            comboBox_Slot.Name = "comboBox_Slot";
            comboBox_Slot.Size = new Size(65, 23);
            comboBox_Slot.TabIndex = 18;
            // 
            // AddToShopList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(273, 206);
            Controls.Add(comboBox_Slot);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(textBox_Price);
            Controls.Add(label1);
            Controls.Add(textBox_ItemName);
            Controls.Add(label2);
            Name = "AddToShopList";
            Text = "AddToShopList";
            Load += AddToShopList_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_ItemName;
        private Label label2;
        private TextBox textBox_Price;
        private Label label1;
        private Button button2;
        private Label label3;
        private ComboBox comboBox_Slot;
    }
}