//   Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

void FillArray(double[] array)
{

    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100) + Math.Round(new Random().NextDouble(), 2);
}

void PrintArray(double[] array)
{
    foreach (double item in array)
        System.Console.Write($"{item} ");
    System.Console.WriteLine();
}



double DifferenceArray(double[] array)
{
    double result = 0;
    double max = array[0];
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] < min)
            min = array[i];
        if (array[i] > max)
            max = array[i];
        result = max - min;
    }
    return result;
}

double[] array = new double[5];
FillArray(array);
PrintArray(array);
DifferenceArray(array);
System.Console.WriteLine($"Разницу между максимальным и минимальным элементов массива равна {DifferenceArray(array)}");
