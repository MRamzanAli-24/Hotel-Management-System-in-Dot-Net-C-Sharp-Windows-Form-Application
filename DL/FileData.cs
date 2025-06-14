using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.DL
{
    class FileData
    {
        public static List<string> roomTypeList = new List<string>();
        public static List<string> roomCategoryList = new List<string>();
        public static double expances = 0.0;
        public static void getRoomType()
        {
            string path = $"E:\\C#Programs\\projects\\Hotel_Management_System\\RoomType.txt";
            StreamReader sr = new StreamReader(path);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                roomTypeList.Add(line);
            }
            sr.Close();
        }
        public static void getRoomCategory()
        {
            string path = $"E:\\C#Programs\\projects\\Hotel_Management_System\\RoomCategory.txt";
            StreamReader sr = new StreamReader(path);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                roomCategoryList.Add(line);
            }
            sr.Close();
        }
        public static void addRoomType()
        {
            string path = $"E:\\C#Programs\\projects\\Hotel_Management_System\\RoomType.txt";
            StreamWriter wr = new StreamWriter(path);
            foreach (string line in roomTypeList)
            {
                wr.WriteLine(line);
            }
            wr.Flush();
            wr.Close();
        }
        public static void addRoomCategory()
        {
            string path = $"E:\\C#Programs\\projects\\Hotel_Management_System\\RoomCategory.txt";
            StreamWriter wr = new StreamWriter(path);
            foreach (string line in roomCategoryList)
            {
                wr.WriteLine(line);
            }
            wr.Flush();
            wr.Close();
        }
        public static void addExpances()
        {
            string path = $"E:\\C#Programs\\projects\\Hotel_Management_System\\expances.txt";
            StreamWriter wr = new StreamWriter(path);
            wr.WriteLine(expances);
            wr.Flush();
            wr.Close();
        }
        public static void getExpances()
        {
            string path = $"E:\\C#Programs\\projects\\Hotel_Management_System\\expances.txt";
            StreamReader sr = new StreamReader(path);
            expances = Convert.ToDouble(sr.ReadLine());
            sr.Close();
        }
    }
}