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
       private Project _project;
        public Form1()
        {
            InitializeComponent();
            _project = ProjectManager.Deserialization(ProjectManager._path);
            if (_project != null)
            {
                int i = 0;
                while (i != _project._contactslistone.Count)
                {
                    ContactlistBox1.Items.Add(_project._contactslistone[i].SecondName);
                    i++;
                }


            }
            else
            {
                _project = new Project();
            }
           // Project birth = Project.Birthday(_project, DateTime.Today);
           // for (int i = 0; i != birth._contactslistone.Count; i++)
          //  {
           //     BirthdaySurnameLabel.Text = BirthdaySurnameLabel.Text + birth.Contacts[i].SecondName + ". ";
          //  }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void Add()
        {
            var newForm = new Form2();
            var i = newForm.ShowDialog();
            if (i == DialogResult.OK)
            {
                var Contact = newForm.Contactsplus;
                _project._contactslistone.Add(Contact);
                _project = Project.Sort(_project);
                ContactlistBox1.Items.Add(Contact.SecondName);
                for (int k = 0; k != _project._contactslistone.Count - 1; k++)
                {
                    ContactlistBox1.Items.RemoveAt(0);
                }
                for (int k = 0; k != _project._contactslistone.Count; k++)
                {
                    ContactlistBox1.Items.Add(_project._contactslistone[k].SecondName);
                }
                ProjectManager.Serialization(_project, ProjectManager._path);
            }
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
             Add();
          
        }

        private void Edit()
        {
            var selectedIndex = ContactlistBox1.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("Выберите запись для редактирования", "Отсутствие записи");
            }
            else
            {
                var selectedContact = _project._contactslistone[selectedIndex];
                var newForm = new Form2();
                newForm.Contactsplus = selectedContact;
                var i = newForm.ShowDialog();
                if (i == DialogResult.OK)
                {
                    var updatedContact = newForm.Contactsplus;
                    _project._contactslistone.Insert(selectedIndex, updatedContact);
                    ContactlistBox1.Items.Insert(selectedIndex, updatedContact.SecondName);
                    _project._contactslistone.RemoveAt(selectedIndex + 1);
                    ContactlistBox1.Items.RemoveAt(selectedIndex + 1);
                    _project = Project.Sort(_project);
                    for (int k = 0; k != _project._contactslistone.Count; k++)
                    {
                        ContactlistBox1.Items.RemoveAt(0);
                    }
                    for (int k = 0; k != _project._contactslistone.Count; k++)
                    {
                        ContactlistBox1.Items.Add(_project._contactslistone[k].SecondName);
                    }
                    ProjectManager.Serialization(_project, ProjectManager._path);
                }
            }
        }
        /// <summary>
        /// Переключение между контактами из списка и вывод выбранного контакта в левой панели
        /// </summary>
        private void ContactlistBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = ContactlistBox1.SelectedIndex;
            if (selectedIndex >= 0)
            {


                Contact contact = _project._contactslistone[selectedIndex];
                SecondNameTextBox1.Text = contact.SecondName;
                NameTextBox1.Text = contact.Name;
                BirthTimePicker1.Value = contact.Birth;
                PhoneTextBox1.Text = contact._phone.Number.ToString();
                EmailTextBox1.Text = contact.Email;
                VKTextBox1.Text = contact.IDVk;
            }

            else
            {
                SecondNameTextBox1.Text = "";
                NameTextBox1.Text = "";
                BirthTimePicker1.Value = DateTime.Today;
                PhoneTextBox1.Text = "";
                EmailTextBox1.Text = "";
                VKTextBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit();
        }
        private void Remove()
        {
            var selectedIndex = ContactlistBox1.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("Выберите запись для удаления", "Отсутствие записи");
            }
            else
            {
                var i = MessageBox.Show("Удалить эту запись?", "Подтверждение", MessageBoxButtons.OKCancel);
                if (i == DialogResult.OK)
                {
                    _project._contactslistone.RemoveAt(selectedIndex);
                    ContactlistBox1.Items.RemoveAt(selectedIndex);
                    ProjectManager.Serialization(_project, ProjectManager._path);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Remove();
        }
    }
}

