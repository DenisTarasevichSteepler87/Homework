//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

System.Console.WriteLine("Введите количество строк первой матрицы:");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов первой матрицы  и строк второй матрицы :");
int colsrows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов второй матрицы :");
int cols = Convert.ToInt32(Console.ReadLine());

void WorkMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secondMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1,3);
    }
  }
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      System.Console.Write(array[i,j] + " ");
    }
    System.Console.WriteLine();
  }
}
int[,] firstMartrix = new int[rows, colsrows];
FillArray(firstMartrix);
System.Console.WriteLine($"Первая матрица:");
PrintArray(firstMartrix);
System.Console.WriteLine();
int[,] secondMartrix = new int[colsrows, cols];
FillArray(secondMartrix);
System.Console.WriteLine($"Вторая матрица:");
PrintArray(secondMartrix);

int[,] resultMatrix = new int[rows,cols];

WorkMatrix(firstMartrix, secondMartrix, resultMatrix);
System.Console.WriteLine();
System.Console.WriteLine($"Произведение первой и второй матриц:");
PrintArray(resultMatrix);
