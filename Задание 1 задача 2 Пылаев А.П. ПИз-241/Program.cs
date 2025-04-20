using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число x (не менее 100): ");
        string x = Console.ReadLine();                            // Добавить проверку числа x (больше ли оно)
                                                                  
        char secondDigit = x[1];                                  // выбираем вторую цифру числа x
                                
        string numberWithoutSecond = x[0] + x.Substring(2);       // удаляем вторую цифру из начального числа 
                                                           
        string yString = numberWithoutSecond + secondDigit;       // генерируем число y, добавляя удаленную цифру в конце
                                                           
        int y = int.Parse(yString);                               // конвертируем строку в число

        Console.WriteLine("Значение числа n: " + y);
    }
}