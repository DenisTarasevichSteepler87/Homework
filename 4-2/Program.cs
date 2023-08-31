// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// System.Console.WriteLine("Введите число A");
// int A = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// while (A > 0)
// {
//     int result = A % 10;
//     sum = sum + result;
//     A = A / 10;
// }

// System.Console.WriteLine(sum);


int SumDigits(int upper)
{
    int result = 0;
    if (upper < 0)
        upper = -upper;
    while (upper > 0)
    {
        int rest = upper % 10;
        result = result + rest;
        upper = upper / 10;
    }
    return result;
}

System.Console.WriteLine("Введите число ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Cумма цифр в цисле {A} равно {SumDigits(A)}");
