class Program
{
    static void Main()
    {
        Console.WriteLine("Калькулятор");

        Console.Write("Введите первое число: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        string znak;
        bool calculationDone = false;

        while (!calculationDone)
        {

            Console.Write("Введите знак: ");
            znak = Console.ReadLine();

            Console.Write("Введите второе число: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            if (znak == "+")
            {
                int result = n1 + n2;
                Console.WriteLine("Результат: " + result);
                calculationDone = true;
            }
            else if (znak == "-")
            {
                int result = n1 - n2;
                Console.WriteLine("Результат: " + result);
                calculationDone = true;
            }
            else if (znak == "/")
            {
                if (n2 != 0)
                {
                    int result = n1 / n2;
                    Console.WriteLine("Результат: " + result);
                }
                else
                {
                    Console.WriteLine("Ошибка: Деление на ноль!");
                }
                calculationDone = true;
            }
            else if (znak == "*")
            {
                int result = n1 * n2;
                Console.WriteLine("Результат: " + result);
                calculationDone = true;
            }
            else
            {
                Console.WriteLine("Неверный знак. Попробуйте снова.");
            }
        }

    }
}