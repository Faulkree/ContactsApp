namespace ContactsAppUI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ContactlistBox1 = new System.Windows.Forms.ListBox();
            this.SecondNameTextBox1 = new System.Windows.Forms.TextBox();
            this.NameTextBox1 = new System.Windows.Forms.TextBox();
            this.PhoneTextBox1 = new System.Windows.Forms.TextBox();
            this.EmailTextBox1 = new System.Windows.Forms.TextBox();
            this.VKTextBox1 = new System.Windows.Forms.TextBox();
            this.BirthTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "SecondName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Birthday:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "E-mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "vk.com:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Find";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(77, 522);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(152, 523);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ContactlistBox1
            // 
            this.ContactlistBox1.FormattingEnabled = true;
            this.ContactlistBox1.Location = new System.Drawing.Point(17, 81);
            this.ContactlistBox1.Name = "ContactlistBox1";
            this.ContactlistBox1.Size = new System.Drawing.Size(231, 420);
            this.ContactlistBox1.TabIndex = 21;
            this.ContactlistBox1.SelectedIndexChanged += new System.EventHandler(this.ContactlistBox1_SelectedIndexChanged);
            // 
            // SecondNameTextBox1
            // 
            this.SecondNameTextBox1.Location = new System.Drawing.Point(422, 81);
            this.SecondNameTextBox1.Name = "SecondNameTextBox1";
            this.SecondNameTextBox1.Size = new System.Drawing.Size(248, 20);
            this.SecondNameTextBox1.TabIndex = 22;
            // 
            // NameTextBox1
            // 
            this.NameTextBox1.Location = new System.Drawing.Point(422, 115);
            this.NameTextBox1.Name = "NameTextBox1";
            this.NameTextBox1.Size = new System.Drawing.Size(248, 20);
            this.NameTextBox1.TabIndex = 23;
            this.NameTextBox1.TextChanged += new System.EventHandler(this.NameTextBox1_TextChanged);
            // 
            // PhoneTextBox1
            // 
            this.PhoneTextBox1.Location = new System.Drawing.Point(422, 212);
            this.PhoneTextBox1.Name = "PhoneTextBox1";
            this.PhoneTextBox1.Size = new System.Drawing.Size(248, 20);
            this.PhoneTextBox1.TabIndex = 24;
            // 
            // EmailTextBox1
            // 
            this.EmailTextBox1.Location = new System.Drawing.Point(422, 252);
            this.EmailTextBox1.Name = "EmailTextBox1";
            this.EmailTextBox1.Size = new System.Drawing.Size(248, 20);
            this.EmailTextBox1.TabIndex = 25;
            // 
            // VKTextBox1
            // 
            this.VKTextBox1.Location = new System.Drawing.Point(422, 305);
            this.VKTextBox1.Name = "VKTextBox1";
            this.VKTextBox1.Size = new System.Drawing.Size(248, 20);
            this.VKTextBox1.TabIndex = 26;
            this.VKTextBox1.TextChanged += new System.EventHandler(this.VKTextBox1_TextChanged);
            // 
            // BirthTimePicker1
            // 
            this.BirthTimePicker1.Location = new System.Drawing.Point(422, 168);
            this.BirthTimePicker1.Name = "BirthTimePicker1";
            this.BirthTimePicker1.Size = new System.Drawing.Size(248, 20);
            this.BirthTimePicker1.TabIndex = 27;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 574);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BirthTimePicker1);
            this.Controls.Add(this.VKTextBox1);
            this.Controls.Add(this.EmailTextBox1);
            this.Controls.Add(this.PhoneTextBox1);
            this.Controls.Add(this.NameTextBox1);
            this.Controls.Add(this.SecondNameTextBox1);
            this.Controls.Add(this.ContactlistBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ContactsApp";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox ContactlistBox1;
        private System.Windows.Forms.TextBox SecondNameTextBox1;
        private System.Windows.Forms.TextBox NameTextBox1;
        private System.Windows.Forms.TextBox PhoneTextBox1;
        private System.Windows.Forms.TextBox EmailTextBox1;
        private System.Windows.Forms.TextBox VKTextBox1;
        private System.Windows.Forms.DateTimePicker BirthTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

