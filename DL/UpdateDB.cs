using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel_Management_System.BL;
using Hotel_Management_System.UI;

namespace Hotel_Management_System.DL
{
    class UpdateDB
    {
        public static bool UpdateAdmin(string CNIC,Admin admin)
        {
            bool check1 = new DLClass().ExecuteQuery("Update Users set CNIC=@1,Name=@2,PhoneNo=@3,Address=@4,Gender=@5,UserName=@6,Password=@7 where Role=@8 and CNIC=@9;",admin.CNIC,admin.name,admin.PhoneNo,admin.Address,admin.Gender,admin.UserName,admin.Password,"Admin",CNIC);
            bool check2 = false;
            if(check1) 
                   check2 = new DLClass().ExecuteQuery("Update Admins set CNIC=@1 where CNIC=@2", admin.CNIC, CNIC);
            FetchDB.GetAdminData();
            FetchDB.GetUserData();
            return check1&&check2;
        }
        public static bool UpdateEmployee(string CNIC, Employee employee)
        {
            bool check1 = new DLClass().ExecuteQuery("Update Users set CNIC=@1,Name=@2,PhoneNo=@3,Address=@4,Gender=@5,UserName=@6,Password=@7 where  Role=@8 and CNIC=@9;", employee.CNIC, employee.name, employee.PhoneNo, employee.Address, employee.Gender, employee.UserName, employee.Password, "Employee", CNIC);
            bool check2 = false;
            if(check1)
                check2 = new DLClass().ExecuteQuery("Update Employees set CNIC=@1 ,  Salary=@2 where CNIC=@3", employee.CNIC,employee.salary, CNIC);
            FetchDB.GetEmployeeData();
            FetchDB.GetUserData();
            return check1 && check2;
        }
        public static bool UpdateCustomer(string CNIC, Customer customer)
        {
            bool check1 = new DLClass().ExecuteQuery("Update Users set CNIC=@1,Name=@2,PhoneNo=@3,Address=@4,Gender=@5,UserName=@6,Password=@7 where Role=@8 and CNIC=@9;", customer.CNIC, customer.name, customer.PhoneNo, customer.Address, customer.Gender, customer.UserName, customer.Password, "Customer", CNIC);
            bool check2 = false;
            if(check1)
                check2 = new DLClass().ExecuteQuery("Update Admins set CNIC=@1 where CNIC=@2", customer.CNIC, CNIC);
            FetchDB.GetAdminData();
            FetchDB.GetUserData();
            return check1 && check2;
        }
        public static bool UpdateRoom(Room room)
        {
            bool check = new DLClass().ExecuteQuery("Update Rooms set Type=@1,Category=@2,Price=@3,IsAvailable=@4 where RoomNumber=@5;",room.Type,room.Category,room.Price,room.isAvaiable, room.RoomNumber);
            FetchDB.GetRoomData();
            return check;
        }
        public static bool UpdateBooking(Booking booking,int price)
        {
            bool check1 = new DLClass().ExecuteQuery("Update Bookings set CheckInDate=@1 , CheckOutDate= @2 where RoomNumber=@3;",booking.CheckIn.Date,booking.CheckOut.Date,booking.BookRoomNo);
            bool check2= false;
            if (check1)
                check2 = new DLClass().ExecuteQuery("update Customers set TotalAmount = TotalAmount+@1-@2 where CNIC=@3;", booking.price, price, booking.customerCNIC);
            return check1&&check2;
        }
        public static bool UpdateFoodItem(FoodItem foodItem,string name)
        {
            bool check = new DLClass().ExecuteQuery("update FoodItems set ItemName=@1 , ItemPrice = @2 where ItemName =@3 ", foodItem.itemName, foodItem.itemPrice, name);
            return check;
        }
        public static bool orderPlaced(int orderID,int amount,string CNIC)
        {
            bool check1 = new DLClass().ExecuteQuery("update Orders set OrderStatus=@1 where OrderId=@2;", 1, orderID);
            bool check2= false;
            if (check1)
                check2 = new DLClass().ExecuteQuery("update Customers set TotalAmount=TotalAmount + @1 where CNIC =@2;", amount, CNIC);
            return check1&&check2;                
        }
    }
}
