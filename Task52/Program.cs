// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] numbers = new int[4, 4]; // размер массива
FillArray(numbers);

for (int j = 0; j < numbers.GetLength(1); j++)

{ 
    double result = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        result = (result + numbers[i, j]);
    }
    result = result / 4;

    Console.Write(result + " ");
}
Console.WriteLine();
PrintArray(numbers);

void FillArray(int[,] array) //заполнить массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}