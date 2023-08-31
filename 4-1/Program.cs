// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3?)
// 2, 4 -> 16


// System.Console.WriteLine("Введите число A");
// int A = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите натуральную степень B");
// int B = Convert.ToInt32(Console.ReadLine());
// int result = 1;
// for (int i = 0; i < B; i++)
//     result = result * A;

// System.Console.WriteLine(result);





int Degree(int upper1, int upper2)
{
    int result = 1;
    for (int i = 0; i < upper2; i++)
        result = result * upper1;
    return result;
}

System.Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите натуральную степень B");
int B = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Число {A} возведенное в натуральную степень {B} равно {Degree(A, B)}");
