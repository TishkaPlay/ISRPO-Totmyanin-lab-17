using System;

class Task2_isPrime
{
    static bool IsPrime(int number)
    {
        if (number < 2)
            return false;
        
        if (number == 2)
            return true;
        
        if (number % 2 == 0)
            return false;
        
        for (int i = 3; i * i <= number; i += 2)
        {
            if (number % i == 0)
                return false;
        }
        
        return true;
    }
    
    static void Main()
    {
        Console.WriteLine("=== Проверка числа на простоту ===");
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        if (IsPrime(number))
        {
            Console.WriteLine($"Число {number} является ПРОСТЫМ");
        }
        else
        {
            Console.WriteLine($"Число {number} НЕ является простым");
        }

        Console.WriteLine("\n=== Тестирование ===");
        int[] testNumbers = { 2, 3, 4, 5, 10, 11, 13, 17, 20, 23, 29, 97, 100 };
        
        foreach (int num in testNumbers)
        {
            Console.WriteLine($"{num,3}: {(IsPrime(num) ? "Простое" : "Составное")}");
        }
    }
}