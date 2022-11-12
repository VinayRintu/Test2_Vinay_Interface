using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_Vinay_Interface
{
    public interface IFillForm
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        void FavouriteMovie();
          void FavouriteHero();

    }
}
