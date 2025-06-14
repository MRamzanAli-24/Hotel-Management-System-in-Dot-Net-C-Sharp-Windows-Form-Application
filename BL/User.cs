using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.BL
{
    interface IUser
    {
        bool CheckData();
    }
    public abstract class User: IUser
    {
        public string name { get; set; } 
        public string CNIC { get; set; }
        public string PhoneNo { get; set; } 

        public string Address { get; set; }
        public string Gender { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role{ get; set; }
        public User()
        {
            this.name = string.Empty;
            this.CNIC = string.Empty;
            this.PhoneNo = string.Empty;
            this.Address = string.Empty;
            this.Gender = string.Empty;
            this.UserName = string.Empty;
            this.Password = string.Empty;
            this.Role = string.Empty;
        }
        public User(string name,string CNIC,string UserName,string Password,string Role)
        {
            this.name = name;
            this.CNIC = CNIC;
            this.UserName = UserName;
            this.Password = Password;
            this.Role = Role;
            this.PhoneNo = string.Empty;
            this.Address = string.Empty;
            this.Gender = string.Empty;
        }
        public User(string name, string CNIC, string PhoneNo, string Address, string Gender, string UserName, string Password, string Role)
        {
            this.name = name;
            this.CNIC = CNIC;
            this.PhoneNo = PhoneNo;
            this.Address = Address;
            this.Gender = Gender;
            this.UserName = UserName;
            this.Password = Password;
            this.Role = Role;
        }
        public User(string name, string CNIC, string PhoneNo, string Address, string Gender, string UserName, string Password)
        {
            this.name = name;
            this.CNIC = CNIC;
            this.PhoneNo = PhoneNo;
            this.Address = Address;
            this.Gender = Gender;
            this.UserName = UserName;
            this.Password = Password;
            this.Role=string.Empty;
        }
        public abstract bool CheckData();
    }
}
