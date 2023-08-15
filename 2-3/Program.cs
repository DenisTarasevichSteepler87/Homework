// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int num3(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
bool num1(int Day)
{
    if (Day > 5)
    {
        return true;
    }
    return false;
}
bool num2(int num)
{
    if (num > 0 && num <= 7)
    {
        return true;
    }
    Console.WriteLine("Это не день недели!");
    return false;
}
int Day = num3("Введите день недели >");
if (num2(Day))
{
    if (num1(Day))
    {
        Console.WriteLine("Наконец-то выходной");
    }
    else
    {
        Console.WriteLine("Придется поработать");
    }
}
