using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel h = new Hotel("Armada");
            Room r1 = new Room("1", 250, "2");
            Room r2 = new Room("2", 300, "3");
            Room r3 = new Room("3", 350, "3");
            Room r4 = new Room("4", 400, "4");
            h.AddRooms(r1);
            h.AddRooms(r2);
            h.AddRooms(r3);
            h.AddRooms(r4);
            Console.WriteLine(r1);
            Console.WriteLine("Please enter to reserved id of room");
            int n = Convert.ToInt32(Console.ReadLine());
            h.Reserve(n);
            Console.WriteLine(h[n - 1]);
        }
    }
}
