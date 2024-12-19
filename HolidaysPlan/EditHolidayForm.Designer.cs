namespace HolidaysPlan
{
    partial class EditHolidayForm
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
            DescriptionTextBox = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(222, 155);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(85, 23);
            SaveButton.TabIndex = 22;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // DateTimePicker
            // 
            DateTimePicker.Location = new Point(126, 56);
            DateTimePicker.Name = "DateTimePicker";
            DateTimePicker.Size = new Size(181, 23);
            DateTimePicker.TabIndex = 21;
            // 
            // BirthDayTextBox
            // 
            BirthDayTextBox.BackColor = SystemColors.Control;
            BirthDayTextBox.BorderStyle = BorderStyle.None;
            BirthDayTextBox.Location = new Point(17, 59);
            BirthDayTextBox.Name = "BirthDayTextBox";
            BirthDayTextBox.ReadOnly = true;
            BirthDayTextBox.Size = new Size(301, 16);
            BirthDayTextBox.TabIndex = 20;
            BirthDayTextBox.Text = "Дата праздника";
            // 
            // СlosestTextBox
            // 
            СlosestTextBox.Location = new Point(80, 17);
            СlosestTextBox.Name = "СlosestTextBox";
            СlosestTextBox.Size = new Size(227, 23);
            СlosestTextBox.TabIndex = 19;
            // 
            // FIONewPersonTextBox
            // 
            FIONewPersonTextBox.BackColor = SystemColors.Control;
            FIONewPersonTextBox.BorderStyle = BorderStyle.None;
            FIONewPersonTextBox.Location = new Point(17, 21);
            FIONewPersonTextBox.Name = "FIONewPersonTextBox";
            FIONewPersonTextBox.ReadOnly = true;
            FIONewPersonTextBox.Size = new Size(301, 16);
            FIONewPersonTextBox.TabIndex = 18;
            FIONewPersonTextBox.Text = "Название";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(91, 94);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(216, 46);
            DescriptionTextBox.TabIndex = 24;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(17, 97);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(301, 16);
            textBox1.TabIndex = 23;
            textBox1.Text = "Описание";
            // 
            // EditHolidayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 195);
            Controls.Add(DescriptionTextBox);
            Controls.Add(textBox1);
            Controls.Add(SaveButton);
            Controls.Add(DateTimePicker);
            Controls.Add(BirthDayTextBox);
            Controls.Add(СlosestTextBox);
            Controls.Add(FIONewPersonTextBox);
            Name = "EditHolidayForm";
            Text = "EditHolidayForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveButton;
        private DateTimePicker DateTimePicker;
        private TextBox BirthDayTextBox;
        private TextBox СlosestTextBox;
        private TextBox FIONewPersonTextBox;
        private TextBox DescriptionTextBox;
        private TextBox textBox1;
    }
}