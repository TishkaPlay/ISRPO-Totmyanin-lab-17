//Начало
Console.WriteLine("Подъем по лестнице");
//Ввод данных
Console.Write("На какой этаж нужно подняться?: ");
int targetFloor = Convert.ToInt32(Console.ReadLine());
int currentFloor = 1;
Console.WriteLine("Начинаем подъём!");
//Цикл while
while (currentFloor < targetFloor)
{
    currentFloor++;
    Console.WriteLine($"Поднялись на {currentFloor}-й этаж");
}
//Вывод результата
Console.WriteLine($"Вы достигли {targetFloor}-го этажа!");
Console.WriteLine("Конец программы");