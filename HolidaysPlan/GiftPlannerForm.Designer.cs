namespace HolidaysPlan
{
    partial class GiftPlannerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            FIO = new ColumnHeader();
            Holiday = new ColumnHeader();
            GiftName = new ColumnHeader();
            GiftCost = new ColumnHeader();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { FIO, Holiday, GiftName, GiftCost });
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(556, 280);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // FIO
            // 
            FIO.Text = "ФИО";
            FIO.Width = 140;
            // 
            // Holiday
            // 
            Holiday.Text = "Праздники";
            Holiday.Width = 120;
            // 
            // GiftName
            // 
            GiftName.Text = "Название подарка";
            GiftName.Width = 140;
            // 
            // GiftCost
            // 
            GiftCost.Text = "Стоимость подарка";
            GiftCost.Width = 150;
            // 
            // GiftPlannerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Name = "GiftPlannerForm";
            Text = "GiftPlannerForm";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader FIO;
        private ColumnHeader Holiday;
        private ColumnHeader GiftName;
        private ColumnHeader GiftCost;
    }
}