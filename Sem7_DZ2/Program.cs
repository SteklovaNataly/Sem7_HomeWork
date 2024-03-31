// // Напишите программу вычисления функции Аккермана
//  с помощью рекурсии. 
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
int Ask(int m, int n)
{
if (m == 0) return n + 1;
if (n == 0) return Ask(m - 1, 1);
return Ask(m - 1, Ask(m, n - 1));
}

Console.Write($"Функция Аккермана равно {Ask(n, m)} ");





