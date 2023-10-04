using System;

class Atividade06
{

    public static void Executar()
    {

        double[] medias = new double[10];
        int contador = 0;

        for (int i = 0; i < 10; i++)
        {
            double soma = 0;
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine($"\nInforme a {j + 1}ª nota do aluno {i + 1}");
                soma = soma + Convert.ToDouble(Console.ReadLine());
            }

            medias[i] = soma / 4;

            Console.WriteLine($"\n---Média do aluno {i + 1}: {medias[i]}");

            if (medias[i] >= 7.0)
            {
                contador++;

            }
        }

        Console.WriteLine($"---Alunos com média maior ou igual a 7.0: {contador}");
    }

}