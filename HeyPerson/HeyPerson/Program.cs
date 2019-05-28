using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeyPerson
{
   public class Program
    {
       public static void Main(string[] args)

        {
            Person obj = new Person();
            obj.myName = "leo";
            obj.introduce("teacher");
            Console.ReadKey();
        }
    }
}
