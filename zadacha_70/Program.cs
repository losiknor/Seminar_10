// Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт
// первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
// 3 и 4, N = 5 -> 3 4 7 11 18
// 6 и 10, N = 4 -> 6 10 16 26
Console.WriteLine("Задайте первое число:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте второе число:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте количество чисел, которое нужно вывести:");
int n = int.Parse(Console.ReadLine());
int Row(int n, int a, int b)
{
    if (n == 1) return a;
    if (n == 2) return b;
    {
        return Row(n-1, a, b) + Row(n-2, a, b);         
    }
}
for (int i = 1; i <= n; i++)
Console.Write(Row(i, a, b) + " ");