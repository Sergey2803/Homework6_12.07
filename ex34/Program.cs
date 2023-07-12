/*
Задача 34: 
Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая 
покажет количество чётных чисел в массиве.
*/

Console.Clear();

int size = GetUserFromNumber("Введите количество элементов массива: ", "Ошибка ввода!");
int[] array = GetArray(size, 99, 999);
Console.WriteLine($"массив {String.Join(", ", array)}");
int SumPositive = GetPositiveSum(array);
Console.WriteLine($"Количество четных чисел в массиве {SumPositive}");

int GetPositiveSum(int[] arr)
{
    int positiveSum = 0;
    int b = 0;
    foreach (int el in arr)
    {
        b = el % 2;
        if (b == 0) positiveSum += 1;
    }
    return positiveSum;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int GetUserFromNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int UserNumber)) return UserNumber;
        else Console.WriteLine(errorMessage);
    }
}