/// https://docs.microsoft.com/ru-ru/dotnet/csharp/programming-guide/concepts/covariance-contravariance/variance-in-delegates

/// ОБЪЕДИНЕНИЕ ВАРИАТИВНЫХ УНИВЕРСАЛЬНЫХ МЕТОДОВ-ДЕЛЕГАТОВ;
/// Не следует объединять вариантные делегаты. Метод Combine НЕ поддерживает преобразование вариантных делегатов и ожидает делегаты того же самого типа. Это может вызвать ИСКЛЮЧЕНИЕ ВРЕМЕНИ ВЫПОЛНЕНИЯ при объединении делегатов с помощью метода Combine или оператора +, как показано в следующем примере кода.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L091_Combining_Variant_Generic_Deleg
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<object> actObj = x => Console.WriteLine("object: {0}", x);  /// по умолчанию у делегата Action обобщенный параметр является контрвариантным 
                                                                               /// т.е. с ключевым словом 'in' ( public delegate void Action<in T>(T obj); )
            Action<string> actStr = x => Console.WriteLine("string: {0}", x);


            // All of the following statements throw exceptions at run time.  

            // Action<string> actCombine = actStr + actObj;  /// !!! Делегаты должны принадлежать к одному типу !!!
            // actStr += actObj;                             /// Message = Делегаты должны принадлежать к одному типу.
            // Delegate.Combine(actStr, actObj);

            Action<string> actStr1 = actObj;

            Console.ReadLine();
        }
    }
}
