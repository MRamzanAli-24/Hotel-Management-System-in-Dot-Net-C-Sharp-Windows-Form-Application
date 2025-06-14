using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.DL
{
    class DeleteDB
    {
        public static bool DeleteAdmin(string CNIC) 
        {
            bool check1 = new DLClass().ExecuteQuery("Delete from Admins where CNIC=@1", CNIC);
            bool check2 = false;
            if (check1)
                check2 = new DLClass().ExecuteQuery("DELETE FROM Users WHERE CNIC = @1 AND Role = @2", CNIC, "Admin");
            FetchDB.GetAdminData();
            FetchDB.GetUserData();
            return check1 && check2;
        }
        public static bool DeleteEmployee(string CNIC)
        {
            bool check1 = new DLClass().ExecuteQuery("Delete from Employees where CNIC=@1", CNIC);
            bool check2 = false;
            if (check1)
                check2 = new DLClass().ExecuteQuery("DELETE FROM Users WHERE CNIC = @1 AND Role = @2", CNIC, "Employee");
            FetchDB.GetAdminData();
            FetchDB.GetUserData();
            return check1 && check2;
        }
        public static bool DeleteCustomer(string CNIC)
        {
            bool check1 = new DLClass().ExecuteQuery("Delete from Customers where CNIC=@1", CNIC);
            bool check2 = false;
            if (check1)
                check2 = new DLClass().ExecuteQuery("DELETE FROM Users WHERE CNIC = @1 AND Role = @2", CNIC, "Customer");
            FetchDB.GetCustomerData();
            FetchDB.GetUserData();
            return check1 && check2;
        }
        public static bool DeleteRoom(string RoomNumber)
        {
            bool check = new DLClass().ExecuteQuery("Delete from Rooms where RoomNumber=@1", RoomNumber);
            return check;
        }
        public static bool DeleteBooking(string RoomNumber, string CNIC)
        {
            bool check1 = new DLClass().ExecuteQuery("Delete from Bookings where RoomNumber=@1 and CustomerCNIC=@2;", RoomNumber, CNIC);
            bool check2 = false;
            if (check1)
            {
                check2 = new DLClass().ExecuteQuery("update Rooms set IsAvailable=@1 where RoomNumber=@2;", 1, RoomNumber);
            }
            return check1 && check2;
        }
        public static bool DeleteItem(string itemname)
        {
            bool check = new DLClass().ExecuteQuery("Delete FoodItems where ItemName=@1;",itemname);
            return check;
        }
        public static bool DeleteOrder(int id)
        {
            bool check = new DLClass().ExecuteQuery("Delete Orders where OrderID=@1;", id);
            return check;
        }
    }
}