// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int Number = Convert.ToInt32(Console.ReadLine());
int secondDigit = 0;

if (Number > 99 && Number < 1000)
{    
    secondDigit = Number % 100 / 10;
    Console.WriteLine("Вторая цифра введенного числа:" + secondDigit);
}

else
Console.WriteLine("Введено не трехзначное число");