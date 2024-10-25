using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static int Ackermann(int m, int n) //O(2^(2^(...)))
        {
            if (m == 0) return n + 1; //Если m == 0
            if (m > 0 && n == 0) return Ackermann(m - 1, 1); // Если n == 0
            return Ackermann(m - 1, Ackermann(m, n - 1));    // Рекурсивное вычисление акерманна
        }
        static void Main()
        {
            Console.WriteLine("Аккерман(2, 3): " + Ackermann(2, 3));   // Ожидается 9
            Console.WriteLine("Аккерман(3, 2): " + Ackermann(3, 2));   // Ожидается 29
        }
    }
}
