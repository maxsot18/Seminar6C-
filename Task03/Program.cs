// Задача 2: Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int Prompt(string message)
{
    Console.WriteLine($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

int[] Binary(int number)
{
    int i = 1;
    int[] bin = new int [8];
    while(number > 0)
    {
        int binar = number % 2;
        bin[bin.Length - i] = binar;
        number = number / 2;
        i++;
        
       
    }
    return bin;


}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
    Console.WriteLine();
}
int Value = Prompt("Enter a number ");
Console.Write("Binary number of {Value} = ");
PrintArray(Binary(Value));
