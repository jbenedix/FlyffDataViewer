namespace FlyffDataViewer.Dialogs
{
    partial class ShopList
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
            button2 = new Button();
            textBox_shoplist = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(12, 382);
            button2.Name = "button2";
            button2.Size = new Size(128, 30);
            button2.TabIndex = 19;
            button2.Text = "Copy";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox_shoplist
            // 
            textBox_shoplist.BackColor = SystemColors.ControlDarkDark;
            textBox_shoplist.BorderStyle = BorderStyle.FixedSingle;
            textBox_shoplist.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_shoplist.ForeColor = Color.White;
            textBox_shoplist.Location = new Point(11, 31);
            textBox_shoplist.Multiline = true;
            textBox_shoplist.Name = "textBox_shoplist";
            textBox_shoplist.Size = new Size(616, 345);
            textBox_shoplist.TabIndex = 18;
            textBox_shoplist.TextChanged += textBox_shoplist_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 12);
            label2.Name = "label2";
            label2.Size = new Size(44, 16);
            label2.TabIndex = 17;
            label2.Text = "Name";
            // 
            // ShopList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(640, 432);
            Controls.Add(button2);
            Controls.Add(textBox_shoplist);
            Controls.Add(label2);
            ForeColor = SystemColors.ControlText;
            Name = "ShopList";
            Text = "ShopList";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox textBox_shoplist;
        private Label label2;
    }
}