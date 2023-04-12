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

            TwoStates twostates = new TwoStates(); //Interface
            twostates.Novels();
            Console.ReadLine();

           
            var publicAccessSpecifiers = new AccessModifiers();    //Public Access Modifier
            publicAccessSpecifiers.Value = 10;
            var result = publicAccessSpecifiers.IncrementValue(publicAccessSpecifiers.Value);
            Console.WriteLine(result);
            Console.ReadLine();

            
            var account = new BankAccount();   // Private Access Modifier
            account.Deposit(500);
            var balance = account.GetBalance();
            Console.WriteLine(balance);
            Console.ReadLine();

          
            var rectangle = new Rectangle(10, 5);   // Protected Access Modifier
            var area = rectangle.GetArea();
            Console.WriteLine(area);
            Console.ReadLine();

            
            var logger = new Logger(); // Internal Access Modifier
            var messageLog = logger.LogMessage("This is a message");
            Console.WriteLine(messageLog);
            Console.ReadLine();

        }
    }
}


        
    

        
    

