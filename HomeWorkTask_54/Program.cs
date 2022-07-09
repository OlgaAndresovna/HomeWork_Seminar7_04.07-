// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Write("Введите m ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n]; // m строк, n столбцов

Console.WriteLine("Исходный массив");
for (int i = 0; i < m; i++) // цикл по строкаи
{
    for (int j = 0; j < n; j++) //цикл по столбцам
    {
        matrix[i, j] = new Random().Next(1, 10); //заполнение массива 
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < matrix.GetLength(1) - 1; z++)
        {
            if (matrix[i, z] < matrix[i, z + 1]) //для изменения сортировки поменять знак < на противоположный
            {
                int temp = 0;
                temp = matrix[i, z];
                matrix[i, z] = matrix[i, z + 1];
                matrix[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями");

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine("");
    }
