using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static Model db = new Model();
        static void Main(string[] args)
        {
        
        }
        public static Area[] task1()
        {
            return db.Area.ToArray();
        }
        public static List<Area> task2()
        {
            return db.Area.ToList();
        }
        public static void task3()
        {
            var task3 =
                from m in db.Area
                where m.IP == null
                select m;
            foreach (var item in task3)
            {
                Console.WriteLine("IP : " + item.IP);
                Console.WriteLine("ID : " + item.ParentId);
                Console.WriteLine("ID : " + item.PavilionId);
            }
        }
        public static void task4()
        {
            var task3 =
               from m in db.Area
               where m.PavilionId != 0
               select m;
            foreach (var item in task3)
            {     
                Console.WriteLine("ID : " + item.PavilionId);
            }
        }
        public static void task5()
        {

        }
        public static void task6()
        {
            Console.WriteLine(db.Area.FirstOrDefault());
        }
        public static void task7()
        {
            Console.WriteLine(db.Area.LastOrDefault());
        }
        public static void task8()
        {
            Console.WriteLine(db.Area.Where(w => w.PavilionId == 1).LastOrDefault());
        }
        public static void task9()
        {
            Console.WriteLine(db.Area.Where(w => w.PavilionId == 1).LastOrDefault());
        }
        public static void task10()
        {
            Console.WriteLine(db.Area.Where(w => w.PavilionId == 1).LastOrDefault());
        }
      
    }
}
