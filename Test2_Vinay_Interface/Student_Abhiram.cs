using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_Vinay_Interface
{
    public class Student_Abhiram : IFillForm
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public void FavouriteHero()
        {
            Console.WriteLine("Favourite Hero \"Sr NTR\"");
        }

        public void FavouriteMovie()
        {
            Console.WriteLine("Favourite Movie \"Maya Bazar\"");
        }
        public void StudentDetails()
        {            
            StudentId = 103;
            StudentName = "Abhiram";
            Console.WriteLine("Student Id : " + StudentId);
            Console.WriteLine("Student Name : " + StudentName);
           
        }
    }
}
