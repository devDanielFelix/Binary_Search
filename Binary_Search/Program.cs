using System;
using System.Runtime.ConstrainedExecution;

class Program
{
    static int BinarySearch(int[] array, int valor)
    {
        int esquerdo = 0;
        int direito = array.Length - 1;

        while (esquerdo <= direito)
        {
            int meio = esquerdo + (direito - esquerdo) / 2;

            if (array[meio] == valor)
            {
                return meio; // Valor encontrado, retorna o índice
            }
            else if (array[meio] < valor)
            {
                esquerdo = meio + 1; // Continua a busca na metade direita
            }
            else
            {
                direito = meio - 1; // Continua a busca na metade esquerda
            }
        }
        return -1; // Valor não encontrado
    }

    static void Main(string[] args)
    {
        int[] arrayOrdenado = { 2, 5, 8, 12, 16, 23, 38, 45, 56, 67, 78 };
        int valorBuscado = 23;

        Console.WriteLine("Array: " + string.Join(", ", arrayOrdenado));
        Console.WriteLine($"Buscando o valor: {valorBuscado}");

        int resultado = BinarySearch(arrayOrdenado, valorBuscado);

        if (resultado != -1)
        {
            Console.WriteLine($"Valor encontrado: {resultado}");
        }
        else
        {
            Console.WriteLine("Valor não encontrado no indice.");
        }

        //Teste com valor não existente
        Console.WriteLine("\nBuscando valor não existente (99):");
        int resultadoNaoExiste = BinarySearch(arrayOrdenado, 99);
        Console.WriteLine(resultadoNaoExiste == -1 ? "Elemento não encontrado" : $"Elemento encontrado no indice {resultadoNaoExiste}");
    }
}