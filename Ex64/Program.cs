/*
Задача 64: Задайте значение M и N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до M. Выполнить с помощью рекурсии.

M = 1; N = 5. -> "5,4,3,2,1"

M = 4; N = 8. -> "8, 7, 6, 5, 4"
*/


int Number(int M, int N, int[] mas)
{
    if (M > N) return M;
    else return mas[N-M] = Number(M + 1, N, mas) - 1;
}

Console.Clear();
Console.Write("Введите М = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N = ");
int N = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[N - M + 1];
Number(M, N, mas);
Console.WriteLine($"{string.Join(", ", mas)}");




