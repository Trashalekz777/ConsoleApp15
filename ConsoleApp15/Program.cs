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
      
        
        static int Fibonacci(int chislo) //O(2^n)
        {
            if (chislo == 0) return 0; // Если число == 0
            if (chislo == 1) return 1; // Если число == 1 
            return Fibonacci(chislo - 1) + Fibonacci(chislo - 2); // Рекурсивное вычисление фибоначи
        }
          
          static string PoiskVMassive(int[,] massiv, int chislo, int stroka, int stolbec) //O(n * m) оптимизации не требуется.
        {
            if (stroka >= massiv.GetLength(0)) return "Не найдено"; // Выход за пределы массива
            if (stolbec >= massiv.GetLength(1)) return PoiskVMassive(massiv, chislo, stroka + 1, 0); // Переход к новой строке
            if (massiv[stroka, stolbec] == chislo) return $"Найдено на позиции: {stroka}, {stolbec}"; // Число найдено
            return PoiskVMassive(massiv, chislo, stroka, stolbec + 1); // Поиск в текущей строке
        }

        static void Main()
        {
            int[,] array = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 } };

            Console.WriteLine("Фибоначчи(5): " + Fibonacci(5));   // Ожидается 5
            Console.WriteLine("Фибоначчи(10): " + Fibonacci(10)); // Ожидается 55
            Console.WriteLine("Аккерман(2, 3): " + Ackermann(2, 3));   // Ожидается 9
            Console.WriteLine("Аккерман(3, 2): " + Ackermann(3, 2));   // Ожидается 29
            Console.WriteLine(PoiskVMassive(array, 5, 0, 0)); // Ожидается "Найдено на позиции: 1, 1"
            Console.WriteLine(PoiskVMassive(array, 10, 0, 0)); // Ожидается "Не найдено"
        }
    }
}