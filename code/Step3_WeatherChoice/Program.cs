//Начало
Console.WriteLine("Выбор одежды по погоде");
Console.Write("Введите текущую температуру (℃): ");
int temperature = Convert.ToInt32(Console.ReadLine());
// Условие (ветвление)
if (temperature >= 20)
{
    // Условие ИСТИННО (ДА)
    Console.WriteLine("Наденьте лёгкую одежду");
}
else
{
    //Условие ЛОЖНО (НЕТ)
    Console.WriteLine("Наденьте тёплую одежду");
}
//Конец
Console.WriteLine("Хорошего дня!");