using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HolidaysPlan
{
    public partial class EditHolidayForm : Form
    {
        Holiday holiday;
        public EditHolidayForm(Holiday holiday)
        {
            InitializeComponent();
            this.holiday = holiday;
            if (holiday.Id != 0)
            {
                СlosestTextBox.Text = holiday.Name;
                DateTimePicker.Value = holiday.Date;
                DescriptionTextBox.Text = holiday.Description;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            holiday.Name = СlosestTextBox.Text;
            holiday.Date = DateTimePicker.Value;
            holiday.Description = DescriptionTextBox.Text;

            if (holiday.Id == 0)
            {
                DB.GetInstance().HolidayAdd(holiday);
            }
            Close();

        }
        
    }
}
