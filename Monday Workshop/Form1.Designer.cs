namespace Monday_Workshop
{
    partial class Form1
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.mobileBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.mobileLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.listButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.SystemColors.Window;
            this.nameBox.Location = new System.Drawing.Point(78, 81);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(214, 20);
            this.nameBox.TabIndex = 0;
            this.nameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mobileBox
            // 
            this.mobileBox.BackColor = System.Drawing.SystemColors.Window;
            this.mobileBox.Location = new System.Drawing.Point(78, 159);
            this.mobileBox.Name = "mobileBox";
            this.mobileBox.Size = new System.Drawing.Size(214, 20);
            this.mobileBox.TabIndex = 1;
            this.mobileBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ageBox
            // 
            this.ageBox.BackColor = System.Drawing.SystemColors.Window;
            this.ageBox.Location = new System.Drawing.Point(78, 133);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(214, 20);
            this.ageBox.TabIndex = 2;
            this.ageBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // addressBox
            // 
            this.addressBox.BackColor = System.Drawing.SystemColors.Window;
            this.addressBox.Location = new System.Drawing.Point(78, 107);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(214, 20);
            this.addressBox.TabIndex = 3;
            this.addressBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(78, 231);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(85, 30);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // typeBox
            // 
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(78, 185);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(214, 21);
            this.typeBox.TabIndex = 6;
            this.typeBox.SelectedIndexChanged += new System.EventHandler(this.typeBox_SelectedIndexChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 84);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(13, 110);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 8;
            this.addressLabel.Text = "Address";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(13, 136);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(26, 13);
            this.ageLabel.TabIndex = 9;
            this.ageLabel.Text = "Age";
            // 
            // mobileLabel
            // 
            this.mobileLabel.AutoSize = true;
            this.mobileLabel.Location = new System.Drawing.Point(13, 162);
            this.mobileLabel.Name = "mobileLabel";
            this.mobileLabel.Size = new System.Drawing.Size(38, 13);
            this.mobileLabel.TabIndex = 10;
            this.mobileLabel.Text = "Mobile";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(13, 188);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 13);
            this.typeLabel.TabIndex = 11;
            this.typeLabel.Text = "Type";
            // 
            // listButton
            // 
            this.listButton.Location = new System.Drawing.Point(207, 231);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(85, 30);
            this.listButton.TabIndex = 12;
            this.listButton.Text = "List";
            this.listButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(325, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(413, 186);
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 359);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listButton);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.mobileLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.mobileBox);
            this.Controls.Add(this.nameBox);
            this.Name = "Form1";
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox mobileBox;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label mobileLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Button listButton;
        private System.Windows.Forms.ListBox listBox1;
    }
}

