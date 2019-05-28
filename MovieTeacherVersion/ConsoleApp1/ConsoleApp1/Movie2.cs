using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Movie2
    {
        public int Id;
        public string Name;
        private string rate;
        public string Rate
            {
            get
                { return rate; }
            set
            {
                if (value == "Good" || value =="Excellent" || value == "Bad")
                {
                    rate = value;
                }
                else
                {
                    rate = "Not Rated correctly";
                }
            }
        }
    }
}
