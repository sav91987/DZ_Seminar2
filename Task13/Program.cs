Console.WriteLine("Введи число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = number * (-1);
}
if (number < 100)
{
    Console.WriteLine("Веденное число меньше 100. У него нет третьей цифры ни справа, ни слева");
    return;
}

int numberSaved = number;
int count = 0;
while (number > 0)
{
    number = number / 10;
    count++;
}

int DigitForLeftPosition = Convert.ToInt32(Math.Pow(10, (count - 3)));

int ThirdPositionNumberLeft = (numberSaved / DigitForLeftPosition) % 10;
int ThirdPositionNumberRight = (numberSaved % 1000) / 100;

Console.WriteLine($"Третья цифра числа {numberSaved} с левого края равна {ThirdPositionNumberLeft}");
Console.WriteLine($"Третья цифра числа {numberSaved} с правого края равна {ThirdPositionNumberRight}");
