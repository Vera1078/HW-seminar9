// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

void Task64()
{
    Console.WriteLine("Введите число m: ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число n: ");
    int N = Convert.ToInt32(Console.ReadLine());

if (M > N)
for (int i = N; i <= M; i++)
    Console.Write($" {i}");
else
    for (int i = M; i <= N; i++)
        Console.Write($" {i}");
        return;
}
Task64();
System.Console.WriteLine();
System.Console.WriteLine();

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void Task66()
{
    Console.WriteLine("Введите число m: ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число n: ");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
int sum = 0;

if (M > N)
for (int i = N; i <= M; i++)
{
    Console.Write($" {i}");
    sum += i;
}
else
    for (int i = M; i <= N; i++)
    {
        Console.Write($" {i}");
        sum += i;
        
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N = {sum}");
    Console.WriteLine();
    return;
}
Task66();

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

void Task68()
{
    Console.WriteLine("Введите число m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

   int Akkerman = A(m, n);

Console.Write($"A(m,n) = {Akkerman} ");

int A(int m, int n)
{
  if (m == 0) return n + 1;
  else if ((m > 0) && (n == 0)) return A(m - 1, 1);
  else return (A(m - 1, A(m, n - 1)));
}
}
Task68();