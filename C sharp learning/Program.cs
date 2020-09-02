using System;
using System.Collections.Generic; //массив, списки.
using System.ComponentModel;
using System.Globalization;
using System.Net;

namespace C_sharp_learning
{
    class MainClass
    {
        static void Main(string[] args) //метод срабатывает при старте программы
        {
            WrireHello("Hi!");
            Console.WriteLine("Write first number.");
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine()); 
            int result = Summ(first, second);
            Console.WriteLine("Result is -" + result);
            Console.ReadKey();
        }

        public static void WrireHello(string str)
        {
           // str = "Hello, World";
            Console.WriteLine(str);
        }

        public static int Summ(int x, int y)
        {
            return x + y;         
        }
        

    }
}
