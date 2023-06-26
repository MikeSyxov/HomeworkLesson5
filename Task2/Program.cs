// Задача 2:
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

void SumOddElemArray(int[] arr)    //функция. Найдите сумму элементов, стоящих на нечётных позициях
{
    int sum = 0;
    for (int i = 1; i < arr.Length;)
    {
        sum = sum + arr[i];
        i+=2;
    }
    System.Console.WriteLine($"сумму элементов, стоящих на нечётных позициях равна {sum}");
}

int length = ReadInt("Задайте длинну массива числом: ");
int[] arr = GenerateArray(length, -10, 10);

ShowArray(arr);
System.Console.WriteLine();
SumOddElemArray(arr);