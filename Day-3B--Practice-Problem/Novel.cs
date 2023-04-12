using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3B__Practice_Problem
{
    public interface Novel
    {
        void Novels();
    }
    class TwoStates : Novel
    {
        public void Novels()
        {
            Console.WriteLine("Two States Novel By Chetan Bhagat");
        }
    }

}
