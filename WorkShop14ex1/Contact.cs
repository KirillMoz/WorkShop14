using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop14ex1
{
    internal class Contact
    {
        private string name;
        private string surname;
        private long phone;
        private string email;
        public Contact(string Name, string Surname, long Phone, string Email) 
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Phone = Phone;
            this.Email = Email;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        { 
            get { return surname; }
            set { surname = value; }
        }

        public long Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
