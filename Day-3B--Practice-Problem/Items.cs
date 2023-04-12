using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3B__Practice_Problem
{
    public class Car
    {
        public string Name { get; set; }
        public int ModelNo { get; set; }

        public Car()
        {
            Name = "KIA";
            ModelNo = 440;

        }

    }
    public class TV                                     // Parameterized Constructor
    {
        public string Name { get; set; }
        public int TVID { get; set; }

        public TV(string name, int TVID)
        {
            Name = name;
            TVID = 2244;
        }
    }
    public class TV2
    {
        public string Name { get; set; }
        public int TVID { get; set; }
        public TV Tv { get; }

        public TV2(TV2 tv)
        {
            Name = tv.Name;
            TVID = tv.TVID;
        }

        public TV2(TV tv)
        {
            Tv = tv;
        }
    }
    public class Mobile                             // Static Constructor
    {
        public static int Count { get; set; }

        static Mobile()
        {
            Count = 0;
        }
    }
    public class Source                          // Private Constructor
    {
        private static Source instance;

        private Source()
        {

        }

        public static Source GetInstance()
        {
            if (instance == null)
            {
                instance = new Source();
            }
            return instance;
        }
    }

}

    

