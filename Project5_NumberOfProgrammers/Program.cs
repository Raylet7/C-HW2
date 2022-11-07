// Программа, которая при вводе неотрицательного целого числа до 1000,
// выводит количество программистов, 
// просклоняв слово "программист" с этим числом
// 1 программист, 2 программиста, 5 программистов
void SelectLastDigits(int numberOfProgrammers, int lastDigit, int twoLastDigits)
{
    if(twoLastDigits > 10 && twoLastDigits < 15)
    {
        Console.WriteLine(numberOfProgrammers + " программистов");
    }
    else
    {
        if(lastDigit == 1)
        {
            Console.WriteLine(numberOfProgrammers + " программист");
        }
        if(lastDigit > 1 && lastDigit < 5)
        {
            Console.WriteLine(numberOfProgrammers + " программиста");
        }
        if(lastDigit > 4 || lastDigit == 0)
        {
            Console.WriteLine(numberOfProgrammers + " программистов");
        }
    }
}
Console.WriteLine("Введите число программистов: ");
int numberOfProgrammers = int.Parse(Console.ReadLine()!);
int lastDigit = numberOfProgrammers % 10;
int twoLastDigits = numberOfProgrammers % 100;
SelectLastDigits(numberOfProgrammers, lastDigit, twoLastDigits);