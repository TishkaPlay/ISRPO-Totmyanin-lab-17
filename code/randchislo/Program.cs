class Task3_GuessGame
{
    static void Main()
    {
        bool playAgain = true;
        
        while (playAgain)
        {
            PlayGame();
            
            Console.WriteLine("\n=== Сыграть еще раз? ===");
            Console.Write("Введите 'да' для продолжения: ");
            string answer = Console.ReadLine().ToLower();
            
            playAgain = (answer == "да" || answer == "d" || answer == "yes");
        }
        
        Console.WriteLine("Спасибо за игру!");
    }
    
    static void PlayGame()
    {
        Random random = new Random();
        int numberToGuess = random.Next(1, 101);
        int attempt = 0;
        int guess = 0;
        bool validInput = false;
        
        Console.WriteLine("\n=== Игра 'Угадай число' ===");
        Console.WriteLine("Я загадал число от 1 до 100. Попробуй угадать!");
        
        while (guess != numberToGuess)
        {
            while (!validInput)
            {
                Console.Write("\nВаша попытка: ");
                string input = Console.ReadLine();
                
                if (int.TryParse(input, out guess))
                {
                    if (guess >= 1 && guess <= 100)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Пожалуйста, введите число от 1 до 100!");
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный ввод! Введите целое число.");
                }
            }
            
            validInput = false;
            attempt++;
            
            if (guess < numberToGuess)
            {
                Console.WriteLine("↑ Больше!");
            }
            else if (guess > numberToGuess)
            {
                Console.WriteLine("↓ Меньше!");
            }
        }

        Console.WriteLine($"\n✓ Поздравляю! Вы угадали число {numberToGuess}!");
        Console.WriteLine($"Количество попыток: {attempt}");

        if (attempt <= 5)
        {
            Console.WriteLine("Отличный результат! 🌟");
        }
        else if (attempt <= 10)
        {
            Console.WriteLine("Хороший результат! 👍");
        }
        else
        {
            Console.WriteLine("Неплохо, но можно лучше! 💪");
        }
    }
}