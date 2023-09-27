// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30

 int SumNumbers(int M, int N)
{
    if (M > N)
        return 0;

    else return M+ SumNumbers(M+1, N) ;

}

System.Console.WriteLine("Введите M");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Cумма натуральных элементов в промежутке от {M} до {N} равна: {SumNumbers(M, N)}");