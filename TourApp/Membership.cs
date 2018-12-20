using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourApp
{
    public class Membership
    {
        string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string phone;
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        private string birthday;
        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }


        public Membership() { }

        public Membership(string id, string password, string name, string phone, string birthday)
        {
            Id = id;
            Password = password;
            Name = name;
            Phone = phone;
            Birthday = birthday;
        }
    }
}
