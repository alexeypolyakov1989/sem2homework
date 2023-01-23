// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());
int thirdDigit = 0;

if (Number < 100)
{
    Console.WriteLine("Третьей цифры нет");
    return;
}

if (Number > 99 && Number <= 999)
{
    thirdDigit = Number % 10 % 10;
    Console.WriteLine("Третья цифра введенного числа:" + thirdDigit);
    return;
}

if (Number > 9999 && Number <= 99999)
{
    thirdDigit = (Number / 100 % 10);
    Console.WriteLine("Третья цифра введенного числа:" + thirdDigit);
    return;
}

    