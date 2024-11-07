using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace yp_2
{
    static class PhoneBookLoader
    {
      

        //Загрузка данных из файла
        public static void Load(PhoneBook phoneBook, string fileName)
        {
            StreamReader sr = File.OpenText(fileName);
            while (!sr.EndOfStream)
            {

                string[] s = sr.ReadLine().Split(';');
                phoneBook.AddContact(s[0], s[1]);
            }
            sr.Close();
        }

        //Запись данных в файл
        public static void Save(PhoneBook phoneBook, string fileName)
        {
            StreamWriter sr = File.CreateText(fileName);
            foreach (var contact in phoneBook.GetAllContacts())
            {
                sr.WriteLine($"{contact.Name};{contact.Phone}");
            }
            sr.Close();
        }
    }
}
