// программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите номер дня недели, где 1 - понедельник, 7 - воскресенье");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number > 0 && Number < 6)
{
    Console.WriteLine("Это будний день");
    return;
}

if (Number > 5 && Number <= 7)
{
    Console.WriteLine("Этот день выходной");
    return;
}

else
Console.WriteLine("Указано неверное число");