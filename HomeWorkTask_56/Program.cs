// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int m = 4;
int n = 8;
int[,] matrix = new int[m, n];
for (int i = 0; i < m; i++) 
{
    for (int j = 0; j < n; j++) 
    {
        matrix[i, j] = new Random().Next(1, 10); 
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

int minsum = Int32.MaxValue; //представления максимального значения 
int indexLine = 0;
int sum = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = sum + matrix[i, j];        
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexLine++;
    }
}

Console.WriteLine($"Строка с наименьшей суммой элементов под номером: " + (indexLine) + ", с суммой элементов = " + (minsum));