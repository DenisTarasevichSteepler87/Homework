// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

System.Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов:");
int cols = Convert.ToInt32(Console.ReadLine());

int SumElements(int[,] array, int i)
{
    int sum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    return sum;
}

void FillArray(int[,] array)
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
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}
System.Console.WriteLine();
System.Console.WriteLine($"Двумерный массив: ");
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);

int minSumLine = 0;
int sumLine = SumElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumLine = SumElements(array, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}
System.Console.WriteLine($"{minSumLine + 1} - строкa с наименьшей суммой ({sumLine}) элементов ");