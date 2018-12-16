using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;

namespace ContactsAppUI
{
    public partial class Form2 : Form
    {
        private Contact _contactsplus = new Contact();
        public Contact Contactsplus
        {
            get { return _contactsplus; }
            set
            {
                _contactsplus.SecondName = value.SecondName;
                _contactsplus.Name = value.Name;
                _contactsplus.Phone = value.Phone;
                _contactsplus.Birth = value.Birth;
                _contactsplus.Email = value.Email;
                _contactsplus.IDVk = value.IDVk;
            }
        }


        public Form2()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (_contactsplus.SecondName != null)
            {
                SecondNameTextBox1.Text = _contactsplus.SecondName;
                NameTextBox1.Text = _contactsplus.Name;
                 BirthTimePicker1.Value = _contactsplus.Birth; 
                PhoneTextBox1.Text = _contactsplus._phone.Number.ToString();
                EmailtextBox1.Text = _contactsplus.Email;
                VKtextBox1.Text = _contactsplus.IDVk;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SecondNameTextBox1_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                _contactsplus.SecondName = SecondNameTextBox1.Text;
            }
            catch (Exception )
            {
                //MessageBox.Show(ex.Message, "Неверный ввод данных");
                SecondNameTextBox1.BackColor = Color.LightSalmon;
                i++;
            }
            if (i != 0)
            {
                SecondNameTextBox1.BackColor = Color.LightSalmon;
            }
            else
            {
                SecondNameTextBox1.BackColor = Color.White;
            }
        }

        private void NameTextBox1_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                _contactsplus.Name = NameTextBox1.Text;
            }
            catch (Exception )
            {
                //MessageBox.Show(ex.Message, "Неверный ввод данных");
                NameTextBox1.BackColor = Color.LightSalmon;
                i++;
            }
            if (i != 0)
            {
                NameTextBox1.BackColor = Color.LightSalmon;
            }
            else
            {
                NameTextBox1.BackColor = Color.White;
            }
        }

        private void BirthTimePicker1_ValueChanged(object sender, EventArgs e)
       {
            int i = 0;
            try
           {
                _contactsplus._birth = BirthTimePicker1.Value; 
            }
            catch (Exception)
            {
         //       //MessageBox.Show(ex.Message, "Неверный ввод данных");
                BirthTimePicker1.BackColor = Color.LightSalmon;
                i++;
            }
            if (i != 0)
            {
                BirthTimePicker1.BackColor = Color.LightSalmon;
            }
            else
            {
               BirthTimePicker1.BackColor = Color.White;
            }
        }

        private void PhoneTextBox1_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            int phone;
            try
            {
                int.TryParse(PhoneTextBox1.Text, out phone);
                _contactsplus._phone.Number = phone; 
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message, "Неверный ввод данных");
                PhoneTextBox1.BackColor = Color.LightSalmon;
                i++;
            }
            if (i != 0)
            {
                PhoneTextBox1.BackColor = Color.LightSalmon;
            }
            else
            {
                PhoneTextBox1.BackColor = Color.White;
            }
        }

        private void EmailtextBox1_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                _contactsplus.Email = EmailtextBox1.Text;
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message, "Неверный ввод данных");
                EmailtextBox1.BackColor = Color.LightSalmon;
                i++;
            }
            if (i != 0)
            {
                EmailtextBox1.BackColor = Color.LightSalmon;
            }
            else
            {
                EmailtextBox1.BackColor = Color.White;
            }
        }

        private void VKtextBox1_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                _contactsplus.IDVk = VKtextBox1.Text;
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message, "Неверный ввод данных");
                VKtextBox1.BackColor = Color.LightSalmon;
                i++;
            }
            if (i != 0)
            {
                VKtextBox1.BackColor = Color.LightSalmon;
            }
            else
            {
                VKtextBox1.BackColor = Color.White;
            }
        }
    }
}
