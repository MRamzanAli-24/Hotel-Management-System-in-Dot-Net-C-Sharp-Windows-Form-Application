using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Hotel_Management_System.BL;
using Hotel_Management_System.UI;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Hotel_Management_System.DL
{
    class FetchDB
    {
        public static List<User> userList = new List<User>();
        public static List<Admin> adminList = new List<Admin>();
        public static List<Employee> employeeList = new List<Employee>();
        public static List<Customer> customerList = new List<Customer>();
        public static List<Room> roomList = new List<Room>();
        public static List<Booking> bookingList = new List<Booking>();
        public static List<FoodItem> foodItemsList = new List<FoodItem>();
        public static List<FeedBack> feedBackList = new List<FeedBack>();
        public static int availableRoomsCount = 0;
        public static void GetUserData()
        {
            userList.Clear();
            string query = "select Name,CNIC,UserName,Password,Role from Users;";
            var reader = new DLClass().ReturnQuery(query);
            while (reader.Read())
            {
                if (reader["Role"].ToString() == "Admin")
                {
                    userList.Add(new Admin(reader["Name"].ToString() ?? "", reader["CNIC"].ToString() ?? "", reader["UserName"].ToString() ?? "", reader["Password"].ToString() ?? "", reader["Role"].ToString() ?? ""));
                }
                else if (reader["Role"].ToString() == "Employee")
                {
                    userList.Add(new Employee(reader["Name"].ToString() ?? "", reader["CNIC"].ToString() ?? "", reader["UserName"].ToString() ?? "", reader["Password"].ToString() ?? "", reader["Role"].ToString() ?? ""));
                }
                else if (reader["Role"].ToString() == "Customer")
                {
                    userList.Add(new Customer(reader["Name"].ToString() ?? "", reader["CNIC"].ToString() ?? "", reader["UserName"].ToString() ?? "", reader["Password"].ToString() ?? "", reader["Role"].ToString() ?? ""));
                }
            }
        }
        public static void GetAdminData()
        {
            adminList.Clear();
            string query = "SELECT  u.Name, u.CNIC, u.PhoneNo,  u.Address, u.Gender,  u.UserName, u.Password, a.IsMainAdmin FROM Admins a JOIN Users u ON a.CNIC = u.CNIC AND u.Role = 'Admin';";
            var reader = new DLClass().ReturnQuery(query);
            if (reader != null)
            {
                while (reader.Read())
                {
                    Admin obj = new Admin(reader["Name"].ToString() ?? "", reader["CNIC"].ToString() ?? "", reader["PhoneNo"].ToString() ?? "", reader["Address"].ToString() ?? "", reader["Gender"].ToString() ?? "", reader["UserName"].ToString() ?? "", reader["Password"].ToString() ?? "", Convert.ToBoolean(reader["IsMainAdmin"]));
                    adminList.Add(obj);
                }
            }
        }
        public static void GetEmployeeData()
        {
            employeeList.Clear();
            string query = "SELECT u.Name, u.CNIC,  u.PhoneNo, u.Address, u.Gender, u.UserName, u.Password, e.Salary FROM Employees e JOIN Users u ON e.CNIC = u.CNIC AND u.Role = 'Employee';";
            var reader = new DLClass().ReturnQuery(query);

            while (reader.Read())
            {
                Employee obj = new Employee(reader["Name"].ToString() ?? "", reader["CNIC"].ToString() ?? "", reader["PhoneNo"].ToString() ?? "", reader["Address"].ToString() ?? "", reader["Gender"].ToString() ?? "", reader["UserName"].ToString() ?? "", reader["Password"].ToString() ?? "", Convert.ToInt32(reader["Salary"]));
                employeeList.Add(obj);
            }
        }
        public static void GetBookingData()
        {
            bookingList.Clear();
            string query = "SELECT * from Bookings;";
            var reader = new DLClass().ReturnQuery(query);

            while (reader.Read())
            {
                Booking obj = new Booking(Convert.ToDateTime(reader["BookingDate"]), Convert.ToDateTime(reader["CheckInDate"]), Convert.ToDateTime(reader["CheckOutDate"]), reader["CustomerCNIC"].ToString() ?? "", reader["RoomNumber"].ToString() ?? "", Convert.ToInt32(reader["DurationDays"]), reader["price"] == DBNull.Value ? 0 : Convert.ToInt32(reader["price"]));
                bookingList.Add(obj);
            }
        }
        public static void GetCustomerData()
        {
            customerList.Clear();
            string query = "SELECT u.Name, u.CNIC, u.PhoneNo, u.Address, u.Gender, u.UserName, u.Password, c.TotalAmount FROM Customers c JOIN Users u ON c.CNIC = u.CNIC AND u.Role = 'Customer';";
            var reader = new DLClass().ReturnQuery(query);

            while (reader.Read())
            {
                Customer obj = new Customer(reader["Name"].ToString() ?? "", reader["CNIC"].ToString() ?? "", reader["PhoneNo"].ToString() ?? "", reader["Address"].ToString() ?? "", reader["Gender"].ToString() ?? "", reader["UserName"].ToString() ?? "", reader["Password"].ToString() ?? "", Convert.ToInt32(reader["TotalAmount"]));
                customerList.Add(obj);
            }
        }
        public static void GetRoomData()
        {
            availableRoomsCount = 0;
            roomList.Clear();
            string query = "select * from Rooms;";
            var reader = new DLClass().ReturnQuery(query);
            while (reader.Read())
            {
                Room obj = new Room(reader["RoomNumber"].ToString() ?? "", reader["Type"].ToString() ?? "", reader["Category"].ToString() ?? "", float.Parse((reader["Price"].ToString() ?? "0")), Convert.ToBoolean(reader["IsAvailable"]));
                if (obj.isAvaiable)
                {
                    availableRoomsCount++;
                }
                roomList.Add(obj);
            }
        }
        public static void GetBookingRoomCustomer(Customer obj)
        {
            obj.Bookings.Clear();
            var reader = new DLClass().ReturnQuery("Select * from Bookings where CustomerCNIC =@1;", obj.CNIC);
            while (reader.Read())
            {
                Booking obj1 = new Booking(
                    reader["BookingDate"] != DBNull.Value ? Convert.ToDateTime(reader["BookingDate"]) : DateTime.MinValue,
                    reader["CheckInDate"] != DBNull.Value ? Convert.ToDateTime(reader["CheckInDate"]) : DateTime.MinValue,
                    reader["CheckOutDate"] != DBNull.Value ? Convert.ToDateTime(reader["CheckOutDate"]) : DateTime.MinValue,
                    reader["CustomerCNIC"]?.ToString() ?? "",
                    reader["RoomNumber"]?.ToString() ?? "",
                    reader["DurationDays"] != DBNull.Value ? Convert.ToInt32(reader["DurationDays"]) : 0,
                    reader["price"] != DBNull.Value ? Convert.ToInt32(reader["price"]) : 0
                );
                obj.Bookings.Add(obj1);
            }
        }
        public static void GetFoodItems()
        {
            foodItemsList.Clear();
            var reader = new DLClass().ReturnQuery("Select * from FoodItems");
            while (reader.Read())
            {
                FoodItem obj = new FoodItem(reader["ItemName"].ToString() ?? "", Convert.ToInt32(reader["ItemPrice"]));
                foodItemsList.Add(obj);
            }
        }
        public static void GetFeedBack()
        {
            feedBackList.Clear();
            var reader = new DLClass().ReturnQuery("Select * from FeedBack");
            while (reader.Read())
            {
                FeedBack obj = new FeedBack(Convert.ToInt32(reader["id"].ToString()), reader["customerName"].ToString() ?? "", reader["customerPhNo"].ToString() ?? "", reader["feedback"].ToString() ?? "");
                feedBackList.Add(obj);
            }
        }
        public static void GetOrderList(Customer customer)
        {
            customer.Orders.Clear();
            var reader = new DLClass().ReturnQuery("select * from Orders where CustomerCNIC=@1;", customer.CNIC);
            if (reader != null)
            {
                while (reader.Read())
                {
                    Orders obj = new Orders(Convert.ToInt32(reader["OrderID"]), reader["ItemName"].ToString() ?? "", Convert.ToDateTime(reader["OrderTime"]), Convert.ToInt32(reader["amount"]), Convert.ToInt32(reader["RoomNumber"]), Convert.ToBoolean(reader["OrderStatus"]), Convert.ToInt32(reader["Quantity"]));
                    customer.Orders.Add(obj);
                }
            }
        }
    }
}