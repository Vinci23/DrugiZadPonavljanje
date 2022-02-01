using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugiZadPonavljanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int godina1 = 1900;
            Console.WriteLine("Prijestupne godine: ");
            for (int i = godina1;i < 2100;i++)
            {
                if(i % 400==0 || i % 4 == 0  &&  i % 100!=0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
