Console.WriteLine("Поиск максимума");
int n = 10;
int[] X = new int[n];
int Max = X[0]; 
int NMax = 1;

for (int i = 1; i < n; i++)
{
    if (X[i] > Max)
    {
        Max = X[i];
        NMax = i + 1;
    }
}

Console.WriteLine($"Максимальное значение (Max): {Max}");
Console.WriteLine($"Номер максимального элемента (NMax): {NMax}");
