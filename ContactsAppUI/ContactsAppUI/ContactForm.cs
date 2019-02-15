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
    public partial class ContactForm : Form
    {
        private Contact _contactsplus = new Contact();
   
        private PhoneNumber _phone = new PhoneNumber();
        public ContactForm()
        {
            InitializeComponent();
            BirthTimePicker.MaxDate = DateTime.Now;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
            if (Data._contactsplus != null)
            {
                SecondNameTextBox.Text = Data._contactsplus.SecondName;
                NameTextBox.Text = Data._contactsplus.Name;
                EmailtextBox.Text = Data._contactsplus.Email;
                VKtextBox.Text = Data._contactsplus.IDVk;
                BirthTimePicker.Value = Data._contactsplus.Birth;
                PhoneTextBox.Text = Convert.ToString(Data._contactsplus.Phone.Number);
            }
           
        }
        public class DataForm
        {
            public string TxtBox;
            public Contact _contactsplus;
        }
        private DataForm _data = new DataForm();
        public DataForm Data
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
        private void button1_Click_1(object sender, EventArgs e)
        {
            Add();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Cancel();
        }
        private void Add()
        {
            bool flag;
            try
            {

                     flag = true;
                    _phone.Number = System.Int64.Parse(PhoneTextBox.Text);
                    _contactsplus.SecondName = SecondNameTextBox.Text;
                    _contactsplus.Name = NameTextBox.Text;
                    _contactsplus.Birth = BirthTimePicker.Value;
                    _contactsplus.Phone = _phone;
                    _contactsplus.Email = EmailtextBox.Text;
                    _contactsplus.IDVk = VKtextBox.Text;
                    _data.TxtBox = _contactsplus.SecondName;
                    _data._contactsplus = _contactsplus;
                
              
            }
            catch (Exception ex)
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
        private void Cancel()
        {
            MainForm main = this.Owner as MainForm;
            var form1 = new MainForm();
            if (main != null)
            {
                Data = null;
            }
            this.Close();
        }
        private void SecondNameTextBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                _contactsplus.SecondName = SecondNameTextBox.Text;
                SecondNameTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                SecondNameTextBox.BackColor = Color.LightSalmon;
            }
        }
        private void NameTextBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                _contactsplus.Name = NameTextBox.Text;
                NameTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                NameTextBox.BackColor = Color.LightSalmon;
            }
        }
        private void PhoneTextBox_TextChanged_1(object sender, EventArgs e)
        {
            long number;
            try
            {
                long.TryParse(PhoneTextBox.Text, out number);
                _contactsplus.Phone.Number = number;
                PhoneTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                PhoneTextBox.BackColor = Color.LightSalmon;
            }
        }
        private void EmailtextBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                _contactsplus.Email = EmailtextBox.Text;
                EmailtextBox.BackColor = Color.White;

            }
            catch (Exception)
            {
                EmailtextBox.BackColor = Color.LightSalmon;
            }
        }
        private void VKtextBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                _contactsplus.IDVk = VKtextBox.Text;
                VKtextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                VKtextBox.BackColor = Color.LightSalmon;
            }
        }

        
    }
}