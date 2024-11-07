using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yp_2
{
    class Contact
    {
        //Поля класса
        public string Name { get; set; }
        public string Phone { get; set; }

        //Конструктор класса
        public Contact() { }

        //Перегрузка конструктора
        public Contact(string name,string number)
        {
            Name = name;
            Phone = number;
        }
        //Вывод информации о контаке
        public string Info()
        {
            return $"{Name} ; {Phone}";
        }
    }
}
