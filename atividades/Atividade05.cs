using System;

class Atividade05
{

    public static void Executar()
    {
        int[] vetor = new int[20];
        int[] impar = new int[20];
        int[] par = new int[20];

        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Informe o {i + 1} número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            vetor[i] = numero;

            if (vetor[i] % 2 == 0)
                par[i] = numero;
            else
                impar[i] = numero;
        }

        Console.WriteLine("\nNúmeros:");
        ImprimirVetor(vetor);

        Console.WriteLine("\nNúmeros Pares:");
        ImprimirVetor(par);

        Console.WriteLine("\nNúmeros Ímpares:");
        ImprimirVetor(impar);

    }

    static void ImprimirVetor(int[] vetor)
    {
        foreach (int numero in vetor)
        {
            if (numero != 0)
            {
                Console.Write($"{numero} ");
            }
        }
    }
}