namespace HolidaysPlan
{
    partial class HistoryForm
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
            HistoryComboBox = new ComboBox();
            textBox1 = new TextBox();
            listView1 = new ListView();
            FIO = new ColumnHeader();
            Gifts = new ColumnHeader();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // HistoryComboBox
            // 
            HistoryComboBox.FormattingEnabled = true;
            HistoryComboBox.Location = new Point(185, 12);
            HistoryComboBox.Name = "HistoryComboBox";
            HistoryComboBox.Size = new Size(181, 23);
            HistoryComboBox.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(12, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 16);
            textBox1.TabIndex = 1;
            textBox1.Text = "Прошедшие праздники";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { FIO, Gifts });
            listView1.Location = new Point(12, 53);
            listView1.Name = "listView1";
            listView1.Size = new Size(566, 143);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // FIO
            // 
            FIO.Text = "ФИО";
            FIO.Width = 200;
            // 
            // Gifts
            // 
            Gifts.Text = "Подарки";
            Gifts.Width = 362;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(387, 15);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(167, 16);
            textBox2.TabIndex = 3;
            textBox2.Text = "Стоимость";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(464, 12);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(114, 23);
            textBox3.TabIndex = 4;
            // 
            // HistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 213);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(listView1);
            Controls.Add(textBox1);
            Controls.Add(HistoryComboBox);
            Name = "HistoryForm";
            Text = "HistoryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox HistoryComboBox;
        private TextBox textBox1;
        private ListView listView1;
        private ColumnHeader FIO;
        private ColumnHeader Gifts;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}