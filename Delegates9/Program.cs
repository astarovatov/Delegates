﻿using System;

// Лямбда выражения и лямбда операторы.
/// 01:26:53 - Пример показывает использование всех трех лямбда, 
/// анонимного метода, лямбда оператора, лямбда выражения, которые не принимают аргументов и не возращают никаких зачений;

namespace Delegates
{
    public delegate void MyDelegate();

    class Program
    {
        static void Main()
        {
            MyDelegate myDelegate;

            myDelegate = delegate { Console.WriteLine("Hello 1"); }; // Лямбда-Метод 

            myDelegate += () => { Console.WriteLine("Hello 2"); };   /// Лямбда-Оператор, без параметров, пустые аргументные скобки;
                                                                     /// 

            myDelegate += () => Console.WriteLine("Hello 3");        // Лямбда-Выражение.

            myDelegate();

            // Delay.
            Console.ReadKey();
        }
    }
}
/// Лямбда-выражение - это однооператорный лямбда-оператор. Поэтому он без фигурных скобок для тела выражения;
/// Лямбда-оператор - многоопператорное лямбда-выражение, т.е. в нем может быть множество операторов с разделителями в виде точки с запятой и все это дело 
/// заключается в фигурные скобки;
