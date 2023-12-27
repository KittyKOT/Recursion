// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Ackermann(int m, int n)
{
    if (m == 0) return (n+1);
    else if (n == 0) return Ackermann(m-1,1);
    else return Ackermann(m-1,Ackermann(m,n-1));
}

// ----------------------------

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

while (m <= 0 || n <=0)
    {
        Console.Write("Оба числа должны быть натуральными.");
        Console.WriteLine();
        Console.Write("Введите число m: ");
        m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число n: ");
        n = Convert.ToInt32(Console.ReadLine());
    }
// Console.WriteLine(Ackermann(m, n));

int result = Ackermann(m, n);
Console.WriteLine("m = " + m + ", n = " + n + " -> A(" + m + "," + n + ") = " + result);