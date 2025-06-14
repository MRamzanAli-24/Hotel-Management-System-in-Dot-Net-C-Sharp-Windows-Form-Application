using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel_Management_System.DL;
using Microsoft.Data.SqlClient;
namespace Hotel_Management_System.BL
{
    class BLClass
    {
        public static User checkUser(string checkUserName, string checkPassword)
        {
            foreach (User obj in FetchDB.userList)
            {
                if (obj.UserName == checkUserName && obj.Password == checkPassword)
                {
                    return obj;
                }
            }
            return null;
        }
        public static bool GetAdmin(User user)
        {
            foreach (Admin check in FetchDB.adminList)
            {
                if (user.CNIC == check.CNIC && user.UserName == check.UserName && check.isMainAdmin == true)
                {
                    return true;
                }
            }
            return false;
        }
        public static Customer GetCustomer(User user)
        {
            foreach (Customer check in FetchDB.customerList)
            {
                if (user.CNIC == check.CNIC && user.UserName == check.UserName)
                {
                    return check;
                }
            }
            return null;
        }

        public static bool IsAdminExist(Admin obj)
        {
            bool exist = false;
            foreach (Admin check in FetchDB.adminList)
            {
                if (obj.CNIC == check.CNIC || obj.UserName == check.UserName)
                {
                    exist = true;
                }
            }
            return exist;
        }
        public static bool IsEmployeeExist(Employee obj)
        {
            bool exist = false;
            foreach (Employee check in FetchDB.employeeList)
            {
                if (obj.CNIC == check.CNIC || obj.UserName == check.UserName)
                {
                    exist = true;
                }
            }
            return exist;
        }
        public static bool IsCustomerExist(Customer obj)
        {
            bool exist = false;
            foreach (Customer check in FetchDB.customerList)
            {
                if (obj.CNIC == check.CNIC || obj.UserName == check.UserName)
                {
                    exist = true;
                }
            }
            return exist;
        }
        public static bool checkRoomType(string type)
        {
            bool check = false;
            foreach (string item in FileData.roomTypeList)
            {
                if (item == type)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        public static bool checkRoomCategory(string category)
        {
            bool check = false;
            foreach (string item in FileData.roomCategoryList)
            {
                if (item == category)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        public static bool isRoomExist(Room obj)
        {
            bool check = false;
            foreach (Room item in FetchDB.roomList)
            {
                if (item.RoomNumber == obj.RoomNumber)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        public static bool CheckRoom(string RoomNumber)
        {
            foreach (Room item in FetchDB.roomList)
            {
                if (item.RoomNumber == RoomNumber)
                {
                    return item.isAvaiable;
                }
            }
            return false;
        }
        public static bool checkInDateConfirm(Customer obj)
        {
            foreach (Booking booking in obj.Bookings)
            {
                if (booking.CheckIn.Date <= DateTime.Now.Date)
                    return true;
            }
            return false;
        }
        public static bool checkAvaialableRoomType(string type)
        {
            foreach (Room room in FetchDB.roomList)
            {
                if (room.Type == type)
                { return true; }
            }
            return false;
        }
        public static bool checkAvaialableRoomCategory(string category)
        {
            foreach (Room room in FetchDB.roomList)
            {
                if (room.Category == category)
                { 
                    return true;
                }
            }
            return false;
        }
        public static bool capableToDelete(string CNIC)
        {
            int count = 0;
            int amount = 0;
            SqlDataReader reader1 = new DLClass().ReturnQuery("SELECT COUNT(*) AS count FROM Bookings WHERE CustomerCNIC = @1;", CNIC);

            if (reader1 != null && reader1.Read())
            {
                count = Convert.ToInt32(reader1["count"]); 
            }
            SqlDataReader reader2 = new DLClass().ReturnQuery("SELECT TotalAmount as amount FROM Customers WHERE CNIC = @1;", CNIC);

            if (reader2 != null && reader2.Read())
            {
                amount = Convert.ToInt32(reader2["amount"]); 
            }
            List<Orders> orders = new List<Orders>();
            return count > 0 || amount > 0;
        }
        public static bool checkCustomer(string CNIC)
        {
            foreach(Customer customer in FetchDB.customerList)
            {
                if(customer.CNIC == CNIC)
                    { return true; }
            }
            return false;
        }
        public static bool checkFoodItem(string ItemName)
        {
            foreach(FoodItem item in FetchDB.foodItemsList)
            {
                if(item.itemName==ItemName)
                    { return true; }
            }
            return false;
        }
    }
}