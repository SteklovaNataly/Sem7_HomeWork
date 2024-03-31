// // Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 


void PrintElementsReverse(int[] Arr, int n)
{
    if (n > 0)
    {
        Console.Write(Arr[n] + " ");
        PrintElementsReverse(Arr, n - 1);
    }
    else Console.WriteLine(Arr[0]);
}
    int[] num = { 1, 2, 5, 0, 10, 34 };
    PrintElementsReverse(num, num.Length - 1);

