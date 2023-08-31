// Напишите программу, которая задаёт массив из 8 элементов случайных целых чисел от 1 до 50 и выводит их на экран.


// int[] array= new int[8];
// for(int i=0; i < array.Length; i++)
// {
//     Random rnd = new Random();
//     array[i] = rnd.Next(0, 51);
// }
// for(int i=0; i < array.Length; i++)
//  System.Console.Write($"{array[i]} ");


int[] Filling()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        Random rnd = new Random();
        array[i] = rnd.Next(0, 51);
    }
    return array;
}

void Print(int[] array)
{
for (int i = 0; i < array.Length; i++)
    System.Console.Write($"{array[i]} ");
}

Print(Filling());
