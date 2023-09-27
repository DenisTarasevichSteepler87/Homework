// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int AckerFunction(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0)
    {
        return AckerFunction(M - 1, 1);
    }
    else
    {
        return AckerFunction(M - 1, AckerFunction(M, N - 1));
    }

}

System.Console.WriteLine("Введите M");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Функция Аккермана равна: {AckerFunction(M, N)}");