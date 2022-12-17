// Задача 3: Не используя рекурсию, выведите 
// первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

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

int[] Fibonacci(int number)
{
    int[] Fib = new int[number];
    Fib[0] = 0;
    Fib[1] = 1;
    for (int i = 2; i < number; i++)
    {
        Fib[i] = Fib[i - 1] + Fib[i - 2];
    }
    return Fib;
}
int Fib = Prompt("Enter a number ");
PrintArray(Fibonacci(Fib));

