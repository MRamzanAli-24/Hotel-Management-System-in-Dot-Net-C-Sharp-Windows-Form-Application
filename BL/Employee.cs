using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.BL
{
    public class Employee:User
    {
        public int salary=0;
        public Employee() { }
        public Employee(string name, string CNIC, string UserName, string Password, string Role) : base(name, CNIC, UserName, Password, Role)
        {
        }
        public Employee(string name, string CNIC, string PhoneNo, string Address, string Gender, string UserName, string Password, int salary) : base(name, CNIC, PhoneNo, Address, Gender, UserName, Password)
        {
            this.salary = salary;
            this.Role = "Employee";
        }
        public override bool CheckData()
        {
            bool check=false;
            if (string.IsNullOrEmpty(this.name) || string.IsNullOrEmpty(this.CNIC) || string.IsNullOrEmpty(this.UserName) || string.IsNullOrEmpty(this.Password) || string.IsNullOrEmpty(this.PhoneNo)||this.salary==0 || this.CNIC.Length != 13 || this.PhoneNo.Length != 11)
            {
                check = true;
            }
            return check;
        }
    }
}