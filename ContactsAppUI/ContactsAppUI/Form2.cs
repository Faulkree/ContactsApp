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
   
        private PhoneNumber _phone = new PhoneNumber();

        public Form2()
        {
            InitializeComponent();
            BirthTimePicker1.MaxDate = DateTime.Now;
           
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag;
            try
            {
               
               flag = true;
                _phone.Number = System.Int64.Parse(PhoneTextBox1.Text);
                _contactsplus.SecondName = SecondNameTextBox1.Text;
                _contactsplus.Name = NameTextBox1.Text;
                _contactsplus.Birth = BirthTimePicker1.Value;
                _contactsplus.Phone = _phone;
                _contactsplus.Email = EmailtextBox1.Text;
                _contactsplus.IDVk = VKtextBox1.Text;
                _data.TxtBox = _contactsplus.SecondName;
                _data._contactsplus = _contactsplus;
               

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Неверный ввод данных");
                flag = false;
            }

                if (flag == true)
            {
                this.Close();
                DialogResult = DialogResult.OK;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            var form1 = new Form1();
            if (main != null)
            {
                Data = null;
            }
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Data._contactsplus != null)
            {
                SecondNameTextBox1.Text = Data._contactsplus.SecondName;
                NameTextBox1.Text = Data._contactsplus.Name;
                EmailtextBox1.Text = Data._contactsplus.Email;
                VKtextBox1.Text = Data._contactsplus.IDVk;
                BirthTimePicker1.Value = Data._contactsplus.Birth;
                PhoneTextBox1.Text = Convert.ToString(Data._contactsplus.Phone.Number);
            }
            
        }
        public class DataMainForm
        {
            public string TxtBox;
            public Contact _contactsplus;
        }
        private DataMainForm _data = new DataMainForm();
        public DataMainForm Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
            }
        }
     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SecondNameTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contactsplus.SecondName = SecondNameTextBox1.Text;
                SecondNameTextBox1.BackColor = Color.White;
            }
            catch(Exception)
            {
                SecondNameTextBox1.BackColor = Color.LightSalmon;
            }
        }

        private void NameTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contactsplus.Name = NameTextBox1.Text;
                NameTextBox1.BackColor = Color.White;
            }
            catch (Exception)
            {
                NameTextBox1.BackColor = Color.LightSalmon;
            }
        }

        private void BirthTimePicker1_ValueChanged(object sender, EventArgs e)
       {
           
            
                try
                {
                    _contactsplus.Birth = BirthTimePicker1.Value;
                    BirthTimePicker1.BackColor = Color.White;
                }
                catch (Exception )
                {
                    BirthTimePicker1.BackColor = Color.LightSalmon;
                  
                }
            
            
             

        }

        private void PhoneTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void EmailtextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contactsplus.Email = EmailtextBox1.Text;
                EmailtextBox1.BackColor = Color.White;

            }
            catch (Exception)
            {
                EmailtextBox1.BackColor = Color.LightSalmon;
            }
        }

        private void VKtextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
              
                _contactsplus.IDVk = VKtextBox1.Text;
                VKtextBox1.BackColor = Color.White;
            }
            catch (Exception)
            {
                VKtextBox1.BackColor = Color.LightSalmon;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
