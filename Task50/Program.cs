// // Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// //и возвращает значение этого элемента или же указание, что такого элемента нет.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 1 7 -> такого числа в массиве нет

Console.WriteLine("Введите номер строки, от 1 до 6: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца, от 1 до 4: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [6,4]; // размер массива
FillArray(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("Такого элемента НЕТ");
}
else
{
    Console.WriteLine($"Значение элемента на {n} строке, во {m} столбце = {numbers[n-1,m-1]}");
}

PrintArray(numbers);

void FillArray(int[,] array) //заполнить массив
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(1, 20);
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
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}