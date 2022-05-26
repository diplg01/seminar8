// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.Console.Clear();
Console.Write("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чисто стобцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] mass = new int[m, n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(1, 9);
        Console.Write(mass[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int save;
for (int i = 0; i < mass.GetLength(1); i++)
{
    //Console.Write(mass[0, i] + " ");
    save = mass[0,i];
    //Console.Write(mass[mass.GetLength(0)-1,i]+" ");
    mass[0,i] = mass[mass.GetLength(0)-1,i];
    mass[mass.GetLength(0)-1,i] = save;
}

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write(mass[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();