using System;

// Комбинированные (групповые) делегаты.
/// Техника комбинации либо раскомбинации делегатов;
/// Делегаты являются immutable types (неизменяемыми типами), пояснение ниже.

namespace Delegates
{
    public delegate void MyDelegate();

    class Program
    {
        // Методы.
        public static void Method1()
        {
            Console.WriteLine("Method1");
        }

        public static void Method2()
        {
            Console.WriteLine("Method2");
        }

        public static void Method3()
        {
            Console.WriteLine("Method3");
        }

        static void Main()
        {
            MyDelegate myDelegate = null;  /// помним, что null - значение по умолчанию для всех ссылочных типов;
            MyDelegate myDelegate1 = new MyDelegate(Method1);    /// сообщаем экземпляр делегата MyDelegate с методом Method1;
            MyDelegate myDelegate2 = new MyDelegate(Method2);
            MyDelegate myDelegate3 = new MyDelegate(Method3);

            // Комбинируем делегаты.
            myDelegate = myDelegate1 + myDelegate2 + myDelegate3;

            /// Здесь, при работе с делегатами оператор "+" - это знак комбинации или знак группировки.
            /// 49:17 - описание низкоуровневого подхода с графиком от ведущего по формированию группового делегата; 
            /// Якобы на собеседовании может быть вопрос описать процесс создания комбинированного делегата.
            /// myDelegate1 + myDelegate2 дают промежуточный делегат по слабой ссылке, который уничтожается сборщиком мусора.
            /// 52:16 - в итоге получили новый экземпляр делегата (уже по сильной ссылке), который содержит в себе 3 указателя на 3 разных метода. 
            /// Мы получили чемодан, куда вложены 3 метода, стараемся не использовать слово "указатель". Указатель - адрес метода в памяти.
            /// Создали комбинацию из 3-х делегатов.


            Console.WriteLine("Введите число от 1 до 7");
            string choice = Console.ReadLine();  /// принимаем ввод от пользователя и помещаем его в переменную choice;

            switch (choice)   /// создаем переключатель switch и в качестве выражения селектора передаем значение, введенное пользователем;
            {
                case "1":
                    {
                        myDelegate1.Invoke();
                        break;
                    }
                case "2":
                    {
                        myDelegate2.Invoke();
                        break; 
                    }
                case "3":
                    {
                        myDelegate3.Invoke();
                        break;
                    }
                case "4":
                    {
                        MyDelegate myDelegate4 = myDelegate - myDelegate1;   /// "-" знак разгруппировки
                        myDelegate4.Invoke();
                        break;
                    }
                case "5":
                    {
                        MyDelegate myDelegate5 = myDelegate - myDelegate2;   /// открепляем второй метод; при этом переменная myDelegate не изменяется (immutable).
                        myDelegate5.Invoke();
                        break;
                    }
                case "6":
                    {
                        MyDelegate myDelegate6 = myDelegate - myDelegate3;
                        myDelegate6.Invoke();
                        break;
                    }
                case "7":
                    {
                        myDelegate.Invoke();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Вы ввели недопустимое значение.");
                        break;
                    }
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
/// 01:00:10 - В случае использования техники комбинации либо раскомбинации у нас не происходит изменения существующих объектов, а происходит формирование нового объекта, а существующих делегаты у нас не меняются.
/// Объекты, которые ведут себя именно вот таким образом, которые практически мы не можем  изменить, типы таких объектов называются в программировании неизменяемыми.
/// Неизменяемые объекты, неизменяемые типы объектов, на анлийском -  immutable.
/// Строки также являются immutable tyoe.
/// Делегаты являются immutable types (неизменяемыми типами).

















