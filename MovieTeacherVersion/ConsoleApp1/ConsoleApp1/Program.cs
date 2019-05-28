using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie2 movie = new Movie2();
            movie.Id = 111;
            movie.Name = "Godfather";
            movie.Rate = "C#";
            Console.WriteLine("name = {0}, Id = {1}, Rate = {2}", movie.Name, movie.Id, movie.Rate);
            Console.WriteLine("------------------------------------------");
            var mov = new Movie2();

            mov.Id = 222;
            mov.Name = "Leon";
            mov.Rate = "Good";
            Console.WriteLine("name = {0}, Id = {1}, Rate = {2}", mov.Name, mov.Id, mov.Rate);



            Console.ReadKey();
        }
    }
}
