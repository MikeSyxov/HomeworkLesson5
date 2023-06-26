// Задача 1. Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
//  [345, 897, 568, 234] -> 2

Console.Clear();
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

int[] GenerateArray(int length, int start, int end)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(start, end + 1);
    }
    return array;
}

void ShowArray(int[] arr)
{
    foreach (int item in arr)
    {
        System.Console.Write($"{item} ");
    }
}

void CountPositivNumbersInArr(int[] arr)     // функция определния количества четных чисел в массиве
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine(count);
}

int length = ReadInt("Задайте длинну массива числом: ");

int[] arr = GenerateArray(length, 100, 999);

ShowArray(arr);
System.Console.Write("Количество четных чисел в массиве -> ");
CountPositivNumbersInArr(arr);