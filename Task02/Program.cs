// Задача 1: Напишите программу, 
// которая принимает на вход три числа и проверяет,
//  может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона 
// треугольника меньше суммы двух других сторон.

int Prompt(string message)
{
    Console.WriteLine($"{message} ");
    return Convert.ToInt32(Console.ReadLine());
}

bool Triangle(int A, int B, int C)
{
    if (A + B > C)
    {
       return true;
    }
    return false;
}
int A = Prompt("Enter side A");
int B = Prompt("Enter side B");
int C = Prompt("Enter side C");
if (Triangle(A, B, C) && Triangle(B, C, A) && Triangle(A, C, B))
{
    
    Console.WriteLine("Triangle may be with this sides ");
}
else
{
Console.WriteLine("No, it isn't really ");
}