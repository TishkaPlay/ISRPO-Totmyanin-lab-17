Random rand = new Random();
int n = 10;
int[] X = new int[n];
Console.WriteLine("Заполнение массива");

for (int i = 0; i < n; i++)
{
    X[i] = rand.Next(-10, 11);
    Console.WriteLine($"a[{i + 1}] = {X[i]}");
}      

