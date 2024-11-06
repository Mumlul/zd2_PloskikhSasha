using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

using Microsoft.Office.Interop.Excel;

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
       





        private void Form1_Load(object sender, EventArgs e)
        {

            PhoneBookLoader.Load(phoneBook);
            phoneBook.GetAllContacts();
            foreach (var contact in phoneBook.GetAllContacts())
            {
                listBox1.Items.Add(contact.Info());
            }
        }

        public void UpdateList()
        {
            listBox1.Items.Clear();
            foreach (var contact in phoneBook.GetAllContacts())
            {
                listBox1.Items.Add(contact.Info());
            }
        }


        private void Proverka(object sender, EventArgs e)
        {
            textBox2.TextChanged -= Proverka;
            string input = Regex.Replace(textBox2.Text, @"[^\d]", "");
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
            textBox2.Text = input;
            textBox2.SelectionStart = textBox2.Text.Length;
            textBox2.TextChanged += Proverka; 
        }

        private void Dopavlenie_Contact(object sender, EventArgs e)
        {
            phoneBook.AddContact(textBox1.Text, textBox2.Text);
            PhoneBookLoader.Save(phoneBook.GetAllContacts());
            listBox1.Items.Add(textBox1.Text+";"+textBox2.Text);
        }

        private void find(object sender, EventArgs e)
        {
            MessageBox.Show(phoneBook.FindContact(textBox3.Text).Info());
        }
        string oldn = "";
        private void Delete(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить да редактировать нет", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string line = listBox1.SelectedItem.ToString();
                listBox1.Items.Remove(listBox1.SelectedItem);
                string[] lines = line.Split(';');
                string name = lines[0];
                phoneBook.RemoveContact(name);
                PhoneBookLoader.Save(phoneBook.GetAllContacts());
            }
            else if (result == DialogResult.No)
            {
                string line = listBox1.SelectedItem.ToString();
                string[] lines = line.Split(';');
                textBox5.Text= lines[0];
                textBox4.Text = lines[1];
                oldn = lines[0];
            }
        }

        private void Edit(object sender, EventArgs e)
        {
            phoneBook.EditContact(oldn, textBox5.Text, textBox4.Text);
            PhoneBookLoader.Save(phoneBook.GetAllContacts());
            UpdateList();
        }

        private void Proverka2(object sender, EventArgs e)
        {
            textBox4.TextChanged -= Proverka;
            string input = Regex.Replace(textBox2.Text, @"[^\d]", "");
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
            textBox4.Text = input;
            textBox4.SelectionStart = textBox4.Text.Length;
            textBox4.TextChanged += Proverka;
        }
    }
}
