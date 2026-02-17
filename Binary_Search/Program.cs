using System;

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
        // ponto de entrada válido. Chame o BinarySearch a partir daqui ou de outro código conforme necessário.
    }
}