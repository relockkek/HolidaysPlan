namespace HolidaysPlan
{
    partial class EditPersonForm
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
            SaveButton = new Button();
            DateTimePicker = new DateTimePicker();
            BirthDayTextBox = new TextBox();
            СlosestTextBox = new TextBox();
            FIONewPersonTextBox = new TextBox();
            textBox1 = new TextBox();
            DescriptionTextBox = new TextBox();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(226, 157);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(85, 23);
            SaveButton.TabIndex = 16;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // DateTimePicker
            // 
            DateTimePicker.Location = new Point(130, 64);
            DateTimePicker.Name = "DateTimePicker";
            DateTimePicker.Size = new Size(181, 23);
            DateTimePicker.TabIndex = 15;
            // 
            // BirthDayTextBox
            // 
            BirthDayTextBox.BackColor = SystemColors.Control;
            BirthDayTextBox.BorderStyle = BorderStyle.None;
            BirthDayTextBox.Location = new Point(21, 67);
            BirthDayTextBox.Name = "BirthDayTextBox";
            BirthDayTextBox.ReadOnly = true;
            BirthDayTextBox.Size = new Size(301, 16);
            BirthDayTextBox.TabIndex = 14;
            BirthDayTextBox.Text = "День рождения";
            // 
            // СlosestTextBox
            // 
            СlosestTextBox.Location = new Point(68, 25);
            СlosestTextBox.Name = "СlosestTextBox";
            СlosestTextBox.Size = new Size(243, 23);
            СlosestTextBox.TabIndex = 13;
            // 
            // FIONewPersonTextBox
            // 
            FIONewPersonTextBox.BackColor = SystemColors.Control;
            FIONewPersonTextBox.BorderStyle = BorderStyle.None;
            FIONewPersonTextBox.Location = new Point(21, 29);
            FIONewPersonTextBox.Name = "FIONewPersonTextBox";
            FIONewPersonTextBox.ReadOnly = true;
            FIONewPersonTextBox.Size = new Size(301, 16);
            FIONewPersonTextBox.TabIndex = 12;
            FIONewPersonTextBox.Text = "ФИО";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(21, 99);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(301, 16);
            textBox1.TabIndex = 17;
            textBox1.Text = "Описание";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(95, 96);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(216, 46);
            DescriptionTextBox.TabIndex = 18;
            // 
            // EditPersonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 205);
            Controls.Add(DescriptionTextBox);
            Controls.Add(textBox1);
            Controls.Add(SaveButton);
            Controls.Add(DateTimePicker);
            Controls.Add(BirthDayTextBox);
            Controls.Add(СlosestTextBox);
            Controls.Add(FIONewPersonTextBox);
            Name = "EditPersonForm";
            Text = "EditPersonForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SaveButton;
        private DateTimePicker DateTimePicker;
        private TextBox BirthDayTextBox;
        private TextBox СlosestTextBox;
        private TextBox FIONewPersonTextBox;
        private TextBox textBox1;
        private TextBox DescriptionTextBox;
    }
}