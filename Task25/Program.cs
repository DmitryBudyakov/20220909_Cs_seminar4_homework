// Задача 25:
// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int DegreeOfNumber(int numA, int numB)
{
    int total = 1;
    if (numB > 0)
    {
        for (int i = 1; i <= numB; i++)
        {
            total = total * numA;
        }
        return total;
    }
    return total;
}

Console.Clear();
Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB >= 0)
{
    int result = DegreeOfNumber(numberA, numberB);
    Console.WriteLine($"{numberA}, {numberB} -> {result}");
}
else Console.WriteLine("Число B должно быть натуральным (> 1).");


