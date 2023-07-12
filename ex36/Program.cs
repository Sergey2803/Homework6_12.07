/*
Задача 36: 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Clear();

int size = GetUserFromNumber("Введите количество элементов массива: ", "Ошибка ввода!");
int minValue = GetUserFromNumber("Введите минимальное значение массива: ", "Ошибка ввода!");
int maxValue = GetUserFromNumber("Введите максимальное значение массива: ", "Ошибка ввода!");
int[] array = GetArray(size, minValue, maxValue);
Console.WriteLine($"массив {String.Join(", ", array)}");
int SumNumber = GetSumNumber(array);
Console.WriteLine($"Сумма нечетных элементов: {SumNumber}");

int GetSumNumber(int[] arr)
{
    int i = 0;
    int sum = 0;
    int b = 0;
    foreach (int el in arr)
    {
        b = i % 2;
        i++;
        if (b != 0) sum += el;
    }
    return sum;
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
        if (int.TryParse(Console.ReadLine(), out int userNumber)) return userNumber;
        else Console.WriteLine(errorMessage);
    }
}