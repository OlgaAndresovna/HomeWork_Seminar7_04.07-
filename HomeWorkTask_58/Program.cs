//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int m = 4;
int n = 4;

int[,] matrixА = new int[m, n];

Console.WriteLine("Матрица - А");
for (int i = 0; i < m; i++) // цикл по строкаи
{
    for (int j = 0; j < n; j++) //цикл по столбцам
    {
        matrixА[i, j] = new Random().Next(1, 10); //заполнение массива 
        Console.Write(matrixА[i, j] + " ");
    }
    Console.WriteLine();
}

int[,] matrixB = new int[m, n];

Console.WriteLine("Матрица - B");
for (int i = 0; i < m; i++) // цикл по строкаи
{
    for (int j = 0; j < n; j++) //цикл по столбцам
    {
        matrixB[i, j] = new Random().Next(1, 10); //заполнение массива 
        Console.Write(matrixB[i, j] + " ");
    }
    Console.WriteLine();
}

int[,] product = CompositionMatrix(matrixА, matrixB); //произведения двух матриц
int[,] CompositionMatrix(int[,] matrixА, int[,] matrixB)
{
    int[,] product = new int[matrixА.GetLength(0), matrixА.GetLength(1)];
    for (int i = 0; i < matrixА.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            product[i, j] = matrixА[i, j] * matrixB[i, j];
        }
    }
    return product;
}
Console.WriteLine("Произведение матриц А*В ");
void PrintMatrix(int[,] array) // заполнение новой матрицы
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
PrintMatrix(product);