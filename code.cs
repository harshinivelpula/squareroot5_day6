using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squarerootd6
{
    public class code
    {
        public static void main(String[] args)
        {
            double c = double.parseDouble(args[0]);

            double epsilon = 1e-15;    
            double t = c;              

            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2.0;
            }
            Console.WriteLine(t);
        }
    }
}
