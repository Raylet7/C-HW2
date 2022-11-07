// Программа, выводящая третью цифру заданного числа
// и сообщающая, если цифры нет
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int GetThirdDigitForThreeDigitsNumber(int number)
{
    int thirdDigit = number % 10;
    return thirdDigit;
}
void IsThirdDigit(int number)
{
    if (number > 99)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        Console.WriteLine("Третья цифра равна " + GetThirdDigitForThreeDigitsNumber(number));
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}
Console.WriteLine("Введите число: ");
int number;
while (!int.TryParse(Console.ReadLine()!, out number))
{
    Console.WriteLine("Неверный ввод");
    Console.WriteLine("Введите число: ");
}
IsThirdDigit(number);