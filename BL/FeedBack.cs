using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.BL
{
    class FeedBack
    {
        public  int id;
        public string customerName;
        public string customerPhNo;
        public string feedback;
        public FeedBack(int id, string customerName, string customerPhNo, string feedback)
        {
            this.id = id;
            this.customerName = customerName;
            this.customerPhNo = customerPhNo;
            this.feedback = feedback;
        }
        public FeedBack(string customerName, string customerPhNo, string feedback)
        {
            this.customerName = customerName;
            this.customerPhNo = customerPhNo;
            this.feedback = feedback;
        }
    }
}
