using System;

class Compras
{
    static void Main()
    {
        string[] comprasArray = { "Frango", "Bife", "Maçã", "Banana", "Peixe", "Pera", "Tomate", "Laranja" };

        // Simulando um Merge Sort, separando a array em 2 subarrays de tamanho = 4
        string[] subArray1 = new string[4];
        string[] subArray2 = new string[4];

        Array.Copy(comprasArray, 0, subArray1, 0, 4);
        Array.Copy(comprasArray, 4, subArray2, 0, 4);

        // Ordena as subarrays usando um Insertion Sort
        Array.Sort(subArray1);
        Array.Sort(subArray2);

        // Junta as duas subarrays
        string[] novaArray = new string[subArray1.Length + subArray2.Length];
        Array.Copy(subArray1, 0, novaArray, 0, subArray2.Length);
        Array.Copy(subArray2, 0, novaArray, subArray1.Length, subArray2.Length);

        // Ordena a array que foi juntada
        Array.Sort(novaArray);

        // Resultado
        Console.WriteLine("Itens do Mercado: {0}", string.Join(", ", comprasArray));
        Console.WriteLine("1ª Array ordenada: {0}", string.Join(", ", subArray1));
        Console.WriteLine("2º Array ordenada: {0}", string.Join(", ", subArray2));
        Console.WriteLine("Array combinada e ordenada: {0}", string.Join(", ", novaArray));
    }
}