namespace HolidaysPlan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Update();
        }

        private void lklpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonsForm personsForm = new PersonsForm();
            personsForm.ShowDialog();
            Update();
        }

        private void праздникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HolidaysForm holidaysForm = new HolidaysForm();
            holidaysForm.ShowDialog();
            Update();
        }

        private void историяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            historyForm.ShowDialog();
            Update();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.GetInstance().Save();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Update();
            DB.GetInstance().Load();
        }

        private void планировщикПодароковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiftPlannerForm giftPlannerForm = new GiftPlannerForm();
            giftPlannerForm.ShowDialog();
        }
        public void Update()
        {
            List<Holiday> holiday = DB.GetInstance().GetHoliday();
            DateTime currentDate = DateTime.Now;
            var nextHoliday = holiday.Where(h => h.Date > currentDate).OrderBy(h => h.Date).FirstOrDefault();
            if (nextHoliday != null)
            {
                СlosestTextBox.Text = nextHoliday.Date.ToString("D");
            }
            else
            {
                СlosestTextBox.Text = "Близжайших праздников нет";
            }
        }
    }
}
