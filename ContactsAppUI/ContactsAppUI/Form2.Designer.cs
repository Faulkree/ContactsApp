namespace ContactsAppUI
{
    partial class Form2
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
            this.SecondName = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.Birth = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NameTextBox1 = new System.Windows.Forms.TextBox();
            this.PhoneTextBox1 = new System.Windows.Forms.TextBox();
            this.EmailtextBox1 = new System.Windows.Forms.TextBox();
            this.VKtextBox1 = new System.Windows.Forms.TextBox();
            this.BirthTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SecondNameTextBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SecondName
            // 
            this.SecondName.AutoSize = true;
            this.SecondName.Location = new System.Drawing.Point(12, 15);
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(72, 13);
            this.SecondName.TabIndex = 0;
            this.SecondName.Text = "SecondName";
            this.SecondName.Click += new System.EventHandler(this.SecondName_Click);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(49, 46);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 1;
            this.Name.Text = "Name";
            // 
            // Birth
            // 
            this.Birth.AutoSize = true;
            this.Birth.Location = new System.Drawing.Point(56, 74);
            this.Birth.Name = "Birth";
            this.Birth.Size = new System.Drawing.Size(28, 13);
            this.Birth.TabIndex = 2;
            this.Birth.Text = "Birth";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(49, 109);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(38, 13);
            this.Phone.TabIndex = 3;
            this.Phone.Text = "Phone";
            this.Phone.Click += new System.EventHandler(this.Phone_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "IDVK";
            // 
            // NameTextBox1
            // 
            this.NameTextBox1.Location = new System.Drawing.Point(90, 43);
            this.NameTextBox1.Name = "NameTextBox1";
            this.NameTextBox1.Size = new System.Drawing.Size(200, 20);
            this.NameTextBox1.TabIndex = 7;
            this.NameTextBox1.TextChanged += new System.EventHandler(this.NameTextBox1_TextChanged_1);
            // 
            // PhoneTextBox1
            // 
            this.PhoneTextBox1.Location = new System.Drawing.Point(90, 106);
            this.PhoneTextBox1.Name = "PhoneTextBox1";
            this.PhoneTextBox1.Size = new System.Drawing.Size(200, 20);
            this.PhoneTextBox1.TabIndex = 8;
            this.PhoneTextBox1.TextChanged += new System.EventHandler(this.PhoneTextBox1_TextChanged_1);
            // 
            // EmailtextBox1
            // 
            this.EmailtextBox1.Location = new System.Drawing.Point(90, 132);
            this.EmailtextBox1.Name = "EmailtextBox1";
            this.EmailtextBox1.Size = new System.Drawing.Size(200, 20);
            this.EmailtextBox1.TabIndex = 9;
            this.EmailtextBox1.TextChanged += new System.EventHandler(this.EmailtextBox1_TextChanged_1);
            // 
            // VKtextBox1
            // 
            this.VKtextBox1.Location = new System.Drawing.Point(90, 158);
            this.VKtextBox1.Name = "VKtextBox1";
            this.VKtextBox1.Size = new System.Drawing.Size(200, 20);
            this.VKtextBox1.TabIndex = 10;
            this.VKtextBox1.TextChanged += new System.EventHandler(this.VKtextBox1_TextChanged_1);
            // 
            // BirthTimePicker1
            // 
            this.BirthTimePicker1.Location = new System.Drawing.Point(90, 74);
            this.BirthTimePicker1.Name = "BirthTimePicker1";
            this.BirthTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.BirthTimePicker1.TabIndex = 11;
            this.BirthTimePicker1.ValueChanged += new System.EventHandler(this.BirthTimePicker1_ValueChanged_1);
            // 
            // SecondNameTextBox1
            // 
            this.SecondNameTextBox1.Location = new System.Drawing.Point(90, 12);
            this.SecondNameTextBox1.Name = "SecondNameTextBox1";
            this.SecondNameTextBox1.Size = new System.Drawing.Size(200, 20);
            this.SecondNameTextBox1.TabIndex = 12;
            this.SecondNameTextBox1.TextChanged += new System.EventHandler(this.SecondNameTextBox1_TextChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 243);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SecondNameTextBox1);
            this.Controls.Add(this.BirthTimePicker1);
            this.Controls.Add(this.VKtextBox1);
            this.Controls.Add(this.EmailtextBox1);
            this.Controls.Add(this.PhoneTextBox1);
            this.Controls.Add(this.NameTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Birth);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.SecondName);
            this.Name = "Form2";
            this.Text = "Add/Edit";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SecondName;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Birth;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameTextBox1;
        private System.Windows.Forms.TextBox PhoneTextBox1;
        private System.Windows.Forms.TextBox EmailtextBox1;
        private System.Windows.Forms.TextBox VKtextBox1;
        private System.Windows.Forms.DateTimePicker BirthTimePicker1;
        private System.Windows.Forms.TextBox SecondNameTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}