namespace HolidaysPlan
{
    partial class HolidaysForm
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
            EditButton = new Button();
            AddButton = new Button();
            listView1 = new ListView();
            HolidayName = new ColumnHeader();
            Date = new ColumnHeader();
            SuspendLayout();
            // 
            // EditButton
            // 
            EditButton.Location = new Point(155, 178);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(147, 23);
            EditButton.TabIndex = 5;
            EditButton.Text = "Редактировать";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(12, 178);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(137, 23);
            AddButton.TabIndex = 4;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { HolidayName, Date });
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(290, 160);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // HolidayName
            // 
            HolidayName.Text = "Название";
            HolidayName.Width = 140;
            // 
            // Date
            // 
            Date.Text = "Дата праздника";
            Date.Width = 140;
            // 
            // HolidaysForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 214);
            Controls.Add(EditButton);
            Controls.Add(AddButton);
            Controls.Add(listView1);
            Name = "HolidaysForm";
            Text = "HolidaysForm";
            ResumeLayout(false);
        }

        #endregion

        private Button EditButton;
        private Button AddButton;
        private ListView listView1;
        private ColumnHeader HolidayName;
        private ColumnHeader Date;
    }
}