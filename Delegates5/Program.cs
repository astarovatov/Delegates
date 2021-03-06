﻿using System;

// Анонимные (лямбда) методы.
/// + техника предположения делегатов;
/// 
namespace Delegates
{
    // Создаем класс делегата.
    public delegate void MyDelegate();

    class Program
    {
        static void Main()
        {
            // Создаем экземпляр класса-делегата MyDelegate и сообщаем с ним анонимный метод.
            MyDelegate myDelegate = delegate { Console.WriteLine("Hello world!"); };  /// оторванное от сигнатуры тело метода 
                                                                                      /// delegate { Console.WriteLine("Hello world!"); } - это анонимный метод;

            /// MyDelegate myDelegate = new MyDelegate(delegate { Console.WriteLine("Hello world!"); }); 

            /// на стр 20. показал классический подход, а выше (строка 15) был использован сокращенный синтаксис;
            /// 01:07:05 - ключевое слово delegate может быть использовано в 2-х случаях
            /// - когда создаем класс делегата;
            /// - когда создаем метод без имени (анонимный метод);
            
            /// Можем сообщать анонимные методы с делегатом как через конструктор, так и используя ТЕХНИКУ ПРЕДПОЛОЖЕНИЯ ДЕЛЕГАТОВ, строка 15;
            /// при этом как видно, явно не указывается вызов конструктора, т.е. это подразумевается само собой, что создается экземпляр делегата и анонимный метод сообщается с ним;

            /// 01:12:40 - Мы понимаем, что если мы создаем анонимный метод, то у нас все равно будет создаваться экземпляр определенного делегата;

            // Вызов анонимного метода, сообщенного с делегатом.
            myDelegate();

            // Delay.
            Console.ReadKey();
        }
    }
}
