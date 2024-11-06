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


        public Contact() { }


        public Contact(string name,string number)
        {
            Name = name;
            Phone = number;
        }

        public string Info()
        {
            return $"{Name} ; {Phone}";
        }
    }
}
