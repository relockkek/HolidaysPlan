using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolidaysPlan
{
    public partial class PersonsForm : Form
    {

        public PersonsForm()
        {
            InitializeComponent();
            UpdateList();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            EditPersonForm editPersonForm = new EditPersonForm(person);
            editPersonForm.ShowDialog();
            UpdateList();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var i = listView1.SelectedItems[0].Tag as Person;
                EditPersonForm editPersonForm = new EditPersonForm(i);
                editPersonForm.ShowDialog();
            }
            UpdateList();
        }
        public void UpdateList()
        {
            listView1.Items.Clear();
            foreach (Person person in DB.GetInstance().GetPerson())
            {
                ListViewItem row = new ListViewItem();
                row.Text = person.FIO;
                row.Tag = person;
                row.SubItems.Add(person.Birthdate.ToString("D"));
                listView1.Items.Add(row);
            }
        }

        
    }
}
