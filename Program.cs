using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string t;
                double p, s, a, p1;
                Console.Write("Введите периметр = ");
                t = Console.ReadLine();
                p1 = double.Parse(t);
                p = p1 / 2;
                a = p1 / 3;
                s = Math.Sqrt(p*Math.Pow(p-a,3));
                Console.WriteLine("Сторона\tПлощадь");
                Console.Write("{0:0.00}",a);
                Console.WriteLine("\t{0:0.00}",s);
            }
            catch (FormatException e)
            {
                Console.WriteLine("An format exception was thrown:{0}",e.Message);
                Console.ReadKey();
            }
        }
    }
}
