using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3B__Practice_Problem
{
    public class AccessModifiers
    {
        public int Value { get; set; }             // Public Access Modifier
        public int IncrementValue(int value)
        {
            return value + 1;
        }
    }


    public class BankAccount
    {
        private int balance;                     // Private Access Modifier
        public int GetBalance()
        {
            return balance;
        }
        public void Deposit(int amount)
        {
            balance += amount;
        }
        public void Withdraw(int amount)
        {
            if (balance - amount >= 0)
            {
                balance -= amount;
            }
        }

    }
}


public class Shape
{
    protected int Width { get; set; }            // Protected Access Modifier
    protected int Height { get; set; }
    public virtual int GetArea()
    {
        return Width * Height;
    }
}
public class Rectangle : Shape
{
    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }
}
internal class Logger
{
    internal string LogMessage(string message)         // Internal Access Modifier
    {
        return $"Logged at {DateTime.Now}, Message: {message}";
    }
}

    

    

