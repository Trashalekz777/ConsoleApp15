using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static string PoiskVMassive(int[,] massiv, int chislo, int stroka, int stolbec) //O(n * m)
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

            Console.WriteLine(PoiskVMassive(array, 5, 0, 0)); // Ожидается "Найдено на позиции: 1, 1"
            Console.WriteLine(PoiskVMassive(array, 10, 0, 0)); // Ожидается "Не найдено"
        }
    }
}
