/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int sum(int M, int N)
{
    if (M == N) return N;
    else return N + sum(M, N -1); 
}


Console.Clear();
Console.Write("Введите М = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N = ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sum(M, N));
