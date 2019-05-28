using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie
{
    public class Movies
    {
        public string name;
        private string rate;
        private string[] propeRate = {"Excellent","Good","Bad"};


        public Movies(string rate)
        {
            this.rate = rate;
        }

        public string getRate()
        {
            return rate;
        }

        public void setRate(string value)
        {
            bool isProperRate = false;

            foreach (string element in propeRate)
            {
                if (value == element)
                {
                    isProperRate = true;
                }
            }

            if (isProperRate)
            {
                this.rate = value;

            }
            else
            {
                this.rate = "not rate property";
            }

        }

        

        public void outPut(string name)
        {
            Console.WriteLine("Movie name is " + name + "and rate is " + getRate());
        }
      


    }
}
