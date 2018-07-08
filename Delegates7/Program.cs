using System;

// Анонимные (лямбда) методы.
/// + модификаторы ref/out в параметрах анонимных методов;

namespace Delegates
{
    // Создаем класс делегата.
    public delegate void MyDelegate(ref int a, ref int b, out int c);

    /// 01:16:40 - И в анонимных методах, и вообще при работе с делегатами, можем использовать аргументы ref и out;

    class Program
    {
        static void Main()
        {
            int summand1 = 1, summand2 = 2, sum;

            /// Создаем анонимный метод с тремя параметрами 
            MyDelegate myDelegate = delegate (ref int a, ref int b, out int c) { a++; b++; c = a + b; };  /// явно возвращаемого параметра нет, им выступает out;

            /// Вызываем метод, сообщенный с делегатом, передаем два аргумента summand1 и summand2. Третий аргумент получае суммарное значение первых друх;
            myDelegate(ref summand1, ref summand2, out sum);

            Console.WriteLine("{0} + {1} = {2}", summand1, summand2, sum);

            // Delay.
            Console.ReadKey();
        }
    }
}
