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
    public partial class Form1 : Form
    {
        private readonly string _path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\ContactApp.txt";

        private Project _project = new Project();
        public Form1()
        {
            InitializeComponent();
            BirthTimePicker1.MaxDate = DateTime.Now;
            if (ProjectManager.LoadFromFile(_path) != null)
            {
                _project = ProjectManager.LoadFromFile(_path);
            }

            ShowListBox();
         
        }
        public void ShowListBox()
        {
            foreach (Contact t in _project._contactslistone)
            {
                ContactlistBox1.Items.Add(t.Name);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
        public List<Contact> _contactslistone = new List<Contact>();
    
        private void label6_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            {
                var form2 = new Form2();
                form2.Owner = this;
                form2.ShowDialog();
                var UpdatedDate = form2.Data;

                if (UpdatedDate != null)
                {
                    _project._contactslistone.Add(UpdatedDate._contactsplus);

                    ContactlistBox1.Items.Add(UpdatedDate.TxtBox);
                }
                ProjectManager.SaveToFile(_project, _path);
            }
        }
      
        private void ContactlistBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
              if (ContactlistBox1.SelectedIndex >= 0)
              {
              Contact _contactsplus;
             _contactsplus = _project._contactslistone[ContactlistBox1.SelectedIndex];
             NameTextBox1.Text = _contactsplus.Name;
             SecondNameTextBox1.Text = _contactsplus.SecondName;
             EmailTextBox1.Text = _contactsplus.Email;
             VKTextBox1.Text = _contactsplus.IDVk;
             BirthTimePicker1.Value = _contactsplus.Birth;
             PhoneTextBox1.Text = Convert.ToString(_contactsplus.Phone.Number);
              } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                Form2 form2 = new Form2();
                if (ContactlistBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Выберите контакт для редактирования", "Отсутствие контакта");
                }
                else
                {
                    form2.Data._contactsplus = _project._contactslistone[ContactlistBox1.SelectedIndex];
                    form2.Data.TxtBox = _project._contactslistone[ContactlistBox1.SelectedIndex].SecondName;
                    form2.ShowDialog();
                    var UpdatedDate = form2.Data;
                    _project._contactslistone.RemoveAt(ContactlistBox1.SelectedIndex);
                    ContactlistBox1.Items.RemoveAt(ContactlistBox1.SelectedIndex);
                    _project._contactslistone.Add(UpdatedDate._contactsplus);
                    ContactlistBox1.Items.Add(UpdatedDate.TxtBox);
                    NameTextBox1.Text = UpdatedDate._contactsplus.Name;
                    SecondNameTextBox1.Text = UpdatedDate._contactsplus.SecondName;
                    EmailTextBox1.Text = UpdatedDate._contactsplus.Email;
                    VKTextBox1.Text = UpdatedDate._contactsplus.IDVk;
                    BirthTimePicker1.Value = UpdatedDate._contactsplus.Birth;
                    PhoneTextBox1.Text = Convert.ToString(UpdatedDate._contactsplus.Phone.Number);

                }
                ProjectManager.SaveToFile(_project, _path);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            {
                var selectedIndex = ContactlistBox1.SelectedIndex;
                if (selectedIndex == -1)
                {
                    MessageBox.Show("Выберите контакт для удаления ", "Отсутствие контакта");
                }
                else
                {
                    var i = MessageBox.Show("Удалить этот контакт?", "Подтверждение", MessageBoxButtons.OKCancel);
                    if (i == DialogResult.OK)
                    {
                        _project._contactslistone.RemoveAt(ContactlistBox1.SelectedIndex);
                        ContactlistBox1.Items.RemoveAt(ContactlistBox1.SelectedIndex);
                        NameTextBox1.Clear();
                        SecondNameTextBox1.Clear();
                        EmailTextBox1.Clear();
                        PhoneTextBox1.Clear();
                        VKTextBox1.Clear();
                        BirthTimePicker1.Value = BirthTimePicker1.MaxDate;

                    }
                    ProjectManager.SaveToFile(_project, _path);
                }
            }
        }
      
        private void NameTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void VKTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Owner = this;
            form2.ShowDialog();
            var UpdatedDate = form2.Data;
            if (UpdatedDate != null)
            {
                _contactslistone.Add(UpdatedDate._contactsplus);
                ContactlistBox1.Items.Add(UpdatedDate.TxtBox);
            }
         
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
       
            if (ContactlistBox1.SelectedIndex >= 0)
            {
                form2.Data._contactsplus = _contactslistone[ContactlistBox1.SelectedIndex];
                form2.Data.TxtBox = _contactslistone[ContactlistBox1.SelectedIndex].SecondName;
                form2.ShowDialog();
                var UpdatedDate = form2.Data;
                _contactslistone.RemoveAt(ContactlistBox1.SelectedIndex);
                ContactlistBox1.Items.RemoveAt(ContactlistBox1.SelectedIndex);
                _contactslistone.Add(UpdatedDate._contactsplus);
                ContactlistBox1.Items.Add(UpdatedDate.TxtBox);
                NameTextBox1.Text = UpdatedDate._contactsplus.Name;
                SecondNameTextBox1.Text = UpdatedDate._contactsplus.SecondName;
                EmailTextBox1.Text = UpdatedDate._contactsplus.Email;
                VKTextBox1.Text = UpdatedDate._contactsplus.IDVk;
                BirthTimePicker1.Value = UpdatedDate._contactsplus.Birth;
                PhoneTextBox1.Text = Convert.ToString(UpdatedDate._contactsplus.Phone.Number);
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var i = MessageBox.Show("Удалить этот контакт?", "Подтверждение", MessageBoxButtons.OKCancel);
            if (i == DialogResult.OK)
            {
                _contactslistone.RemoveAt(ContactlistBox1.SelectedIndex);
                ContactlistBox1.Items.RemoveAt(ContactlistBox1.SelectedIndex);
                NameTextBox1.Clear();
                SecondNameTextBox1.Clear();
                EmailTextBox1.Clear();
                PhoneTextBox1.Clear();
                VKTextBox1.Clear();
                BirthTimePicker1.Value = BirthTimePicker1.MaxDate;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form3 = new Form3();
            form3.ShowDialog();
        }

        private void SecondNameTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
    }
}

