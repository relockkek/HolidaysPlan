using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HolidaysPlan
{
    public partial class EditPersonForm : Form
    {
        Person person;
        public EditPersonForm(Person person)
        {
            InitializeComponent();
            this.person = person;
            if (person.Id != 0)
            {
                СlosestTextBox.Text = person.FIO;
                DateTimePicker.Value = person.Birthdate;
                DescriptionTextBox.Text = person.Description;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            person.FIO = СlosestTextBox.Text;
            person.Birthdate = DateTimePicker.Value;
            person.Description = DescriptionTextBox.Text;

            if (person.Id == 0)
            {  
                DB.GetInstance().PersonAdd(person);
            }
            Close();
        }
    }
}
