using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program64
{
    internal class Program
    {
        static void Main()
        {
            bool same = typeof(int) == typeof(Int32);
            Console.WriteLine($"Результат сравнения типов: {same}"); // выведет True
        }
    }
}