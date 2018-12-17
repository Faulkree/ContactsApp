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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BirthTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SecondNameTextBox1 = new System.Windows.Forms.TextBox();
            this.NameTextBox1 = new System.Windows.Forms.TextBox();
            this.PhoneTextBox1 = new System.Windows.Forms.TextBox();
            this.EmailtextBox1 = new System.Windows.Forms.TextBox();
            this.VKtextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SecondName:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birthday:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "vk.com:";
            // 
            // BirthTimePicker1
            // 
            this.BirthTimePicker1.Location = new System.Drawing.Point(87, 112);
            this.BirthTimePicker1.Name = "BirthTimePicker1";
            this.BirthTimePicker1.Size = new System.Drawing.Size(138, 20);
            this.BirthTimePicker1.TabIndex = 11;
            this.BirthTimePicker1.ValueChanged += new System.EventHandler(this.BirthTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(394, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SecondNameTextBox1
            // 
            this.SecondNameTextBox1.Location = new System.Drawing.Point(88, 42);
            this.SecondNameTextBox1.Name = "SecondNameTextBox1";
            this.SecondNameTextBox1.Size = new System.Drawing.Size(227, 20);
            this.SecondNameTextBox1.TabIndex = 14;
            this.SecondNameTextBox1.TextChanged += new System.EventHandler(this.SecondNameTextBox1_TextChanged);
            // 
            // NameTextBox1
            // 
            this.NameTextBox1.Location = new System.Drawing.Point(87, 74);
            this.NameTextBox1.Name = "NameTextBox1";
            this.NameTextBox1.Size = new System.Drawing.Size(228, 20);
            this.NameTextBox1.TabIndex = 15;
            this.NameTextBox1.TextChanged += new System.EventHandler(this.NameTextBox1_TextChanged);
            // 
            // PhoneTextBox1
            // 
            this.PhoneTextBox1.Location = new System.Drawing.Point(87, 147);
            this.PhoneTextBox1.Name = "PhoneTextBox1";
            this.PhoneTextBox1.Size = new System.Drawing.Size(228, 20);
            this.PhoneTextBox1.TabIndex = 16;
            this.PhoneTextBox1.TextChanged += new System.EventHandler(this.PhoneTextBox1_TextChanged);
            // 
            // EmailtextBox1
            // 
            this.EmailtextBox1.Location = new System.Drawing.Point(88, 181);
            this.EmailtextBox1.Name = "EmailtextBox1";
            this.EmailtextBox1.Size = new System.Drawing.Size(227, 20);
            this.EmailtextBox1.TabIndex = 17;
            this.EmailtextBox1.TextChanged += new System.EventHandler(this.EmailtextBox1_TextChanged);
            // 
            // VKtextBox1
            // 
            this.VKtextBox1.Location = new System.Drawing.Point(88, 222);
            this.VKtextBox1.Name = "VKtextBox1";
            this.VKtextBox1.Size = new System.Drawing.Size(227, 20);
            this.VKtextBox1.TabIndex = 18;
            this.VKtextBox1.TextChanged += new System.EventHandler(this.VKtextBox1_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 303);
            this.Controls.Add(this.VKtextBox1);
            this.Controls.Add(this.EmailtextBox1);
            this.Controls.Add(this.PhoneTextBox1);
            this.Controls.Add(this.NameTextBox1);
            this.Controls.Add(this.SecondNameTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BirthTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Add/Edit Contact";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker BirthTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox SecondNameTextBox1;
        private System.Windows.Forms.TextBox NameTextBox1;
        private System.Windows.Forms.TextBox PhoneTextBox1;
        private System.Windows.Forms.TextBox EmailtextBox1;
        private System.Windows.Forms.TextBox VKtextBox1;
    }
}