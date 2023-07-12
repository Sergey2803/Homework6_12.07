/*
Задача 38: 
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и 
минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.Clear();
int size = GetUserFromNumber("Введите количество элементов массива: ", "Ошибка ввода!");
int minValue = GetUserFromNumber("Введите минимальный элемент массива: ", "Ошибка ввода!");
int maxValue = GetUserFromNumber("Введите максимальный элемент массива: ", "Ошибка ввода!");
double[] array = GetArray(size, minValue, maxValue);
Console.WriteLine($"массив {String.Join(", ", array)}");
double MinNumber = GetMinNumber(array);
double MaxNumber = GetMaxNumber(array);
Console.WriteLine($"Минимальное число: {MinNumber}");
Console.WriteLine($"Максимальное число: {MaxNumber}");
double difference = MaxNumber - MinNumber;
Console.WriteLine($"Разница между максимальным и минимальным числом: {difference}");

double GetMinNumber(double[] arr)
{
    double min = array[0];
    foreach (int el in arr)
    {
        if (el < min) min = el;
    }
    return min;
}

double GetMaxNumber(double[] arr)
{
    double max = array[0];
    foreach (int el in arr)
    {
        if (el > max) max = el;
    }
    return max;
}

double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        res[i] = rand.Next(minValue, maxValue) + rand.NextDouble();
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

/*
array[i] = rand.Next(-100, 100) + rand.NextDouble();

double[] array = new double[n];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
array[i] = rand.NextDouble();

*/