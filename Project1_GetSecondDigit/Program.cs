// Программа, принимающая трёхзначное число и показывающая вторую цифру
// 456 -> 5
// 782 -> 8
// 918 -> 1
int GetSecondDigit(int number)
{
    int secondDigit = number / 10 % 10;
    return secondDigit;
}
Console.WriteLine("Введите трёхзначное число");
int number = int.Parse(Console.ReadLine()!);
int secondDigit = GetSecondDigit(number);
Console.WriteLine("Вторая цифра числа: " + secondDigit);