using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Movies obj = new Movies("Excehhllent");
            obj.name = "Godfather";
            obj.outPut(obj.name);
            Console.ReadKey();
        }
    }
}
