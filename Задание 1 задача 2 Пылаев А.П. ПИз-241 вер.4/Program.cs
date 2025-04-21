using System;

class Program
{
    static void Main()
    {
        int x;
        while (true)
        {
            Console.Write("Введите число x (не менее 100): ");
            string input = Console.ReadLine();

            bool isParsed = int.TryParse(input, out x);
            if (isParsed && x >= 100)
            {
                break;
            }
            else
            {
                Console.WriteLine("Введите число НЕ МЕНЬШЕ 100.");
            }
        }

        string xStr = x.ToString();

        if (xStr.Length < 3)                                                  // проверка, что число x больше или ровно 100
        {
            Console.WriteLine("Число должно содержать более двух цифр.");
            return;
        }

        char secondDigit = xStr[1];                                           // выбираем вторую цифру 

        string numberWithoutSecond = xStr[0] + xStr.Substring(2);             // удаляем вторую цифру из числа x

        string yString = numberWithoutSecond + secondDigit;                   // формируем число y, приписывая вторую цифру в конце получаемого числа

        int y = int.Parse(yString);                                           // преобразуем строку в число y

        Console.WriteLine("Значение числа y: " + y);
    }
}