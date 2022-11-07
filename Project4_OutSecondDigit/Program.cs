// Программа, принимающая целое число 
//и удаляющая вторую цифру числа слева направо
int OutSecondDigit(int numberA)
{
    int result = numberA;
    int numberB = 0;
    int numberC = 0;
    int numberD = 1;
    if (numberA > 99)
    {
        while (numberA > 99)
        {
            numberB = numberA % 10;
            numberA = numberA / 10;
            numberC = numberB * numberD + numberC;
            numberD = numberD * 10;
        }
        numberA = numberA / 10;
        result = numberD * numberA + numberC;
    }
    if (numberA > 9 && numberA < 100)
    {
        result = numberA / 10;
    }
    return result;
}
Console.Write("Введите целое число: ");
int numberA = int.Parse(Console.ReadLine()!);
if (numberA < 9)
{
    Console.WriteLine("Второй цифры нет");
}
else
{
    int result = OutSecondDigit(numberA);
    Console.WriteLine("Число после удаления второй цифры: " + result);
}