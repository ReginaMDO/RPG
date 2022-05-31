using System;
using RPG.src.Entities;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new Hero( "Arus", 23, "knight");
            
            Console.WriteLine(arus);
            Console.WriteLine(arus.Attack());
            
        }
    }
}
