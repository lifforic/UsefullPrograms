using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            //gorna chast
            for (int row = 0; row <a-1; row++)
            {
                Console.Write(new string(' ',a-1-row));
                for (int i = 0; i < row+1; i++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            //sredna chast
            for (int i = 0; i < a; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
            //dolna chast
            for (int row = 0; row < a-1; row++)
            {
                Console.Write(new string(' ',row+1));
                for (int i = 0; i < (a-1)-row; i++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
