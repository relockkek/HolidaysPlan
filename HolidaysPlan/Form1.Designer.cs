
namespace HolidaysPlan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            lklpToolStripMenuItem = new ToolStripMenuItem();
            праздникиToolStripMenuItem = new ToolStripMenuItem();
            историяToolStripMenuItem = new ToolStripMenuItem();
            планировщикПодароковToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            СlosestTextBox = new TextBox();
            textBox3 = new TextBox();
            PresentListBox = new ListBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox2 = new TextBox();
            PersonListBox = new ListBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { менюToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lklpToolStripMenuItem, праздникиToolStripMenuItem, историяToolStripMenuItem, планировщикПодароковToolStripMenuItem });
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(55, 20);
            менюToolStripMenuItem.Text = "Меню";
            // 
            // lklpToolStripMenuItem
            // 
            lklpToolStripMenuItem.Name = "lklpToolStripMenuItem";
            lklpToolStripMenuItem.Size = new Size(223, 22);
            lklpToolStripMenuItem.Text = "Персоны";
            lklpToolStripMenuItem.Click += lklpToolStripMenuItem_Click;
            // 
            // праздникиToolStripMenuItem
            // 
            праздникиToolStripMenuItem.Name = "праздникиToolStripMenuItem";
            праздникиToolStripMenuItem.Size = new Size(223, 22);
            праздникиToolStripMenuItem.Text = "Праздники";
            праздникиToolStripMenuItem.Click += праздникиToolStripMenuItem_Click;
            // 
            // историяToolStripMenuItem
            // 
            историяToolStripMenuItem.Name = "историяToolStripMenuItem";
            историяToolStripMenuItem.Size = new Size(223, 22);
            историяToolStripMenuItem.Text = "История";
            историяToolStripMenuItem.Click += историяToolStripMenuItem_Click;
            // 
            // планировщикПодароковToolStripMenuItem
            // 
            планировщикПодароковToolStripMenuItem.Name = "планировщикПодароковToolStripMenuItem";
            планировщикПодароковToolStripMenuItem.Size = new Size(223, 22);
            планировщикПодароковToolStripMenuItem.Text = "Планировщик подароков";
            планировщикПодароковToolStripMenuItem.Click += планировщикПодароковToolStripMenuItem_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(12, 77);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(301, 16);
            textBox1.TabIndex = 1;
            textBox1.Text = "Близжайший праздник";
            // 
            // СlosestTextBox
            // 
            СlosestTextBox.Location = new Point(161, 74);
            СlosestTextBox.Name = "СlosestTextBox";
            СlosestTextBox.ReadOnly = true;
            СlosestTextBox.Size = new Size(243, 23);
            СlosestTextBox.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Control;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(12, 141);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(301, 16);
            textBox3.TabIndex = 3;
            textBox3.Text = "Список подарков";
            // 
            // PresentListBox
            // 
            PresentListBox.FormattingEnabled = true;
            PresentListBox.ItemHeight = 15;
            PresentListBox.Location = new Point(12, 163);
            PresentListBox.Name = "PresentListBox";
            PresentListBox.Size = new Size(301, 94);
            PresentListBox.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(161, 282);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(152, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Control;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(12, 285);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(301, 16);
            textBox5.TabIndex = 7;
            textBox5.Text = "Сумма подарков";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(405, 141);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(301, 16);
            textBox2.TabIndex = 5;
            textBox2.Text = "Список людей без подарка";
            // 
            // PersonListBox
            // 
            PersonListBox.FormattingEnabled = true;
            PersonListBox.ItemHeight = 15;
            PersonListBox.Location = new Point(405, 163);
            PersonListBox.Name = "PersonListBox";
            PersonListBox.Size = new Size(301, 94);
            PersonListBox.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(PersonListBox);
            Controls.Add(textBox2);
            Controls.Add(PresentListBox);
            Controls.Add(textBox3);
            Controls.Add(СlosestTextBox);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem lklpToolStripMenuItem;
        private ToolStripMenuItem праздникиToolStripMenuItem;
        private ToolStripMenuItem историяToolStripMenuItem;
        private TextBox textBox1;
        private TextBox СlosestTextBox;
        private TextBox textBox3;
        private ListBox PresentListBox;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox2;
        private ListBox PersonListBox;
        private ToolStripMenuItem планировщикПодароковToolStripMenuItem;
    }
}
