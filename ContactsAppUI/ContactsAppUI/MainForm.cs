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
    public partial class MainForm : Form
    {
        private readonly string _path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\ContactApp.txt";

        private Project _project = new Project();
        public MainForm()
        {
            InitializeComponent();
            BirthTimePicker.MaxDate = DateTime.Now;
            if (ProjectManager.LoadFromFile(_path) != null)
            {
                _project = ProjectManager.LoadFromFile(_path);
            }
            ShowListBox();
            ContactlistBox.Sorted = true;
            Birthday();
        }
        private void Birthday()
        {
            Project birth = Project.Birthday(_project, DateTime.Today);
            for (int i = 0; i != birth._contactslistone.Count; i++)
            {
                Birthdaylabel10.Text = Birthdaylabel10.Text + birth._contactslistone[i].SecondName + ". ";
            }
        }
        public void ShowListBox()
        {
            foreach (Contact t in _project._contactslistone)
            {
                ContactlistBox.Items.Add(t.SecondName);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        public List<Contact> _contactslistone = new List<Contact>();
        private void button1_Click(object sender, EventArgs e)
        {
            Add();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Edit();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Remove();
        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove();
        }
        private void Add()
        {
            {
                var form2 = new ContactForm();
                //  form2.Owner = this;
                //  form2.ShowDialog();
                var UpdatedDate = form2.Data;
                var i = form2.ShowDialog();
                if (i == DialogResult.OK)
                {

                        // ContactlistBox.Items.Add(_project._contactslistone[k].SecondName);
                        _project._contactslistone.Add(UpdatedDate._contactsplus);
                        ContactlistBox.Items.Add(UpdatedDate.TxtBox);
                    /*  _project._contactslistone.Add(UpdatedDate._contactsplus);
                      ContactlistBox.Items.Add(UpdatedDate.TxtBox);
                      _project.Sort(_project._contactslistone);
                      */
                }
               
                ProjectManager.SaveToFile(_project, _path);
                
            }
        }
        private void Edit()
        {
            {
                ContactForm form2 = new ContactForm();
                if (ContactlistBox.SelectedIndex == -1)
                {
                    return;
                }
                else
                {
                    form2.Data._contactsplus = _project._contactslistone[ContactlistBox.SelectedIndex];
                    form2.Data.TxtBox = _project._contactslistone[ContactlistBox.SelectedIndex].SecondName;
                    form2.ShowDialog();
                    var UpdatedDate = form2.Data;
                    _project._contactslistone.RemoveAt(ContactlistBox.SelectedIndex);
                    ContactlistBox.Items.RemoveAt(ContactlistBox.SelectedIndex);
                    _project._contactslistone.Add(UpdatedDate._contactsplus);
                    ContactlistBox.Items.Add(UpdatedDate.TxtBox);
                    NameTextBox.Text = UpdatedDate._contactsplus.Name;
                    SecondNameTextBox.Text = UpdatedDate._contactsplus.SecondName;
                    EmailTextBox.Text = UpdatedDate._contactsplus.Email;
                    VKTextBox.Text = UpdatedDate._contactsplus.IDVk;
                    BirthTimePicker.Value = UpdatedDate._contactsplus.Birth;
                    PhoneTextBox.Text = Convert.ToString(UpdatedDate._contactsplus.Phone.Number);
                    _project.Sort(_project._contactslistone);
                }
                ProjectManager.SaveToFile(_project, _path);
                
            }
        }
        private void Remove()
        {
            {
                var selectedIndex = ContactlistBox.SelectedIndex;
                if (selectedIndex == -1)
                {
                    return;
                }
                else
                {
                    var i = MessageBox.Show("Удалить этот контакт?", "Подтверждение", MessageBoxButtons.OKCancel);
                    if (i == DialogResult.OK)
                    {
                        _project._contactslistone.RemoveAt(ContactlistBox.SelectedIndex);
                        ContactlistBox.Items.RemoveAt(ContactlistBox.SelectedIndex);
                        NameTextBox.Clear();
                        SecondNameTextBox.Clear();
                        EmailTextBox.Clear();
                        PhoneTextBox.Clear();
                        VKTextBox.Clear();
                        BirthTimePicker.Value = BirthTimePicker.MaxDate;
                    }
                    ProjectManager.SaveToFile(_project, _path);
                }
            }
        }
        
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form3 = new AboutForm();
            form3.ShowDialog();
        }
        private void ContactlistBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                Remove();
            }
        }

        private void textBox_TextChanged_1(object sender, EventArgs e)
        {
            ContactlistBox.SelectedIndex = ContactlistBox.FindString(textBox.Text);
        }

        private void ContactlistBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            {
                if (ContactlistBox.SelectedIndex >= 0)
                {
                    Contact _contactsplus;
                    _contactsplus = _project._contactslistone[ContactlistBox.SelectedIndex];
                    NameTextBox.Text = _contactsplus.Name;
                    SecondNameTextBox.Text = _contactsplus.SecondName;
                    EmailTextBox.Text = _contactsplus.Email;
                    VKTextBox.Text = _contactsplus.IDVk;
                    BirthTimePicker.Value = _contactsplus.Birth;
                    PhoneTextBox.Text = Convert.ToString(_contactsplus.Phone.Number);
                }
                
            }
        }      
    }
}

