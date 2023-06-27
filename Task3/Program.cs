//  Задача 3:
//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//  [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Clear();
double[] GetRandomArray(int length)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
    return array;
}

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    string inputedString = Console.ReadLine();
    if (int.TryParse(inputedString, out int convertedInt))
    {
        return convertedInt;
    }

    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(0);
    return 0;
}

double GetMaximum(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
    }
    return max;
}

double GetMinimum(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
    }
    return min;
}
void ShowArray(double[] arr)
{
    foreach (double item in arr)
    {
        System.Console.Write($"{item:f2} ");
    }
}

int length = ReadInt("Введите длину массива");

double[] array = GetRandomArray(length);
ShowArray(array);

double max = GetMaximum(array);
double min = GetMinimum(array);

System.Console.WriteLine();
double result = max - min;

System.Console.WriteLine($"Разница между {max:F2} и {min:f2} = {result:f2}");