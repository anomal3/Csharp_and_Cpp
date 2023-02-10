using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace charpcpp
{
    internal class Program
    {

        [DllImport("cppcsharp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DisplayHello();

        [DllImport("cppcsharp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Multyply(float a, float b);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this is DLL на языке C#\n");
            DisplayHello();
            Console.WriteLine("Теперь посчитаем на с++! Вводим два дробных числа. Ввели первое жмём enter");

            float a = (float)Convert.ToDouble(Console.ReadLine().Replace(".", ","));
            Console.WriteLine();
            float b = (float)Convert.ToDouble(Console.ReadLine().Replace(".", ","));

            Multyply(a, b);

            Console.ReadLine();
        }
    }
}
