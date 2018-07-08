using System;

// Делегаты.
/// Пример показывает, что тип делегата может выступать возвращаемым значением метода;

namespace Delegates
{
    delegate Delegate2 Delegate1();  // 1.

    /// 01:26:25 - Создаем класс-делегат с именем Delegate1.
    /// Метод, который будет сообщен с экземпляром данного класса делегата ничего не будет принимать и будет возвращать значение типа Delegate2.

    delegate void Delegate2();       // 2.

    /// Создаем класс-делегат с экземпляром которого можно сообщить метод, который ничего не будет принимать и ничег не будет возвращать;

    class Program
    {
        public static Delegate2 Method1()     // 1.   /// Метод ничего не принимает и возвращает значение с типом Delegate2
        {
            return new Delegate2(Method2);   /// создаем чемодан (экземпляр делегата), который порождается внутри метода Method1.
        }

        public static void Method2()          // 2.
        {
            Console.WriteLine("Hello world!");
        }

        static void Main()
        {
            Delegate1 delegate1 = new Delegate1(Method1);

            Delegate2 delegate2 = delegate1();   /// переменной delegate2 присваем возвращаемое значение метода, сообщенного с делегатом delegate1;

            delegate2();

            // Delay.
            Console.ReadKey();
        }
    }
}
