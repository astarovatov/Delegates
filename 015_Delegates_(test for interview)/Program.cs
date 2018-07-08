
/// 8 заданий по C#, которые могут попасться на собеседовании
/// https://proglib.io/p/8-csharp-questions/

/// 6. Какой результат выдаст программа ниже?

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_Delegates__test_for_interview_
{
    class Program
    {
        delegate void Printer();

        static void Main()
        {
            List<Printer> printers = new List<Printer>();
            for (int i = 0; i < 10; i++)
            {
                printers.Add(delegate { Console.WriteLine(i); });  /// в таком виде результат на выходе сожержит только 10 повторяющихся десяток;

                //int j = i;
                //printers.Add(delegate { Console.WriteLine(j); });   /// а при таком варианте на выходе получаем список от 0 до 9;
            }

            foreach (var printer in printers)
            {
                printer();
            }
            // Delay.
            Console.ReadKey();
        }
    }
}
/// Ответ:
/// Эта программа выведет число «10» десять раз.
/// И вот почему: delegate добавляется циклически, однако параметр i передаётся по ссылке. Поэтому, по окончании цикла i равно 10, и при каждом
/// запуске delegate будет выводиться работать с этим значением;

/// This program will output the number 10 ten times.
/// Here’s why: The delegate is added in the for loop and “reference” (or perhaps “pointer” would be a better choice of words) to i is stored, rather than 
/// the value itself.Therefore, after we exit the loop, the variable i has been set to 10, so by the time each delegate is invoked, the value passed to all
/// of them is 10.







