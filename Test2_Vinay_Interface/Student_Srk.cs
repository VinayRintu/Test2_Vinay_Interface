using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_Vinay_Interface
{
    public class Student_Srk : IFillForm
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public void FavouriteHero()
        {
            Console.WriteLine("Favourite Hero \"Chiranjeevi\"");
        }

        public void FavouriteMovie()
        {
            Console.WriteLine("Favourite Movie \"Indra\"");
        }

        public void StudentDetails()
        {          

            StudentId = 102;
            StudentName = "Srk";
            Console.WriteLine("Student Id : " + StudentId);
            Console.WriteLine("Student Name : " + StudentName);
        }
    }
}
