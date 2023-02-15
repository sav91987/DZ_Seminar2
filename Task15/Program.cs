Console.WriteLine("Введи цифру");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = number * (-1);
}
if ((number > 0) && (number <= 7))
{
    if ((number == 1) || (number == 2) || (number == 3) || (number == 4) || (number == 5))
    {
        Console.WriteLine("Будний день");
    }
    else
    {
        Console.WriteLine("Выходной день");
    }
}
else
{
    Console.WriteLine("В неделе 7 дней. Введите корректное число");
}

