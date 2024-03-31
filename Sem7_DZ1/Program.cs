// // Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// m=1, n=5 =>"1,2,3,4,5"
// m=4, n=8 =>"4,5,6,7,8"


Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
void PrintNaturalNumbers(int m, int n)
{
    if (m > n) return;

    {
        Console.Write($"{m}, ");
    }
    PrintNaturalNumbers(m + 1, n);

}
PrintNaturalNumbers(m, n);
void PrintNaturalNumbers1(int m, int n)
{
    if (m < n) return;

    {
        Console.Write($"{m}, ");
    }
    PrintNaturalNumbers1(m - 1, n);

}
PrintNaturalNumbers1(m, n);


