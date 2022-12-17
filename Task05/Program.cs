
// Задача 4: 
// Напишите программу, которая будет 
// создавать копию заданного массива с 
// помощью поэлементного копирования.

int[] GenerateArray(int len)
{
    int[] array = new int[len];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random(). Next(0, 10);
    }
    return array;
}    
    int Prompt(string message)
{
    Console.WriteLine($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
    Console.WriteLine();
}
int [] Array = GenerateArray(8);
PrintArray(Array);

Array[0] = 999;
int [] Array1 = Array;
PrintArray(Array1);