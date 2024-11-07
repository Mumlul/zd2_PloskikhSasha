using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;



using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace yp_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        PhoneBook phoneBook = new PhoneBook();

        //обнавляет элементы в листбокс
        public void UpdateList()
        {
            try
            {
                listBox1.Items.Clear();
                foreach (var contact in phoneBook.GetAllContacts())
                {
                    listBox1.Items.Add($"{contact.Name}; {contact.Phone}");
                }
            }
            catch (Exception ex)
            {

            }
           
        }

        //Проверка правильности ввода номера
        private void Proverka(object sender, EventArgs e)
        {
            Form1.Proverka(textBox2,textBox2,this.Proverka);
        }

        //Основной метод проверки ввода номера
        public static void Proverka(TextBox inputTextBox, TextBox outputTextBox, EventHandler eventHandler)
        {
            try
            {
                outputTextBox.TextChanged -= eventHandler;
                string input = Regex.Replace(inputTextBox.Text, @"[^\d]", "");
                if (input.Length > 10)
                {
                    input = input.Substring(0, 10);
                }
                if (input.Length > 0)
                {
                    if (input.Length > 3)
                    {
                        input = $"({input.Substring(0, 3)}){input.Substring(3)}";
                    }
                    if (input.Length > 8)
                    {
                        input = $"{input.Substring(0, 8)}-{input.Substring(8)}";
                    }
                    if (input.Length > 11)
                    {
                        input = $"{input.Substring(0, 11)}-{input.Substring(11)}";
                    }
                }
                outputTextBox.Text = input;
                outputTextBox.SelectionStart = outputTextBox.Text.Length;
                outputTextBox.TextChanged += eventHandler;
            }
            catch (Exception ex)
            {

            }
           
        }

        //Проверка правильности ввода номера
        private void Proverka2(object sender, EventArgs e)
        {
            Form1.Proverka(textBox3, textBox3, this.Proverka2);
        }


        //Добавление контакта
        private void Dob_contact(object sender, EventArgs e)
        {
            try
            {
                string name = textBox4.Text;
                string number = textBox3.Text;

                MessageBox.Show(phoneBook.AddContact(name, number));
                UpdateList();
                dob.Visible = false;
            }
            catch (Exception ex)
            {

            }
            
        }

        //Изменение контакта
        private void Edit_contact(object sender, EventArgs e)
        {
            try
            {
                int index = -1;
                string name = textBox1.Text;
                string number = textBox2.Text;
                index = listBox1.SelectedIndex;
                MessageBox.Show(phoneBook.ChangeContact(name, number, index));
                UpdateList();
                red.Visible = false;
            }
            catch (Exception ex)
            {

            }
           
        }

        //Занесение данных при загрузке формы
        private void Loading_the_app(object sender, EventArgs e)
        {
            PhoneBookLoader.Load(phoneBook, "contacts.csv");
            UpdateList();
        }

        //Поиск контакта
        private void Search(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem.ToString() == "По имени")
                {
                    string name = textBox5.Text;
                    var foundContacts = phoneBook.GetAllContacts().Where(c => c.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
                    if (foundContacts.Any())
                    {
                        string message = "Найденные контакты:\n" + string.Join("\n", foundContacts.Select(c => $"{c.Name}, {c.Phone}"));
                        MessageBox.Show(message, "Результаты поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Контакты не найдены.", "Результаты поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
                else if (comboBox1.SelectedItem.ToString() == "По номеру")
                {
                    string phone = textBox6.Text;
                    var foundContacts = phoneBook.GetAllContacts().Where(c => c.Phone == phone).ToList();
                    if (foundContacts.Any())
                    {
                        string message = "Найденные контакты:\n" + string.Join("\n", foundContacts.Select(c => $"{c.Name}, {c.Phone}"));
                        MessageBox.Show(message, "Результаты поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Контакты не найдены.", "Результаты поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            
        }

        //выбор переменной для поиска
        private void Parameter_selection(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem.ToString() == "По имени")
                {
                    textBox5.Visible = true;
                    label9.Visible = true;
                    textBox6.Visible = false;
                    label10.Visible = false;
                }
                else if (comboBox1.SelectedItem.ToString() == "По номеру")
                {
                    textBox6.Visible = true;
                    label10.Visible = true;
                    textBox5.Visible = false;
                    label9.Visible = false;
                }
            }
            catch (Exception ex)
            {

            }
            
        }

        //Открытие панели редактирования контакта
        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            red.Visible = true;
        }

        //открытие панели добавления контакта
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dob.Visible = true;
        }

        //открытие панели поиска
        private void найтиКонтактToolStripMenuItem_Click(object sender, EventArgs e)
        {
            find.Visible = true;
        }

        //Закрытиевсех панелей
        private void Close(object sender, EventArgs e)
        {
            try
            {
                foreach (Control control in this.Controls)
                {
                    if (control is Panel && control.Visible)
                    {
                        control.Hide();

                    }
                }
            }
            catch (Exception ex)
            {

            }
           
        }

        //Выбор контакта из списка
        private void Change(object sender, EventArgs e)
        {

            try
            {

            }
            catch (Exception ex)
            {

            }
            string[] parts = listBox1.SelectedItem.ToString().Split(';');
            textBox1.Text = parts[0];
            textBox2.Text = parts[1];
        }

        //Проверка на ввод номера
        private void Prov(object sender, EventArgs e)
        {
            Form1.Proverka(textBox6, textBox6, this.Proverka2);
        }

        //Сохранение в файл
        private void сохранитьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PhoneBookLoader.Save(phoneBook, "contacts.csv");
                UpdateList();
                MessageBox.Show("Данные сохранены");
            }
            catch (Exception ex)
            {

            }

           
        }


        //Удаление контакта
   
        private void Delete_contact(object sender, EventArgs e)
        {
            try
            {
                phoneBook.DeleteContact(listBox1.SelectedItem.ToString());
                listBox1.Items.Remove(listBox1.SelectedItem);
                UpdateList();
            }
            catch(Exception ex)
            {

            }
            
        }
        //Выход из программы
        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы действительно хотите выйти из программы", "Подтверждение", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
