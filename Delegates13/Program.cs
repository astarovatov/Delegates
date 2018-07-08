
/// 01:50:02 - Техника предположения делегата нужна для событийной модели.
/// Событийная модель как раз и строится на использовании делегатов;

using System;

// Делегаты. (Предположение делегата)

namespace Delegates
{
    static class MyClass
    {
        public static void Method()
        {
            Console.WriteLine("Строку вывел метод сообщенный с делегатом.");
        }
    }
       
    public delegate void MyDelegate(); 

    class Program
    {
        static void Main()
        {
           // MyDelegate myDelegate = new MyDelegate(MyClass.Method);
            
            MyDelegate myDelegate = MyClass.Method;   // Предположение делегата. /// этот код эквивалентен с кодом на строке 21;
            myDelegate();   /// вызываем метод, сообщенный с делегатом; Можно с Invoke(), можно без него;

            // Delay.
            Console.ReadKey();
        }
    }
}























