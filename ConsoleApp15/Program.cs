using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static int Fibonacci(int chislo) //O(2^n)
        {
            if (chislo == 0) return 0; // Если число == 0
            if (chislo == 1) return 1; // Если число == 1 
            return Fibonacci(chislo - 1) + Fibonacci(chislo - 2); // Рекурсивное вычисление фибоначи
        }

        static void Main()
        {
            Console.WriteLine("Фибоначчи(5): " + Fibonacci(5));   // Ожидается 5
            Console.WriteLine("Фибоначчи(10): " + Fibonacci(10)); // Ожидается 55
        }
    }
}
