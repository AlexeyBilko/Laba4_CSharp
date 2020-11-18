using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вариант 22

            try
            {
                Console.Write("Enter \'a\':  ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter \'b\':  ");
                double b = Convert.ToDouble(Console.ReadLine());
                if (a == b)
                {
                    Console.WriteLine("\'a\' shouldn't equal to \'b\'");
                }
                else
                {
                    Console.Write("Enter \'n\':  ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    double res;
                    for (int i = 1; i <= n; i++)
                    {
                        res = a + i * ((b - a) / n);
                        Console.WriteLine($"R({i})  =  {res}");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong parametrs!");
            }
        }
    }
}
