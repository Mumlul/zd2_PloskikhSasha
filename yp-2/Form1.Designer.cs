namespace yp_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.функцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиКонтактToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.red = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.find = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.удал = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.red.SuspendLayout();
            this.dob.SuspendLayout();
            this.find.SuspendLayout();
            this.удал.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(894, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(815, 852);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.Change);
            this.listBox1.DoubleClick += new System.EventHandler(this.Delete_contact);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.функцииToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1715, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // функцииToolStripMenuItem
            // 
            this.функцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьToolStripMenuItem,
            this.добавитьToolStripMenuItem,
            this.найтиКонтактToolStripMenuItem,
            this.сохранитьФайлToolStripMenuItem});
            this.функцииToolStripMenuItem.Name = "функцииToolStripMenuItem";
            this.функцииToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.функцииToolStripMenuItem.Text = "Функции";
            this.функцииToolStripMenuItem.MouseEnter += new System.EventHandler(this.Close);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // найтиКонтактToolStripMenuItem
            // 
            this.найтиКонтактToolStripMenuItem.Name = "найтиКонтактToolStripMenuItem";
            this.найтиКонтактToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.найтиКонтактToolStripMenuItem.Text = "Найти контакт";
            this.найтиКонтактToolStripMenuItem.Click += new System.EventHandler(this.найтиКонтактToolStripMenuItem_Click);
            // 
            // сохранитьФайлToolStripMenuItem
            // 
            this.сохранитьФайлToolStripMenuItem.Name = "сохранитьФайлToolStripMenuItem";
            this.сохранитьФайлToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сохранитьФайлToolStripMenuItem.Text = "Сохранить файл";
            this.сохранитьФайлToolStripMenuItem.Click += new System.EventHandler(this.сохранитьФайлToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // red
            // 
            this.red.Controls.Add(this.button1);
            this.red.Controls.Add(this.label3);
            this.red.Controls.Add(this.label2);
            this.red.Controls.Add(this.textBox2);
            this.red.Controls.Add(this.textBox1);
            this.red.Controls.Add(this.label1);
            this.red.Location = new System.Drawing.Point(13, 49);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(367, 355);
            this.red.TabIndex = 2;
            this.red.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "редактировать контакт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Edit_contact);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "номер контакта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя контакта";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(22, 166);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(321, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.Proverka);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(321, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "редактировать контакт";
            // 
            // dob
            // 
            this.dob.Controls.Add(this.button2);
            this.dob.Controls.Add(this.textBox4);
            this.dob.Controls.Add(this.textBox3);
            this.dob.Controls.Add(this.label4);
            this.dob.Controls.Add(this.label5);
            this.dob.Controls.Add(this.label6);
            this.dob.Location = new System.Drawing.Point(521, 49);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(367, 355);
            this.dob.TabIndex = 3;
            this.dob.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(323, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "добавить контакт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Dob_contact);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(29, 69);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(321, 22);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(29, 166);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(321, 22);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.Proverka2);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "номер контакта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Имя контакта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "добавить контакт";
            // 
            // find
            // 
            this.find.Controls.Add(this.label10);
            this.find.Controls.Add(this.textBox6);
            this.find.Controls.Add(this.label9);
            this.find.Controls.Add(this.label8);
            this.find.Controls.Add(this.comboBox1);
            this.find.Controls.Add(this.textBox5);
            this.find.Controls.Add(this.button3);
            this.find.Controls.Add(this.label7);
            this.find.Location = new System.Drawing.Point(521, 467);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(367, 355);
            this.find.TabIndex = 3;
            this.find.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(162, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "номер";
            this.label10.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(24, 179);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(323, 22);
            this.textBox6.TabIndex = 6;
            this.textBox6.Visible = false;
            this.textBox6.TextChanged += new System.EventHandler(this.Prov);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(171, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "имя";
            this.label9.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(134, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Способ поиска";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "По имени",
            "По номеру"});
            this.comboBox1.Location = new System.Drawing.Point(25, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(322, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.Parameter_selection);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(25, 179);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(323, 22);
            this.textBox5.TabIndex = 2;
            this.textBox5.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(25, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(323, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Поиск";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Search);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(131, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Поиск контакта";
            // 
            // удал
            // 
            this.удал.Controls.Add(this.button4);
            this.удал.Controls.Add(this.textBox7);
            this.удал.Controls.Add(this.label11);
            this.удал.Location = new System.Drawing.Point(13, 467);
            this.удал.Name = "удал";
            this.удал.Size = new System.Drawing.Size(367, 355);
            this.удал.TabIndex = 4;
            this.удал.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(22, 308);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(322, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(22, 45);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(321, 22);
            this.textBox7.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(149, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "label11";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1715, 880);
            this.Controls.Add(this.удал);
            this.Controls.Add(this.find);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.red);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Loading_the_app);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.red.ResumeLayout(false);
            this.red.PerformLayout();
            this.dob.ResumeLayout(false);
            this.dob.PerformLayout();
            this.find.ResumeLayout(false);
            this.find.PerformLayout();
            this.удал.ResumeLayout(false);
            this.удал.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem функцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиКонтактToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.Panel red;
        private System.Windows.Forms.Panel dob;
        private System.Windows.Forms.Panel find;
        private System.Windows.Forms.Panel удал;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label11;
    }
}

