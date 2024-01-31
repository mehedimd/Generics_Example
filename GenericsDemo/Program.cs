using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class Students: IComparable<Students>
    {
        public static double Cgpa {  get; set; }
        public int SId { get; set; }
        public string SName { get; set; }
        public double Marks {  get; set; }

        public int CompareTo(Students other)
        {
            if(this.SId > other.SId) 
                return 1;
            else if(this.SId < other.SId)
                return -1;
            else 
                return 0;
        }
    }
    class MarksSort : IComparer<Students>
    {
        public int Compare(Students x, Students y)
        {
            if(x.Marks > y.Marks)
                return 1;
            if (x.Marks < y.Marks)
                return -1;
            else return 0;
        }
    }
 
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(52); list.Add(5); list.Add(33); list.Add(24); list.Add(25);
            list.Sort();
            //foreach(int i in list)
            //{
            //    Console.Write(i + "\t");
            //}
            Console.WriteLine();
            Students s1 = new Students() { SName = "Mehu", SId = 101, Marks = 30.5};
            Students s2 = new Students() { SName = "Nowrin", SId = 120, Marks = 48.5 };
            Students s3 = new Students() { SName = "Imam", SId = 112, Marks = 36 };
            Students s4 = new Students() { SName = "Ruby", SId = 109, Marks = 38.5 };

            List<Students> student = new List<Students> { s1, s2, s3, s4 };
            MarksSort marksSort = new MarksSort();
            student.Sort(marksSort);
            foreach(Students s in student)
            {
                Console.WriteLine($"Name: {s.SName}, ID: {s.SId}, Marks: {s.Marks}");
            }
                Students.Cgpa = 4.9;
                Students.Cgpa = 4.5;  
            Console.WriteLine(Students.Cgpa);


            Console.ReadKey();
        }
    }
}
