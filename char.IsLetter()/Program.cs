using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @char.IsLetter__
{
    class Program
    {
        static void Main(string[] args)
        {
            bool res;
            char deger = '2';
            Console.WriteLine("Değer = " + deger);
            res = Char.IsLetter(deger);
            Console.WriteLine("Girilen değer harf mi? = " + res);


            Console.ReadLine();
        }
    }
    }
}
