// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

string PrintNumbersInRange(int M, int N)
{
    if (N < M) return ("N - должна быть больше M");
    if (M == N) return M.ToString();
    return M + ", " + PrintNumbersInRange(M + 1, N);
}


// -----------------------

Console.Write("Введите значение первого натурального числа. M = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение второго натурального числа. N = ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine('"'+ PrintNumbersInRange(M, N)+ '"');