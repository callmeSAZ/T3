using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //دریافت شعاع و بدست آوردن محیط و مساحت دایره
            Console.WriteLine("Shoaa ra vared konid: ");
            float SHoaa = float.Parse(Console.ReadLine());
            Console.WriteLine("Shoaa={0}",SHoaa);
            float P = 3.14F;
            Console.WriteLine("P={0}",P);

            Console.WriteLine("Masahat={0}", SHoaa * SHoaa * P);
            Console.WriteLine("Mohit={0}", SHoaa * 2 * P);
            







            Console.ReadKey();
        }
    }
}
