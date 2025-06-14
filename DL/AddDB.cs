using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Hotel_Management_System.BL;
namespace Hotel_Management_System.DL
{
    class AddDB
    {
        public static bool AddCustomer(Customer obj)
        {
            bool check1 = new DLClass().ExecuteQuery($"insert into Users (CNIC,Name,PhoneNo,Address,Gender,UserName,Password,Role) values (@1,@2,@3,@4,@5,@6,@7,@8)", obj.CNIC, obj.name, obj.PhoneNo, obj.Address, obj.Gender, obj.UserName, obj.Password, obj.Role);
            bool check2 = false;
            if (check1)
                check2 = new DLClass().ExecuteQuery($"insert into Customers (CNIC,TotalAmount) values (@1,@2)", obj.CNIC, obj.totalAmount);
            return check1 && check2;
        }
        public static bool AddAdmin(Admin obj)
        {
            bool check1 = new DLClass().ExecuteQuery($"insert into Users (CNIC,Name,PhoneNo,Address,Gender,UserName,Password,Role) values (@1,@2,@3,@4,@5,@6,@7,@8);", obj.CNIC, obj.name, obj.PhoneNo, obj.Address, obj.Gender, obj.UserName, obj.Password, obj.Role);
            bool check2 = false;
            if (check1)
                check2 = new DLClass().ExecuteQuery($"insert into Admins (CNIC,IsMainAdmin) values (@1,@2)", obj.CNIC, obj.isMainAdmin);
            return check1 && check2;
        }
        public static bool AddEmployee(Employee obj)
        {
            bool check1 = new DLClass().ExecuteQuery($"insert into Users (CNIC,Name,PhoneNo,Address,Gender,UserName,Password,Role) values (@1,@2,@3,@4,@5,@6,@7,@8);", obj.CNIC, obj.name, obj.PhoneNo, obj.Address, obj.Gender, obj.UserName, obj.Password, obj.Role);
            bool check2 = false;
            if (check1)
                check2 = new DLClass().ExecuteQuery($"insert into Employees (CNIC,Salary) values (@1,@2)", obj.CNIC, obj.salary);
            return check1 && check2;
        }
        public static bool AddRoom(Room obj)
        {
            bool check = new DLClass().ExecuteQuery($"insert into Rooms (RoomNumber,Type,Category,Price,IsAvailable) values (@1,@2,@3,@4,@5);", obj.RoomNumber, obj.Type, obj.Category, obj.Price, 1);
            return check;
        }
        public static bool AddBooking(Booking obj)
        {
            bool check1 = new DLClass().ExecuteQuery($"insert into Bookings (CustomerCNIC,RoomNumber,BookingDate,DurationDays,CheckInDate,CheckOutDate) values (@1,@2,@3,@4,@5,@6);", obj.customerCNIC, obj.BookRoomNo, obj.BookingDate, obj.days, obj.CheckIn, obj.CheckOut,obj.price);
            bool check2 = false;
            bool check3 = false;
            if (check1)
                check2 = new DLClass().ExecuteQuery($"update Rooms set IsAvailable=0 where RoomNumber=@1", obj.BookRoomNo);
            if (check1 && check2)
                check3 = new DLClass().ExecuteQuery("UPDATE Customers SET TotalAmount = TotalAmount + @1 WHERE CNIC = @2;", obj.price, obj.customerCNIC);
            return check1 && check2 && check3;
        }
        public static bool AddFoodItem(FoodItem obj)
        {
            bool check1 = new DLClass().ExecuteQuery($"insert into FoodItems (ItemName,ItemPrice) values (@1,@2);", obj.itemName, obj.itemPrice);
            return check1;
        }
        public static bool PlaceOder(string itemName, int quantity, int price, string RoomNumber, string CNIC)
        {
            bool check1 = new DLClass().ExecuteQuery(
                "insert into Orders (ItemName, CustomerCNIC, OrderTime, amount, RoomNumber, OrderStatus,Quantity) values (@1, @2, @3, @4, @5, @6,@7);",
                itemName, CNIC, DateTime.Now, price, RoomNumber, 0, quantity);
            return check1;
        }
        public static bool AddFeedback(FeedBack obj)
        {
            bool check1 = new DLClass().ExecuteQuery($"insert into FeedBack (customerName,customerPhNo,feedback) values (@1,@2,@3);", obj.customerName, obj.customerPhNo, obj.feedback);
            return check1;
        }
        public static bool AddPyement(string name, string cnic, string phoneNo, int payable)
        {
            bool check1 = new DLClass().ExecuteQuery($"insert into Report (CustomerPhoneNo,PaidAmount,CustomerName,paymentDate) values (@1,@2,@3,@4);", phoneNo, payable, name,DateTime.Now.Date);
            bool check2 = false;
            if (check1)
            {
                check2 = new DLClass().ExecuteQuery("update Customers set TotalAmount=TotalAmount-@1 where CNIC=@2;", payable, cnic);
            }
            return check1 && check2;
        }
    }
}