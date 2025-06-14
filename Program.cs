using Hotel_Management_System.BL;
using Hotel_Management_System.DL;
using Hotel_Management_System.UI;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    internal static class Program
    {
        [STAThread]
        static void ResetData(object state)
        {
            Console.WriteLine($"ResetData called at {DateTime.Now}");

            foreach (Booking obj in FetchDB.bookingList)
            {
                if (obj.CheckOut.Date < DateTime.Now.Date)
                {
                    string roomNumber = obj.BookRoomNo;
                    bool check1 = new DLClass().ExecuteQuery("delete from Bookings where RoomNumber=@1;", roomNumber);
                    if (check1)
                    {
                        new DLClass().ExecuteQuery("update Rooms set IsAvailiable=@1 where RoomNumber=@2;", 1, roomNumber);
                        FetchDB.GetUserData();
                        FetchDB.GetAdminData();
                        FetchDB.GetEmployeeData();
                        FetchDB.GetCustomerData();
                        FetchDB.GetRoomData();
                        FetchDB.GetFoodItems();
                        FetchDB.GetFeedBack();
                        FetchDB.GetBookingData();
                    }
                }
            }
        }

        private static System.Threading.Timer resetTimer;

        static void StartResetTimer()
        {
            resetTimer = new System.Threading.Timer(
                ResetData,
                null,
                TimeSpan.Zero,
                TimeSpan.FromMilliseconds(100)); 
        }

        static void Main()
        {
            ApplicationConfiguration.Initialize();
            StartResetTimer(); 
            Application.Run(new LoginFormDashboard());
        }
    }
}
