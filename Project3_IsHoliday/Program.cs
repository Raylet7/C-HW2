// Программа, принимающая цифру, обозначающую день недели, 
//и проверяющая выходной ли этот день
// 6 -> да
// 7 -> да
// 1 -> нет
bool IsWeekDay(int WeekDayNumber)
{
    return WeekDayNumber > 0 && WeekDayNumber < 8;
}
bool IsHoliday(int WeekDayNumber)
{
    return WeekDayNumber == 6 || WeekDayNumber == 7;
}
Console.WriteLine("Введите цифру от 1 до 7, обозначающую день недели ");
int WeekDayNumber;
while (!int.TryParse(Console.ReadLine()!, out WeekDayNumber))
{
    Console.WriteLine("Неверный ввод");
    Console.WriteLine("Введите цифру, обозначающую день недели ");
}
if (IsWeekDay(WeekDayNumber))
{
    if (IsHoliday(WeekDayNumber))
    {
        Console.WriteLine("Да, день выходной");
    }
    else
    {
        Console.WriteLine("Нет, день не выходной");
    }
}
else
{
    Console.WriteLine("Неверный ввод");
    Console.WriteLine("Попробуйте снова запустить программу");
}