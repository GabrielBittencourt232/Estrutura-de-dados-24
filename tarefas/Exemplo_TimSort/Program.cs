using System;

class Program
{
    static void Main()
    {
        int[] array = { 5, 2, 9, 1, 5, 6 };

        // Array.Sort() usa TimSort internamente
        Array.Sort(array);

        Console.WriteLine("Array Ordenado:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
    }
}
