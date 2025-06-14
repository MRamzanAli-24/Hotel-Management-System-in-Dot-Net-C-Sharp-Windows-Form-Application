using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.BL
{
    public class Booking
    {
        public DateTime BookingDate{ get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string customerCNIC { get; set; }
        public int days { get; set; }
        public string BookRoomNo { get; set; }
        public int price { get; set; }
        public Booking() 
        {
            this.customerCNIC = string.Empty;
            this.BookRoomNo = string.Empty;
        }
        public Booking(string BookRoomNo,DateTime CheckIn,DateTime CheckOut,int price)
        {
            this.BookRoomNo = BookRoomNo;
            this.CheckIn = CheckIn;
            this.CheckOut = CheckOut;
            this.price = price;
            this.customerCNIC = string.Empty;
        }
        public Booking( DateTime BookingDate,DateTime CheckIn, DateTime CheckOut, string customerCNIC, string bookRoomNo,int days,int price)
        {
            this.BookingDate = BookingDate;
            this.CheckIn = CheckIn;
            this.CheckOut = CheckOut;
            this.customerCNIC = customerCNIC;
            this.days = days;
            this.BookRoomNo = bookRoomNo;
            this.price = price;
        }
    }
}