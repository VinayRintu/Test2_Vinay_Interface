using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Test2_Vinay_Interface
{
    public class Student_Vinay: IFillForm
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public void FavouriteHero()
        {
            Console.WriteLine("My Favourite Hero is \"Pawan Kalyan\"");
        }

        public void FavouriteMovie()
        {
            Console.WriteLine("Recent Favourite Movie is \"Kanthara\"");
        }

        public void StudentDetails()
        {
            StudentId = 101;
            StudentName = "Vinay";
            Console.WriteLine("Student Id : " + StudentId);
            Console.WriteLine("Student Name : " + StudentName);
        }  
    }
}
