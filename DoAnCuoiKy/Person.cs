using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{
    public abstract class Person
    {
        private string identity;

        private string name;

        private DateTime birthDay;

        private string address;

        public Person(string identity, string name, DateTime birthDay, string address)
        {
            this.Identity = identity;
            this.Name = name;
            this.BirthDay = birthDay;
            this.Address = address;
        }

        public Person() { }

        public string Identity { get => identity; set => identity = value; }
        public string Name { get => name; set => name = value; }
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }
        public string Address { get => address; set => address = value; }

        public virtual string PrintInfo()
        {
            return "CCCD: " + Identity + "\n"
                + "Họ tên: " + Name + "\n"
                + "Ngày tháng năm sinh: " + BirthDay + "\n"
                + "Địa chỉ: " + Address + "\n\n";
        }
    }
}
