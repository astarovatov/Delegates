using System;

// Анонимные (лямбда) методы.
/// + входные/выходные параметры анонимных методов;

namespace Delegates
{
    // Создаем класс делегата.
    public delegate int MyDelegate(int a, int b);

    class Program
    {
        static void Main()
        {
            int summand1 = 1, summand2 = 2, sum = 0;

            MyDelegate myDelegate = delegate (int a, int b) { return a + b; };   /// вариант создания анонимного метода с 2-мя входными параметрами;
                                                                                 /// формат метода соответствует шаблону делегата
                                                                                 /// формату класса-делегата, требованиям класса-делегата;

            sum = myDelegate(summand1, summand2);  /// переменной sum присваиваем возвращаемое значение метода сообщенного с делегатом myDelegate, которому 
                                                   /// в качестве аргументов передаем переменные summand1, summand2;

            Console.WriteLine("{0} + {1} = {2}", summand1, summand2, sum);

            // Delay.
            Console.ReadKey();
        }
    }
}
/// 01:16:08 - Видимо, что анонимные методы могут содержать как аргументы, также и возвращать какие-то возвращаемые значения;