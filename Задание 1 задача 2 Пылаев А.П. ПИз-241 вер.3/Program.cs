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
            if (isParsed && x > 100)
            {
                break; 
            }
            else
            {
                Console.WriteLine("Введите число НЕ МЕНЬШЕ 100.");
            }

            Console.WriteLine($"Вы ввели число: {x}");

            char secondDigit = x[1];                                  // Теперь эта часть полностью не работает, переделать!!!!

            string numberWithoutSecond = x[0] + x.Substring(2);        

            string yString = numberWithoutSecond + secondDigit;       

            int y = int.Parse(yString);                               

            Console.WriteLine("Значение числа n: " + y);
        }
    }
}