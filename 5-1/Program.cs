// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}
void PrintArray(int[] array)
{
    foreach (int item in array)
        System.Console.Write($"{item} ");
    System.Console.WriteLine();
}
int NumbersArray(int[] array)
{
        int result= 0;
       
    for (int i = 0; i < array.Length; i++)
    {
        int even=array[i] % 2;
        if (even == 0)
        result=result+1;
    }
    return result;
}
int[] array = new int[12];
FillArray(array);
PrintArray(array);
NumbersArray(array);
System.Console.WriteLine($"Kоличество четных чисел в массиве равно {NumbersArray(array)}");

