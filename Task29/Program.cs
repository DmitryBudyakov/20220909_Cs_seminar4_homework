// Задача 29:
// Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

void FillArray(int[] array)     // заполняет массив случайными числами
{
    int length = array.Length;
    int rndRange = 100;         // диапазон выборки Random [0;100)
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(rndRange);
    }
}

void PrintArray(int[] array)    // выводит элементы массива в консоль
{
    int length = array.Length;
    string arrayList = String.Empty;
    for (int i = 0; i < length; i++)
    {
        if (i != length - 1) arrayList += $"{array[i]}, ";
        else arrayList += $"{array[i]}";
    }
    Console.WriteLine($"{arrayList} -> [{arrayList}]");
}

int[] arr = new int[8];

FillArray(arr);
PrintArray(arr);
