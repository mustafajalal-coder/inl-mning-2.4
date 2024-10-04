using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inlämning_2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ange lön för den första anställda");
            double lön1= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ange lön för den andra anställda ");
            double lön2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ange lön för den tredje anställd");
            double lön3 = Convert.ToDouble(Console.ReadLine());

            double medellön = (lön1 + lön2 + lön3) / 3;

            Console.WriteLine($"medellön för de anställda är: {medellön} kr"); 


        }
    }
}
