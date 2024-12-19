namespace HolidaysPlan
{
    partial class PersonsForm
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
            BirthDay = new ColumnHeader();
            AddButton = new Button();
            EditButton = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { FIO, BirthDay });
            listView1.Location = new Point(12, 19);
            listView1.Name = "listView1";
            listView1.Size = new Size(286, 157);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // FIO
            // 
            FIO.Text = "ФИО";
            FIO.Width = 140;
            // 
            // BirthDay
            // 
            BirthDay.Text = "Дата рождения";
            BirthDay.Width = 140;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(12, 182);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(139, 23);
            AddButton.TabIndex = 1;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(157, 182);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(141, 23);
            EditButton.TabIndex = 2;
            EditButton.Text = "Редактировать";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // PersonsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 217);
            Controls.Add(EditButton);
            Controls.Add(AddButton);
            Controls.Add(listView1);
            Name = "PersonsForm";
            Text = "PersonsForm";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader FIO;
        private ColumnHeader BirthDay;
        private Button AddButton;
        private Button EditButton;
    }
}