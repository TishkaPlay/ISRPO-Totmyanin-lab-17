class Task1_BMI
{
    static void Main()
    {
        Console.WriteLine("=== Калькулятор ИМТ ===");

        Console.Write("Введите ваш вес (кг): ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите ваш рост (м): ");
        double height = Convert.ToDouble(Console.ReadLine());

        double bmi = weight / (height * height);
        
        string category;
        string recommendation;
        
        if (bmi < 18.5)
        {
            category = "Недостаточный вес";
            recommendation = "Рекомендуется увеличить калорийность рациона и проконсультироваться с врачом.";
        }
        else if (bmi >= 18.5 && bmi < 25)
        {
            category = "Нормальный вес";
            recommendation = "Отлично! Продолжайте поддерживать здоровый образ жизни.";
        }
        else if (bmi >= 25 && bmi < 30)
        {
            category = "Избыточный вес";
            recommendation = "Рекомендуется пересмотреть рацион и увеличить физическую активность.";
        }
        else
        {
            category = "Ожирение";
            recommendation = "Необходимо обратиться к врачу для разработки плана снижения веса.";
        }
        
        Console.WriteLine($"\nВаш ИМТ: {bmi:F2}");
        Console.WriteLine($"Категория: {category}");
        Console.WriteLine($"Рекомендация: {recommendation}");
    }
}