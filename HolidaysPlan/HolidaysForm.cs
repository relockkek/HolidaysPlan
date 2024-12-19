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
    public partial class HolidaysForm : Form
    {
        public HolidaysForm()
        {
            InitializeComponent();
            UpdateList();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Holiday holiday = new Holiday();
            EditHolidayForm editHolidayForm = new EditHolidayForm(holiday);
            editHolidayForm.ShowDialog();
            UpdateList();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var i = listView1.SelectedItems[0].Tag as Holiday;
                EditHolidayForm editHolidayForm = new EditHolidayForm(i);
                editHolidayForm.ShowDialog();
            }
            UpdateList();
        }

        public void UpdateList()
        {
            listView1.Items.Clear();
            foreach (Holiday holiday in DB.GetInstance().GetHoliday())
            {
                ListViewItem row = new ListViewItem();
                row.Text = holiday.Name;
                row.Tag = holiday;
                row.SubItems.Add(holiday.Date.ToString("D"));
                listView1.Items.Add(row);
            }
        }
    }
}
