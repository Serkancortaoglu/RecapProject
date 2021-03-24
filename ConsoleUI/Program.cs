using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemory());
            foreach (var p in carManager.GetAll())
            {
                Console.WriteLine(p.Description);
            }
        }
    }
}
