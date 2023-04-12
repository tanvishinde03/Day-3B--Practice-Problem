using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3B__Practice_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.WriteLine(" Default Construtor: ");
            Console.WriteLine("Name: " + car.Name);      //Default Constructor
            Console.WriteLine("ModelNo: " + car.ModelNo);
            Console.ReadLine();

            
            TV tv = new TV("Sony", 2244);
            Console.WriteLine("Parameterized Constructor: ");    // Parameterized Constructor
            Console.WriteLine("Name: " + tv.Name);
            Console.WriteLine("TVID: " + tv.TVID);
            Console.ReadLine();

            
            TV2 tv2 = new TV2(tv);
            Console.WriteLine("Copy Constructor:");       //Copy Constructor
            Console.WriteLine("Name: " + tv.Name);
            Console.WriteLine("Age: " + tv.TVID);
            Console.ReadLine();

            
            Console.WriteLine("Static Constructor:");
            Console.WriteLine("Count: " + Mobile.Count);    // Static Constructor
            Mobile mobile = new Mobile();
            Console.WriteLine("Count: " + Mobile.Count);
            Console.ReadLine();

           
            Source source = Source.GetInstance();  // Private Constructor
            Console.WriteLine("Private Constructor (Source):");
            Console.WriteLine("Instance: " + source);
            Console.ReadLine();

            TwoStates twostates = new TwoStates();
            twostates.Novels();
            Console.ReadLine();
        }
    }
}
        
    

