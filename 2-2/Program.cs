//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int num3(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int num1(int num)
{
    while (num > 999)
    {
        num /= 10;
    }
    return num % 10;
}
bool num2(int num)
{
    if (num < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}
int num = num3("Введите число > ");
if (num2(num))
{
    Console.WriteLine(num1(num));
}