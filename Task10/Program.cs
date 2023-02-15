Console.WriteLine("Введи число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = number * (-1);
}
if (number < 10)
{
    Console.WriteLine("Веденное число меньше 10. У него нет второй цифры");
    return;
}
int numberSaved = number;
int count = 0;
while (number > 0)
{
    number = number / 10;
    count++;
}

int DigitForLeftPosition = Convert.ToInt32(Math.Pow(10, (count - 2)));

int ThirdPositionNumberLeft = (numberSaved / DigitForLeftPosition) % 10;

Console.WriteLine($"Вторая цифра числа {numberSaved} с левого края равна {ThirdPositionNumberLeft}");
