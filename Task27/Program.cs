// Задача 27: 
// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumOfDigits(int num)    // метод суммирует цифры числа
{
    if (num < 0) num = -num;    // если число < 0, преобразуется в >0
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;   // к сумме добавляем остаток от % деления на 10
        num /= 10;
    }
    return sum;
}

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigits = SumOfDigits(number);
Console.WriteLine($"{number} -> {sumDigits}");